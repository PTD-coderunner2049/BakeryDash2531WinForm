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
            var staffData = new CRUD().GetStaffs();

            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(Guid));
            dt.Columns.Add("FirstName", typeof(string));
            dt.Columns.Add("LastName", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("PhoneContact", typeof(string));
            dt.Columns.Add("Gender", typeof(string));
            dt.Columns.Add("Birth", typeof(DateTime));
            dt.Columns.Add("SSN", typeof(string));
            dt.Columns.Add("LastHistoryStart", typeof(DateTime));
            dt.Columns.Add("PayratePerHrs", typeof(decimal));
            dt.Columns.Add("IsSystemManager", typeof(bool));
            dt.Columns.Add("Active", typeof(bool));

            foreach (var item in staffData)
            {
                dt.Rows.Add(
                    item.Staff.Id,
                    item.Staff.FirstName,
                    item.Staff.LastName,
                    item.Staff.Email,
                    item.Staff.PhoneContact,
                    item.Staff.Gender,
                    item.Staff.Birth,
                    item.Staff.SSN,
                    item.LastHistoryStart,
                    item.Staff.PayratePerHrs,
                    item.Staff.IsSystemManager,
                    item.Staff.Active
                );
            }
            return dt;
        }
        public DataTable HistoryFetch(Guid id)
        {
            var rawHistory = new CRUD().GetHistories(id);

            DataTable dt = new DataTable();
            dt.Columns.Add("StartDate", typeof(DateTime));
            dt.Columns.Add("EndDate", typeof(DateTime));
            dt.Columns.Add("Ongoing", typeof(bool));
            dt.Columns.Add("FeedBack", typeof(string));

            foreach (var h in rawHistory)
            {
                dt.Rows.Add(
                    h.Start,
                    h.End,
                    h.Ongoing,
                    h.HR_Feedback
                );
            }
             
            return dt;
        }



        public bool SaveHistory(Guid staffId, string hr_feedback)
        {
            return new CRUD().svHistory(staffId, hr_feedback);
        }
        public bool SaveStaff(
            Guid empGuid, string email, string fName, string lName,
            string phone, string gender, DateTime birth, string ssn, decimal pay,
            //DateTime employedAt,
            bool isManager, bool isActive)
        {
            return new CRUD().UpsertStaff(empGuid, email, fName, lName, phone, gender, birth, ssn, pay,
                //employedAt,
                isManager, isActive
            );
        }


        public bool DelStaff(Guid empGuid)
        {
            CRUD crud = new CRUD();
            Staff staff = crud.GetStaffSingle(empGuid);
            return crud.RemoveStaff(staff);
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