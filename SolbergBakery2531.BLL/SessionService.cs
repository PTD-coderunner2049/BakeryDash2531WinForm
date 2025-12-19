using SolbergBakery2531.DAL;
using SolbergBakery2531.DAL.Model;
using System;

namespace SolbergBakery2531.BLL
{
    public class SessionService
    {
        public void PerformLogout()
        {
            CurrSess.Instance.Logout();
        }
        // --- USER ACCOUNT ATTRIBUTES ---
        public string GetSessionUsername()
        {
            return CurrSess.Instance.User?.Username ?? "Unknown";
        }
        public Guid Id()
        {
            return CurrSess.Instance.User?.Id ?? Guid.Empty;
        }
        public DateTime GetUserCreatedAt()
        {
            return CurrSess.Instance.User?.CreatedAt ?? DateTime.MinValue;
        }
        public bool IsUserActive()
        {
            return CurrSess.Instance.User?.Active ?? false;
        }

        // --- STAFF / PERSONAL ATTRIBUTES ---
        public string GetStaffFirstName()
        {
            return CurrSess.Instance.User?.AccociatedStaff?.FirstName ?? "N/A";
        }
        public string GetStaffLastName()
        {
            return CurrSess.Instance.User?.AccociatedStaff?.LastName ?? "N/A";
        }
        public string GetStaffFullName()
        {
            if (CurrSess.Instance.User?.AccociatedStaff != null)
            {
                var staff = CurrSess.Instance.User.AccociatedStaff;
                return $"{staff.FirstName} {staff.LastName}";
            }
            return "UnAuthorizedGuest";
        }

        public string GetStaffEmail()
        {
            return CurrSess.Instance.User?.AccociatedStaff?.Email ?? "N/A";
        }
        public string GetStaffPhone()
        {
            return CurrSess.Instance.User?.AccociatedStaff?.PhoneContact ?? "N/A";
        }
        public string GetStaffGender()
        {
            return CurrSess.Instance.User?.AccociatedStaff?.Gender ?? "Unknown";
        }
        public DateTime GetStaffBirthDate()
        {
            return CurrSess.Instance.User?.AccociatedStaff?.Birth ?? DateTime.MinValue;
        }
        public string GetStaffSSN()
        {
            return CurrSess.Instance.User?.AccociatedStaff?.SSN ?? "000-00-0000";
        }
        // --- EMPLOYMENT & PERMISSIONS ---
        public bool IsAdmin()
        {
            // Maps to the IsSystemManager attribute in Staff model
            return CurrSess.Instance.User?.AccociatedStaff?.IsSystemManager ?? false;
        }
        public decimal GetPayRate()
        {
            return CurrSess.Instance.User?.AccociatedStaff?.PayratePerHrs ?? 0m;
        }
        public Guid GetStaffEmployeeGlobalId()
        {
            return CurrSess.Instance.User?.AccociatedStaff?.Id ?? Guid.Empty;
        }
    }
}