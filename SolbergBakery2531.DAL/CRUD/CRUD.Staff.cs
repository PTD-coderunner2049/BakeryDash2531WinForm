using SolbergBakery2531.DAL.Data;
using SolbergBakery2531.DAL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;

namespace SolbergBakery2531.DAL
{
    public partial class CRUD
    {
        public DataTable GetStaffs()
        {
            using (var db = new BakeryDbContext())
            {
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

                var staffList = db.Staffs.Select(s => new
                {
                    s.Id,
                    s.FirstName,
                    s.LastName,
                    s.Email,
                    s.PhoneContact,
                    s.Gender,
                    s.Birth,
                    s.SSN,
                    //s.EmployedAt,
                    s.PayratePerHrs,
                    s.IsSystemManager,
                    s.Active,
                    
                    //History navigation is a collection, so I cant take it all yet, it better to LinQ it all when need later)
                    LastHistoryStart = s.Histories 
                        .OrderByDescending(h => h.Start)
                        .Select(h => (DateTime?)h.Start)
                        .FirstOrDefault()
                }).ToList();

                foreach (var s in staffList)
                {
                    dt.Rows.Add(
                        s.Id,
                        s.FirstName,
                        s.LastName,
                        s.Email,
                        s.PhoneContact,
                        s.Gender,
                        s.Birth,
                        s.SSN,
                        s.LastHistoryStart,
                        s.PayratePerHrs,
                        s.IsSystemManager,
                        s.Active
                    );
                }
                return dt;
            }
        }
        public bool UpsertStaff(Guid empGuid, string email, string fName, string lName, string phone, string gender, DateTime birth, string ssn, decimal pay, bool isManager, bool Active)
        {
            using (var db = new BakeryDbContext())
            {
                var staff = db.Staffs.FirstOrDefault(s => s.Id == empGuid);

                if (staff != null) //update
                {
                    if (staff.Active != Active)
                    {
                        Historian(db, empGuid, Active);
                    }
                    staff.Email = email;
                    staff.FirstName = fName;
                    staff.LastName = lName;
                    staff.PhoneContact = phone;
                    staff.Gender = gender;
                    staff.Birth = birth;
                    staff.SSN = ssn;
                    staff.PayratePerHrs = pay;
                    staff.IsSystemManager = isManager;
                    staff.Active = Active;

                }
                else //insert
                {
                    if (db.Staffs.Any(s => s.SSN == ssn || s.Email == email))
                    {
                        return false;
                    }

                    var newStaff = new Staff
                    {
                        Id = empGuid == Guid.Empty ? Guid.NewGuid() : empGuid,
                        Email = email,
                        FirstName = fName,
                        LastName = lName,
                        PhoneContact = phone,
                        Gender = gender,
                        Birth = birth,
                        SSN = ssn,
                        PayratePerHrs = pay,
                        IsSystemManager = isManager,
                        Active = Active
                    };
                    db.Staffs.Add(newStaff);
                    bool result = db.SaveChanges() > 0;

                    if (Active)
                    {
                        Historian(db, newStaff.Id, Active);
                        result = db.SaveChanges() > 0;
                    }
                    return result;
                }
                return db.SaveChanges() > 0;
            }
        }
        public void Historian(BakeryDbContext db, Guid Id, bool OngoingStatus)
        {
            if (OngoingStatus)
            {
                db.StaffHistories.Add(new StaffHistory
                {
                    StaffId = Id,
                    Start = DateTime.UtcNow,
                    Ongoing = OngoingStatus
                });
            }
            else
            {
                var ongoingHistory = db.StaffHistories.FirstOrDefault(h => h.StaffId == Id && h.Ongoing);
                if (ongoingHistory != null)
                {
                    ongoingHistory.End = DateTime.UtcNow;
                    ongoingHistory.Ongoing = OngoingStatus;
                }
            }
        }
        public bool RemoveStaff(Guid empGuid)
        {
            using (var db = new BakeryDbContext())
            {
                var staff = db.Staffs.FirstOrDefault(s => s.Id == empGuid);
                if (staff != null)
                {
                    db.Staffs.Remove(staff);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }
        public bool RemovexStaff(Guid empGuid)
        {
            using (var db = new BakeryDbContext())
            {
                var staff = db.Staffs.FirstOrDefault(s => s.Id == empGuid);
                if (staff != null)
                {
                    db.Staffs.Remove(staff);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }
    }
}