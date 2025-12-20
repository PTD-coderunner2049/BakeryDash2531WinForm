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
        //public bool SaveProd(Guid staffId, string username, string passwordHash, bool Active)
        //{
        //    return new CRUD().UpsertUser(staffId, username, passwordHash, Active);
        //}
        //public bool DelProd(Guid staffId)
        //{
        //    return new CRUD().RemoveUser(staffId);
        //}
        public DataView GetFilteredProd(DataTable fullTable, string columnName, string filterValue)
        {
            if (fullTable == null) return null;

            string safeValue = filterValue.Replace("'", "''");
            string expression = $"CONVERT({columnName}, 'System.String') LIKE '%{safeValue}%'";

            fullTable.DefaultView.RowFilter = expression;
            return fullTable.DefaultView;
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
