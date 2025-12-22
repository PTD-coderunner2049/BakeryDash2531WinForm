using SolbergBakery2531.DAL;
using SolbergBakery2531.DAL.Data;
using SolbergBakery2531.DAL.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace SolbergBakery2531.BLL
{
    public class ProductService
    {
        public DataTable Fetch()
        {
            var productList = new CRUD().GetProd();

            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(Guid));
            dt.Columns.Add("Description", typeof(string));
            dt.Columns.Add("Note", typeof(string));
            dt.Columns.Add("AvailableDate", typeof(DateTime));
            dt.Columns.Add("DiscontinueDate", typeof(DateTime));
            dt.Columns.Add("ProdCategoryId", typeof(Guid));
            dt.Columns.Add("Pricing", typeof(decimal));
            dt.Columns.Add("Name", typeof(string));

            foreach (var p in productList)
            {
                dt.Rows.Add(
                    p.Id,
                    p.Description,
                    p.Note,
                    p.AvailableDate,
                    p.DiscontinueDate,
                    p.ProdCategoryId,
                    p.Pricing,
                    p.Name
                );
            }
            return dt;
        }
        public DataTable Fetch(Guid cateId)
        {
            var products = new CRUD().GetProd(cateId);

            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(Guid));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("quantityInStock", typeof(int));
            dt.Columns.Add("Pricing", typeof(decimal));

            foreach (var p in products)
            {
                dt.Rows.Add(
                    p.Id,
                    p.Name,
                    p.quantityInStock,
                    p.Pricing
                );
            }
            return dt;
        }
        public DataTable FetchCate()
        {
            var categories = new CRUD().GetProdCate();

            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(Guid));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("EngName", typeof(string));

            foreach (var cat in categories)
            {
                dt.Rows.Add( cat.Id, cat.Name, cat.EngName
                );
            }
            return dt;
        }
        public DataTable FetchVisual(Guid productId)
        {
            var visuals = new CRUD().GetProdVisual(productId);

            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(Guid));
            dt.Columns.Add("VisualinByte", typeof(byte[]));
            dt.Columns.Add("ProductId", typeof(Guid));

            foreach (var v in visuals)
            {
                dt.Rows.Add(
                    v.Id,
                    v.VisualinByte,
                    v.ProductId
                );
            }
            return dt;
        }

        public bool DelProd(Guid Id)
        {
            CRUD crud = new CRUD();
            crud.RemoveProdVByProdId(Id);
            Product prod = crud.GetProdSingle(Id);
            return crud.RemoveProd(prod);
        }
        public bool SaveProdVisual(byte[] visual, Guid prodId) => new CRUD().InsertProdV(visual, prodId);
        public bool DelProdVisual(Guid Id) => new CRUD().RemoveProdV(Id);


        public bool UpdateStock(Guid prodId, int quantity)
        {
            return new CRUD().UpdateStockLevel(prodId, quantity);
        }
        public bool SaveProd(Guid Id, string Name, string Des, string Note, decimal Price, DateTime ADate, DateTime DDate, Guid cateId)
        {
            return new CRUD().SaveProd(Id, Name, Des, Note, Price, ADate, DDate, cateId);
        }
        public string ValidateInputs(string na, string des, string note, string pri, DateTime AD, DateTime DD)
        {
            if (string.IsNullOrWhiteSpace(des) ||
                string.IsNullOrWhiteSpace(na) ||
                string.IsNullOrWhiteSpace(note) ||
                string.IsNullOrWhiteSpace(pri))
                return "All information fields except availabilities are required.";
            if (!decimal.TryParse(pri, out decimal pricing) || pricing < 0)
                return "Pricing must be a valid non-negative decimal number.";
            if(AD > DD)
                return "Available Date cannot be later than Discontinue Date.";
            return null;
        }
    }
}
