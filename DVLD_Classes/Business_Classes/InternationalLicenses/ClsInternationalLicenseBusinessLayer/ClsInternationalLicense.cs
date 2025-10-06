using ClsInternationalLicenseDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsInternationalLicenseBusinessLayer
{
    public class ClsInternationalLicense
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int InternationalLicenseID { set; get; }
        public int ApplicationID { set; get; }
        public int DriverID { set; get; }
        public int IssuedUsingLocalLicenseID { set; get; }
        public DateTime IssueDate { set; get; }
        public DateTime ExpirationDate { set; get; }
        public bool IsActive { set; get; }
        public int CreatedByUserID { set; get; }

        public ClsInternationalLicense()
        {
            this.InternationalLicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.IssuedUsingLocalLicenseID = -1;
            this.IssueDate = DateTime.MinValue;
            this.ExpirationDate = DateTime.MinValue;
            this.IsActive = false;
            this.CreatedByUserID = -1;
            Mode = enMode.AddNew;
        }
        private ClsInternationalLicense(int InternationalLicenseID, int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            this.InternationalLicenseID = InternationalLicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;
            Mode = enMode.Update;
        }
        private bool _AddNewInternationalLicense()
        {
            this.InternationalLicenseID = (int)ClsInternationalLicenseData.AddNewInternationalLicense(this.ApplicationID, this.DriverID, this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);
            return (this.InternationalLicenseID != -1);
        }
        private bool _UpdateInternationalLicense()
        {
            return ClsInternationalLicenseData.UpdateInternationalLicense(this.InternationalLicenseID, this.ApplicationID, this.DriverID, this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);
        }
        public static bool DeleteInternationalLicense(int InternationalLicenseID)
        {
            return ClsInternationalLicenseData.DeleteInternationalLicense(InternationalLicenseID);
        }
        public static bool IsInternationalLicenseExistByInternationalLicenseID(int InternationalLicenseID)
        {
            return ClsInternationalLicenseData.IsInternationalLicenseExistByInternationalLicenseID(InternationalLicenseID);
        }
        public static bool IsInternationalLicenseExistByApplicationID(int ApplicationID)
        {
            return ClsInternationalLicenseData.IsInternationalLicenseExistByApplicationID(ApplicationID);
        }
        public static bool IsInternationalLicenseExistByDriverID(int DriverID)
        {
            return ClsInternationalLicenseData.IsInternationalLicenseExistByDriverID(DriverID);
        }
        public static bool IsInternationalLicenseExistByIssuedUsingLocalLicenseID(int IssuedUsingLocalLicenseID)
        {
            return ClsInternationalLicenseData.IsInternationalLicenseExistByIssuedUsingLocalLicenseID(IssuedUsingLocalLicenseID);
        }
        public static bool IsInternationalLicenseExistByIssueDate(DateTime IssueDate)
        {
            return ClsInternationalLicenseData.IsInternationalLicenseExistByIssueDate(IssueDate);
        }
        public static bool IsInternationalLicenseExistByExpirationDate(DateTime ExpirationDate)
        {
            return ClsInternationalLicenseData.IsInternationalLicenseExistByExpirationDate(ExpirationDate);
        }
        public static bool IsInternationalLicenseExistByIsActive(bool IsActive)
        {
            return ClsInternationalLicenseData.IsInternationalLicenseExistByIsActive(IsActive);
        }
        public static bool IsInternationalLicenseExistByCreatedByUserID(int CreatedByUserID)
        {
            return ClsInternationalLicenseData.IsInternationalLicenseExistByCreatedByUserID(CreatedByUserID);
        }
        public static ClsInternationalLicense FindByInternationalLicenseID(int InternationalLicenseID)
        {
            int ApplicationID = -1;
            int DriverID = -1;
            int IssuedUsingLocalLicenseID = -1;
            DateTime IssueDate = DateTime.MinValue;
            DateTime ExpirationDate = DateTime.MinValue;
            bool IsActive = false;
            int CreatedByUserID = -1;

            bool IsFound = ClsInternationalLicenseData.GetInternationalLicenseByInternationalLicenseID(InternationalLicenseID, ref ApplicationID, ref DriverID, ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID);

            if (IsFound)
                return new ClsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            else
                return null;
        }
        public static ClsInternationalLicense FindByApplicationID(int ApplicationID)
        {
            int InternationalLicenseID = -1;
            int DriverID = -1;
            int IssuedUsingLocalLicenseID = -1;
            DateTime IssueDate = DateTime.MinValue;
            DateTime ExpirationDate = DateTime.MinValue;
            bool IsActive = false;
            int CreatedByUserID = -1;

            bool IsFound = ClsInternationalLicenseData.GetInternationalLicenseByApplicationID(ref InternationalLicenseID, ApplicationID, ref DriverID, ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID);

            if (IsFound)
                return new ClsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            else
                return null;
        }
        public static ClsInternationalLicense FindByDriverID(int DriverID)
        {
            int InternationalLicenseID = -1;
            int ApplicationID = -1;
            int IssuedUsingLocalLicenseID = -1;
            DateTime IssueDate = DateTime.MinValue;
            DateTime ExpirationDate = DateTime.MinValue;
            bool IsActive = false;
            int CreatedByUserID = -1;

            bool IsFound = ClsInternationalLicenseData.GetInternationalLicenseByDriverID(ref InternationalLicenseID, ref ApplicationID, DriverID, ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID);

            if (IsFound)
                return new ClsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            else
                return null;
        }
        public static ClsInternationalLicense FindByIssuedUsingLocalLicenseID(int IssuedUsingLocalLicenseID)
        {
            int InternationalLicenseID = -1;
            int ApplicationID = -1;
            int DriverID = -1;
            DateTime IssueDate = DateTime.MinValue;
            DateTime ExpirationDate = DateTime.MinValue;
            bool IsActive = false;
            int CreatedByUserID = -1;

            bool IsFound = ClsInternationalLicenseData.GetInternationalLicenseByIssuedUsingLocalLicenseID(ref InternationalLicenseID, ref ApplicationID, ref DriverID, IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID);

            if (IsFound)
                return new ClsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            else
                return null;
        }
        public static ClsInternationalLicense FindByIssueDate(DateTime IssueDate)
        {
            int InternationalLicenseID = -1;
            int ApplicationID = -1;
            int DriverID = -1;
            int IssuedUsingLocalLicenseID = -1;
            DateTime ExpirationDate = DateTime.MinValue;
            bool IsActive = false;
            int CreatedByUserID = -1;

            bool IsFound = ClsInternationalLicenseData.GetInternationalLicenseByIssueDate(ref InternationalLicenseID, ref ApplicationID, ref DriverID, ref IssuedUsingLocalLicenseID, IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID);

            if (IsFound)
                return new ClsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            else
                return null;
        }
        public static ClsInternationalLicense FindByExpirationDate(DateTime ExpirationDate)
        {
            int InternationalLicenseID = -1;
            int ApplicationID = -1;
            int DriverID = -1;
            int IssuedUsingLocalLicenseID = -1;
            DateTime IssueDate = DateTime.MinValue;
            bool IsActive = false;
            int CreatedByUserID = -1;

            bool IsFound = ClsInternationalLicenseData.GetInternationalLicenseByExpirationDate(ref InternationalLicenseID, ref ApplicationID, ref DriverID, ref IssuedUsingLocalLicenseID, ref IssueDate, ExpirationDate, ref IsActive, ref CreatedByUserID);

            if (IsFound)
                return new ClsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            else
                return null;
        }
        public static ClsInternationalLicense FindByIsActive(bool IsActive)
        {
            int InternationalLicenseID = -1;
            int ApplicationID = -1;
            int DriverID = -1;
            int IssuedUsingLocalLicenseID = -1;
            DateTime IssueDate = DateTime.MinValue;
            DateTime ExpirationDate = DateTime.MinValue;
            int CreatedByUserID = -1;

            bool IsFound = ClsInternationalLicenseData.GetInternationalLicenseByIsActive(ref InternationalLicenseID, ref ApplicationID, ref DriverID, ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate, IsActive, ref CreatedByUserID);

            if (IsFound)
                return new ClsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            else
                return null;
        }
        public static ClsInternationalLicense FindByCreatedByUserID(int CreatedByUserID)
        {
            int InternationalLicenseID = -1;
            int ApplicationID = -1;
            int DriverID = -1;
            int IssuedUsingLocalLicenseID = -1;
            DateTime IssueDate = DateTime.MinValue;
            DateTime ExpirationDate = DateTime.MinValue;
            bool IsActive = false;

            bool IsFound = ClsInternationalLicenseData.GetInternationalLicenseByCreatedByUserID(ref InternationalLicenseID, ref ApplicationID, ref DriverID, ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate, ref IsActive, CreatedByUserID);

            if (IsFound)
                return new ClsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewInternationalLicense())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateInternationalLicense();
            }
            return false;
        }
        public static DataTable GetInternationalLicenses()
        {
            return ClsInternationalLicenseData.GetAllInternationalLicenses();
        }
    }
}
