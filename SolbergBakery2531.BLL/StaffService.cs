using SolbergBakery2531.DAL;
using SolbergBakery2531.DAL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Remoting.Contexts;

namespace SolbergBakery2531.BLL
{
    public class StaffService
    {
        public DataTable Fetch()
        {
            return new CRUD().GetStaffs();
        }
        public DataTable HistoryFetch(Guid Id)
        {
            return new CRUD().GetHistories(Id);
        }
        public bool SaveHistory(Guid staffId, string hr_feedback)
        {
            return new CRUD().svHistory(staffId, hr_feedback);
        }
        public bool SaveStaff(
            Guid empGuid,
            string email,
            string fName,
            string lName,
            string phone,
            string gender,
            DateTime birth,
            string ssn,
            decimal pay,
            //DateTime employedAt,
            bool isManager,
            bool isActive)
        {
            return new CRUD().UpsertStaff(empGuid, email, fName, lName, phone, gender, birth, ssn, pay,
                //employedAt,
                isManager, isActive
            );
        }
        public bool DelStaff(Guid empGuid)
        {
            return new CRUD().RemoveStaff(empGuid);
        }
        public string ValidateInputs(string FnameText, string LnameText, string emailText, string phoneText,
            string ssnText, string payrateText, string birthText,
            int gendercount)
        {
            if (string.IsNullOrWhiteSpace(FnameText) ||
                string.IsNullOrWhiteSpace(LnameText) ||
                string.IsNullOrWhiteSpace(emailText) ||
                string.IsNullOrWhiteSpace(phoneText) ||
                string.IsNullOrWhiteSpace(ssnText) ||
                string.IsNullOrWhiteSpace(payrateText))
                return "All staff information fields are required.";
            if (gendercount != 1)
                return "Please select one gender.";
            if (!decimal.TryParse(payrateText, out decimal payrate))
                return "Pay Rate must be a valid decimal number.";
            return null;
        }
    }
}