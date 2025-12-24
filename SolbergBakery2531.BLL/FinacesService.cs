using SolbergBakery2531.DAL;
using SolbergBakery2531.DAL.Model;
using SolbergBakery2531.DAL.Model.DTOModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SolbergBakery2531.BLL
{
    public class FinacesService
    {
        private readonly CRUD _crud = new CRUD();

        public DataTable GetTopSalesGrid()
        {
            var allHistory = _crud.GetAllHistory(); //
            var products = _crud.GetProd(); //

            // Aggregate data using DTO internally
            var aggregatedData = allHistory
                .Where(h => h.Source == "From Order") // Filter as requested
                .GroupBy(h => h.ProductId)
                .Select(g => new ProductHDisplayDTO
                {
                    ProductHistory = new ProductHistory
                    {
                        ProductId = g.Key,
                        TotalWorth = g.Sum(x => x.TotalWorth), // Sum Profit
                        ChangeQuantity = g.Sum(x => Math.Abs(x.ChangeQuantity)) // Absolute Sum
                    },
                    ProductName = products.FirstOrDefault(p => p.Id == g.Key)?.Name ?? "Unknown"
                })
                .OrderByDescending(dto => dto.ProductHistory.TotalWorth)
                .ToList();

            // Prepare DataTable for UI (UI cannot see DTO)
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(Guid));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Quantity", typeof(int));
            dt.Columns.Add("Profit", typeof(decimal));

            foreach (var item in aggregatedData)
            {
                dt.Rows.Add(item.ProductHistory.ProductId, item.ProductName, item.ProductHistory.ChangeQuantity, item.ProductHistory.TotalWorth);
            }
            return dt;
        }

        public DataTable GetFinancialStatsByCategory(int year, int? month)
        {
            var histories = _crud.GetAllHistory();
            var categories = _crud.GetProdCate(); //
            var products = _crud.GetProd();

            // Filter by Date
            histories = histories.Where(h => h.ChangeOccur.Year == year).ToList();
            if (month.HasValue && month.Value > 0)
                histories = histories.Where(h => h.ChangeOccur.Month == month.Value).ToList();

            DataTable dt = new DataTable();
            dt.Columns.Add("CategoryName", typeof(string));
            dt.Columns.Add("Profit", typeof(decimal));
            dt.Columns.Add("Gross", typeof(decimal));

            foreach (var cat in categories)
            {
                var catProdIds = products.Where(p => p.ProdCategoryId == cat.Id).Select(p => p.Id).ToList();
                var catHistory = histories.Where(h => catProdIds.Contains(h.ProductId)).ToList();

                decimal profit = catHistory.Sum(h => h.TotalWorth);
                decimal gross = catHistory.Where(h => h.Source == "From Order")
                                          .Sum(h => (decimal)Math.Abs(h.ChangeQuantity) * h.SaleValue);

                dt.Rows.Add(cat.Name, profit, gross);
            }
            return dt;
        }
    }
}