using SolbergBakery2531.DAL;
using SolbergBakery2531.DAL.Data;
using SolbergBakery2531.DAL.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace SolbergBakery2531.BLL
{
    public class UserService
    {
        public DataTable Fetch()
        {
            var users = new CRUD().GetUsers();

            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(Guid));
            dt.Columns.Add("Username", typeof(string));
            dt.Columns.Add("CreatedAt", typeof(DateTime));
            dt.Columns.Add("Active", typeof(bool));
            dt.Columns.Add("PasswordHash", typeof(string));
            dt.Columns.Add("IsSystemManager", typeof(bool));

            foreach (var u in users)
            {
                dt.Rows.Add(
                    u.Id,
                    u.Username,
                    u.CreatedAt,
                    u.Active,
                    u.PasswordHash,
                    u.AccociatedStaff?.IsSystemManager ?? false
                );
            }
            return dt;
        }
        public bool SaveUser(Guid staffId, string username, string passwordHash, bool Active)
        {
            return new CRUD().UpsertUser(staffId, username, passwordHash, Active);
        }
        public bool DelUser(Guid staffId)
        {
            CRUD crud = new CRUD();
            User user = crud.GetUserSingle(staffId);
            return crud.RemoveUser(user);
        }
        public string ValidateInputs(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
                return "All staff information fields are required.";
            return null;
        }
    }
}
