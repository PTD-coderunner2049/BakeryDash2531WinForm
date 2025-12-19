using SolbergBakery2531.DAL.Data;
using System.Linq;
using System.Data.Entity;
using SolbergBakery2531.BLL;
namespace SolbergBakery2531.DAL
{
    public partial class CRUD
    {
        public bool ValidateLogin(string inputemail, string inputPassword)
        {
            using (var db = new BakeryDbContext())
            {
                var user = db.Users
                    .Include(u => u.AccociatedStaff)
                    .FirstOrDefault(u => u.Username.ToLower() == inputemail.ToLower() ||
                    u.AccociatedStaff.Email.ToLower() == inputemail.ToLower());

                if (user == null)
                {
                    return false;
                }
                else if (BCrypt.Net.BCrypt.Verify(inputPassword, user.PasswordHash))
                {
                    CurrSess.Instance.User = user;
                    return true;
                }
                return false;
            }
        }




    }
}
