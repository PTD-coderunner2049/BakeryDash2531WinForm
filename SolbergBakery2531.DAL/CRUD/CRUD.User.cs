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
        //public DataTable GetUxxsers()
        //{
        //    using (var db = new BakeryDbContext())
        //    {
        //        DataTable dt = new DataTable();
        //        //dt.Columns.Add("EmployeeGlobalId", typeof(Guid)); // Staff's GUID
        //        dt.Columns.Add("Id", typeof(Guid));     // User's GUID
        //        dt.Columns.Add("Username", typeof(string));
        //        dt.Columns.Add("CreatedAt", typeof(DateTime));
        //        dt.Columns.Add("Active", typeof(bool));
        //        dt.Columns.Add("PasswordHash", typeof(string));
        //        dt.Columns.Add("IsSystemManager", typeof(bool));

        //        var userList = db.Users.Select(u => new
        //        {
        //            u.Id,
        //            u.Username,
        //            u.CreatedAt,
        //            u.Active,
        //            u.PasswordHash,
        //            // navigation
        //            //EmpGuid = u.AccociatedStaff.Id,
        //            IsManager = u.AccociatedStaff.IsSystemManager
        //        }).ToList();

        //        foreach (var u in userList)
        //        {
        //            dt.Rows.Add(
        //                //u.EmpGuid,
        //                u.Id,
        //                u.Username,
        //                u.CreatedAt,
        //                u.Active,
        //                u.PasswordHash,
        //                u.IsManager
        //            );
        //        }
        //        return dt;
        //    }
        //}
        public List<User> GetUsers()
        {
            using (var db = new BakeryDbContext())
            {
                return db.Users.Include("AccociatedStaff").ToList();
            }
        }
        public User GetUserSingle(Guid staffId)
        {
            using (var db = new BakeryDbContext())
            {
                return db.Users.FirstOrDefault(u => u.Id == staffId);
            }
        }


        public bool UpsertUser(Guid employeeGuid, string username, string password, bool Active)
        {
            using (var db = new BakeryDbContext())
            {
                var staff = db.Staffs.FirstOrDefault(s => s.Id == employeeGuid);
                if (staff == null) return false;
                var existingUser = db.Users.FirstOrDefault(u => u.Id == staff.Id);

                if (existingUser != null)
                {
                    if (db.Users.Any(u => u.Username == username && u.Id != staff.Id))
                        return false;

                    existingUser.Username = username;
                    existingUser.Active = Active;

                    if (!string.IsNullOrWhiteSpace(password))
                    {
                        existingUser.PasswordHash = BCrypt.Net.BCrypt.HashPassword(password);
                    }
                }
                else
                {
                    if (db.Users.Any(u => u.Username == username))
                        return false;

                    var newUser = new User
                    {
                        Id = staff.Id,
                        Username = username,
                        PasswordHash = BCrypt.Net.BCrypt.HashPassword(password),
                        Active = false,
                        CreatedAt = DateTime.UtcNow
                    };
                    db.Users.Add(newUser);
                }

                return db.SaveChanges() > 0;
            }
        }
        public bool RemoveUser(User user)
        {
            using (var db = new BakeryDbContext())
            {
                if (user == null)
                    return false;
                db.Users.Attach(user);
                db.Users.Remove(user);
                return db.SaveChanges() > 0;
            }
        }
        //public bool RemovexxxxUser(Guid employeeGuid)
        //{
        //    using (var db = new BakeryDbContext())
        //    {
        //        var staff = db.Staffs.FirstOrDefault(s => s.Id == employeeGuid);
        //        if (staff == null) return false;

        //        var user = db.Users.FirstOrDefault(u => u.Id == staff.Id);
        //        if (user != null)
        //        {
        //            db.Users.Remove(user);
        //            db.SaveChanges();
        //            return true;
        //        }
        //        return false;
        //    }
        //}
    }
}
