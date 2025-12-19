using SolbergBakery2531.DAL;
using System;

namespace SolbergBakery2531.BLL
{
    public class RegistryService
    {
        public bool? UserRegister(string GUID, string username, string password)
        {
            if (!Guid.TryParse(GUID, out Guid validGuid))
            {
                return null;
            }
            return new CRUD().RegisUser(validGuid, username, password);
            //if it valid then validGuid will held them after "tryParse", Mordern C# thinggy
        }
    }
}
