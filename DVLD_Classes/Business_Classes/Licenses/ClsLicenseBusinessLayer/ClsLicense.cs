using ClsLicenseDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsLicenseBusinessLayer
{
    public class ClsLicense
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int LicenseID { set; get; }
        public int ApplicationID { set; get; }
        public int DriverID { set; get; }
        public int LicenseClass { set; get; }
        public DateTime IssueDate { set; get; }
        public DateTime ExpirationDate { set; get; }
        public string Notes { set; get; }
        public decimal PaidFees { set; get; }
        public bool IsActive { set; get; }
        public byte IssueReason { set; get; }
        public int CreatedByUserID { set; get; }

        public ClsLicense()
        {
            this.LicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.LicenseClass = -1;
            this.IssueDate = DateTime.MinValue;
            this.ExpirationDate = DateTime.MinValue;
            this.Notes = "";
            this.PaidFees = -1;
            this.IsActive = false;
            this.IssueReason = 0;
            this.CreatedByUserID = -1;
            Mode = enMode.AddNew;
        }
        private ClsLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate, DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)
        {
            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.LicenseClass = LicenseClass;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUserID = CreatedByUserID;
            Mode = enMode.Update;
        }
        private bool _AddNewLicense()
        {
            this.LicenseID = (int)ClsLicenseData.AddNewLicense(this.ApplicationID, this.DriverID, this.LicenseClass, this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, this.IssueReason, this.CreatedByUserID);
            return (this.LicenseID != -1);
        }
        private bool _UpdateLicense()
        {
            return ClsLicenseData.UpdateLicense(this.LicenseID, this.ApplicationID, this.DriverID, this.LicenseClass, this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, this.IssueReason, this.CreatedByUserID);
        }
        public static bool DeleteLicense(int LicenseID)
        {
            return ClsLicenseData.DeleteLicense(LicenseID);
        }
        public static bool IsLicenseExistByLicenseID(int LicenseID)
        {
            return ClsLicenseData.IsLicenseExistByLicenseID(LicenseID);
        }
        public static bool IsLicenseExistByApplicationID(int ApplicationID)
        {
            return ClsLicenseData.IsLicenseExistByApplicationID(ApplicationID);
        }
        public static bool IsLicenseExistByDriverID(int DriverID)
        {
            return ClsLicenseData.IsLicenseExistByDriverID(DriverID);
        }
        public static bool IsLicenseExistByLicenseClass(int LicenseClass)
        {
            return ClsLicenseData.IsLicenseExistByLicenseClass(LicenseClass);
        }
        public static bool IsLicenseExistByIssueDate(DateTime IssueDate)
        {
            return ClsLicenseData.IsLicenseExistByIssueDate(IssueDate);
        }
        public static bool IsLicenseExistByExpirationDate(DateTime ExpirationDate)
        {
            return ClsLicenseData.IsLicenseExistByExpirationDate(ExpirationDate);
        }
        public static bool IsLicenseExistByNotes(string Notes)
        {
            return ClsLicenseData.IsLicenseExistByNotes(Notes);
        }
        public static bool IsLicenseExistByPaidFees(decimal PaidFees)
        {
            return ClsLicenseData.IsLicenseExistByPaidFees(PaidFees);
        }
        public static bool IsLicenseExistByIsActive(bool IsActive)
        {
            return ClsLicenseData.IsLicenseExistByIsActive(IsActive);
        }
        public static bool IsLicenseExistByIssueReason(byte IssueReason)
        {
            return ClsLicenseData.IsLicenseExistByIssueReason(IssueReason);
        }
        public static bool IsLicenseExistByCreatedByUserID(int CreatedByUserID)
        {
            return ClsLicenseData.IsLicenseExistByCreatedByUserID(CreatedByUserID);
        }
        public static ClsLicense FindByLicenseID(int LicenseID)
        {
            int ApplicationID = -1;
            int DriverID = -1;
            int LicenseClass = -1;
            DateTime IssueDate = DateTime.MinValue;
            DateTime ExpirationDate = DateTime.MinValue;
            string Notes = "";
            decimal PaidFees = -1;
            bool IsActive = false;
            byte IssueReason = 0;
            int CreatedByUserID = -1;

            bool IsFound = ClsLicenseData.GetLicenseByLicenseID(LicenseID, ref ApplicationID, ref DriverID, ref LicenseClass, ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID);

            if (IsFound)
                return new ClsLicense(LicenseID, ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
            else
                return null;
        }
        public static ClsLicense FindByApplicationID(int ApplicationID)
        {
            int LicenseID = -1;
            int DriverID = -1;
            int LicenseClass = -1;
            DateTime IssueDate = DateTime.MinValue;
            DateTime ExpirationDate = DateTime.MinValue;
            string Notes = "";
            decimal PaidFees = -1;
            bool IsActive = false;
            byte IssueReason = 0;
            int CreatedByUserID = -1;

            bool IsFound = ClsLicenseData.GetLicenseByApplicationID(ref LicenseID, ApplicationID, ref DriverID, ref LicenseClass, ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID);

            if (IsFound)
                return new ClsLicense(LicenseID, ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
            else
                return null;
        }
        public static ClsLicense FindByDriverID(int DriverID)
        {
            int LicenseID = -1;
            int ApplicationID = -1;
            int LicenseClass = -1;
            DateTime IssueDate = DateTime.MinValue;
            DateTime ExpirationDate = DateTime.MinValue;
            string Notes = "";
            decimal PaidFees = -1;
            bool IsActive = false;
            byte IssueReason = 0;
            int CreatedByUserID = -1;

            bool IsFound = ClsLicenseData.GetLicenseByDriverID(ref LicenseID, ref ApplicationID, DriverID, ref LicenseClass, ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID);

            if (IsFound)
                return new ClsLicense(LicenseID, ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
            else
                return null;
        }
        public static ClsLicense FindByLicenseClass(int LicenseClass)
        {
            int LicenseID = -1;
            int ApplicationID = -1;
            int DriverID = -1;
            DateTime IssueDate = DateTime.MinValue;
            DateTime ExpirationDate = DateTime.MinValue;
            string Notes = "";
            decimal PaidFees = -1;
            bool IsActive = false;
            byte IssueReason = 0;
            int CreatedByUserID = -1;

            bool IsFound = ClsLicenseData.GetLicenseByLicenseClass(ref LicenseID, ref ApplicationID, ref DriverID, LicenseClass, ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID);

            if (IsFound)
                return new ClsLicense(LicenseID, ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
            else
                return null;
        }
        public static ClsLicense FindByIssueDate(DateTime IssueDate)
        {
            int LicenseID = -1;
            int ApplicationID = -1;
            int DriverID = -1;
            int LicenseClass = -1;
            DateTime ExpirationDate = DateTime.MinValue;
            string Notes = "";
            decimal PaidFees = -1;
            bool IsActive = false;
            byte IssueReason = 0;
            int CreatedByUserID = -1;

            bool IsFound = ClsLicenseData.GetLicenseByIssueDate(ref LicenseID, ref ApplicationID, ref DriverID, ref LicenseClass, IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID);

            if (IsFound)
                return new ClsLicense(LicenseID, ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
            else
                return null;
        }
        public static ClsLicense FindByExpirationDate(DateTime ExpirationDate)
        {
            int LicenseID = -1;
            int ApplicationID = -1;
            int DriverID = -1;
            int LicenseClass = -1;
            DateTime IssueDate = DateTime.MinValue;
            string Notes = "";
            decimal PaidFees = -1;
            bool IsActive = false;
            byte IssueReason = 0;
            int CreatedByUserID = -1;

            bool IsFound = ClsLicenseData.GetLicenseByExpirationDate(ref LicenseID, ref ApplicationID, ref DriverID, ref LicenseClass, ref IssueDate, ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID);

            if (IsFound)
                return new ClsLicense(LicenseID, ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
            else
                return null;
        }
        public static ClsLicense FindByNotes(string Notes)
        {
            int LicenseID = -1;
            int ApplicationID = -1;
            int DriverID = -1;
            int LicenseClass = -1;
            DateTime IssueDate = DateTime.MinValue;
            DateTime ExpirationDate = DateTime.MinValue;
            decimal PaidFees = -1;
            bool IsActive = false;
            byte IssueReason = 0;
            int CreatedByUserID = -1;

            bool IsFound = ClsLicenseData.GetLicenseByNotes(ref LicenseID, ref ApplicationID, ref DriverID, ref LicenseClass, ref IssueDate, ref ExpirationDate, Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID);

            if (IsFound)
                return new ClsLicense(LicenseID, ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
            else
                return null;
        }
        public static ClsLicense FindByPaidFees(decimal PaidFees)
        {
            int LicenseID = -1;
            int ApplicationID = -1;
            int DriverID = -1;
            int LicenseClass = -1;
            DateTime IssueDate = DateTime.MinValue;
            DateTime ExpirationDate = DateTime.MinValue;
            string Notes = "";
            bool IsActive = false;
            byte IssueReason = 0;
            int CreatedByUserID = -1;

            bool IsFound = ClsLicenseData.GetLicenseByPaidFees(ref LicenseID, ref ApplicationID, ref DriverID, ref LicenseClass, ref IssueDate, ref ExpirationDate, ref Notes, PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID);

            if (IsFound)
                return new ClsLicense(LicenseID, ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
            else
                return null;
        }
        public static ClsLicense FindByIsActive(bool IsActive)
        {
            int LicenseID = -1;
            int ApplicationID = -1;
            int DriverID = -1;
            int LicenseClass = -1;
            DateTime IssueDate = DateTime.MinValue;
            DateTime ExpirationDate = DateTime.MinValue;
            string Notes = "";
            decimal PaidFees = -1;
            byte IssueReason = 0;
            int CreatedByUserID = -1;

            bool IsFound = ClsLicenseData.GetLicenseByIsActive(ref LicenseID, ref ApplicationID, ref DriverID, ref LicenseClass, ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, IsActive, ref IssueReason, ref CreatedByUserID);

            if (IsFound)
                return new ClsLicense(LicenseID, ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
            else
                return null;
        }
        public static ClsLicense FindByIssueReason(byte IssueReason)
        {
            int LicenseID = -1;
            int ApplicationID = -1;
            int DriverID = -1;
            int LicenseClass = -1;
            DateTime IssueDate = DateTime.MinValue;
            DateTime ExpirationDate = DateTime.MinValue;
            string Notes = "";
            decimal PaidFees = -1;
            bool IsActive = false;
            int CreatedByUserID = -1;

            bool IsFound = ClsLicenseData.GetLicenseByIssueReason(ref LicenseID, ref ApplicationID, ref DriverID, ref LicenseClass, ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, IssueReason, ref CreatedByUserID);

            if (IsFound)
                return new ClsLicense(LicenseID, ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
            else
                return null;
        }
        public static ClsLicense FindByCreatedByUserID(int CreatedByUserID)
        {
            int LicenseID = -1;
            int ApplicationID = -1;
            int DriverID = -1;
            int LicenseClass = -1;
            DateTime IssueDate = DateTime.MinValue;
            DateTime ExpirationDate = DateTime.MinValue;
            string Notes = "";
            decimal PaidFees = -1;
            bool IsActive = false;
            byte IssueReason = 0;

            bool IsFound = ClsLicenseData.GetLicenseByCreatedByUserID(ref LicenseID, ref ApplicationID, ref DriverID, ref LicenseClass, ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, CreatedByUserID);

            if (IsFound)
                return new ClsLicense(LicenseID, ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLicense())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateLicense();
            }
            return false;
        }
        public static DataTable GetLicenses()
        {
            return ClsLicenseData.GetAllLicenses();
        }
    }
}
