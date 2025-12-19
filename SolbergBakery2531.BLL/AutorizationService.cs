using SolbergBakery2531.DAL;
using SolbergBakery2531.DAL.Data;
using System;

namespace SolbergBakery2531.BLL
{
    public class AutorizationService
    {
        public bool UserLooker(string email, string password)
        {
            Console.WriteLine("Hi! Validating the login attempt...");
            return new CRUD().ValidateLogin(email, password);
        }
    }
}
