using SolbergBakery2531.DAL.Data;
using System;
using System.Linq;
namespace SolbergBakery2531.DAL
{
    public partial class CRUD
    {
        public bool RegisUser(Guid GUID, string username, string password)
        {
            using (var db = new BakeryDbContext())
            {
                var staff = db.Staffs.FirstOrDefault(s => s.Id == GUID);

                if (staff == null ||
                    db.Users.Any(u => u.Username == username) ||
                    db.Users.Any(u => u.Id == staff.Id))
                    return false;

                db.Users.Add
                    (
                    new Model.User
                    {//manual link Guid into account ID because I hate cascading keys
                        Id = staff.Id,
                        Username = username,
                        PasswordHash = BCrypt.Net.BCrypt.HashPassword(password),
                        Active = true
                        //CreatedAt = DateTime.UtcNow,
                        //UserGlobalId = Guid.NewGuid()
                    });
                db.SaveChanges();
            return true;
            }
        }
    }
}
