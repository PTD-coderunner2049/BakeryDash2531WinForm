using SolbergBakery2531.DAL.Data;
using SolbergBakery2531.DAL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
namespace SolbergBakery2531.DAL
{
    public partial class CRUD
    {
        public List<ProductHistory> GetHistoryByProduct(Guid productId)
        {
            using (var db = new BakeryDbContext())
            {
                return db.ProductHistories
                         .Where(h => h.ProductId == productId)
                         .OrderByDescending(h => h.ChangeOccur)
                         .ToList();
            }
        }
        public List<ProductHistory> GetAllHistory()
        {
            using (var db = new BakeryDbContext())
            {
                return db.ProductHistories
                         .OrderByDescending(h => h.ChangeOccur)
                         .ToList();
            }
        }

        public bool LogStockHistory(Guid productId, int changeQty, decimal importVal, decimal saleVal, string source)
        {
            //prod history
            using (var db = new BakeryDbContext())
            {
                //var product = db.Products.FirstOrDefault(p => p.Id == productId);
                //if (product == null) return false;
                // this method would never becall without a product anyway.
                decimal worth = 0;

                if (source == "From Order")
                {
                    worth = (saleVal - importVal) * Math.Abs(changeQty);
                }
                else if (source == "Admin/Waste")
                {
                    worth = importVal * changeQty;
                }
                else
                {
                    worth = (saleVal - importVal) * changeQty;
                }// Solid profit - Total lost - Potential profit

                var history = new ProductHistory
                {
                    ChangeId = Guid.NewGuid(),
                    ProductId = productId,
                    ChangeQuantity = changeQty,
                    ImportValue = importVal,
                    SaleValue = saleVal,
                    Source = source,
                    TotalWorth = worth,
                    ChangeOccur = DateTime.Now,
                };
                db.ProductHistories.Add(history);
                return db.SaveChanges() > 0;
            }
        }
        public bool RemoveHistoryEntry(Guid changeId)
        {
            using (var db = new BakeryDbContext())
            {
                var entry = db.ProductHistories.FirstOrDefault(h => h.ChangeId == changeId);
                if (entry != null)
                {
                    db.ProductHistories.Remove(entry);
                    return db.SaveChanges() > 0;
                }
                return false;
            }
        }
    }
}
