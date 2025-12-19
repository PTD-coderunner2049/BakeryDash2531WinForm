using SolbergBakery2531.DAL.Model;

namespace SolbergBakery2531.BLL
{
    public sealed class CurrSess
    {
        private static CurrSess _instance = null;
        private static readonly object _lock = new object();

        public User User { get; set; }

        private CurrSess() { }
        public static CurrSess Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new CurrSess();
                    }
                    return _instance;
                }
            }
        }
        public void Logout()
        {
            _instance = null;
        }
    }
}
