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
            return new CRUD().GetProd();
        }
        public DataTable FetchVisual()
        {
            return new CRUD().GetProdVisual();
        }
        public DataTable FetchCate()
        {
            return new CRUD().GetProdCate();
        }
        public bool SaveProd(Guid Id, string Name, string Des, string Note, decimal Price, DateTime ADate, DateTime DDate,Guid cateId)
        {
            return new CRUD().SaveProd(Id, Name, Des, Note, Price, ADate, DDate);
        }
        public bool DelProd(Guid Id)
        {
            return new CRUD().RemoveProd(Id);
        }
        public bool SaveProdVisual(Guid Id, byte[] visual, Guid prodId)
        {
            return new CRUD().InsertProdVisual(Id, visual, Id);
        }
        public bool DelProdVisual(Guid Id)
        {
            return new CRUD().RemoveProdVisual(Id);
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
