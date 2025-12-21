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
        public DataTable Fetch() => new CRUD().GetProd();
        public DataTable Fetch(Guid cateId) => new CRUD().GetProd(cateId);
        public DataTable FetchVisual(Guid productId) => new CRUD().GetProdVisual(productId);
        public DataTable FetchCate() => new CRUD().GetProdCate();


        public bool DelProd(Guid Id) => new CRUD().RemoveProd(Id);
        public bool SaveProdVisual(byte[] visual, Guid prodId) => new CRUD().InsertProdVisual(visual, prodId);
        public bool DelProdVisual(Guid Id) => new CRUD().RemoveProdVisual(Id);


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
