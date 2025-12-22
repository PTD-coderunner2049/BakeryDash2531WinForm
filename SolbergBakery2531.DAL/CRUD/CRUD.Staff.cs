using SolbergBakery2531.DAL.Data;
using SolbergBakery2531.DAL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using SolbergBakery2531.DAL.DTOModels;

namespace SolbergBakery2531.DAL
{
    public partial class CRUD
    {
        public List<StaffDisplayDTO> GetStaffs()
        {
            using (var db = new BakeryDbContext())
            {
                return db.Staffs.Select(s => new StaffDisplayDTO
                {
                    Staff = s,
                    LastHistoryStart = s.Histories
                        .OrderByDescending(h => h.Start)
                        .Select(h => (DateTime?)h.Start)
                        .FirstOrDefault()
                }).ToList();
            }
        }
        public Staff GetStaffSingle(Guid empGuid)
        {
            using (var db = new BakeryDbContext())
            {
                return db.Staffs.FirstOrDefault(s => s.Id == empGuid);
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
        public bool RemoveStaff(Staff staff)
        {
            using (var db = new BakeryDbContext())
            {
                if (staff != null)
                {
                    return false;
                }
                db.Staffs.Attach(staff);
                db.Staffs.Remove(staff);
                return db.SaveChanges() > 0;
            }
        }
    }
}