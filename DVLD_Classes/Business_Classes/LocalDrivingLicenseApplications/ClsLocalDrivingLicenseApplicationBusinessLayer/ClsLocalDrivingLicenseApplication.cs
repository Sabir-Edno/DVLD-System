using ClsLocalDrivingLicenseApplicationDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsLocalDrivingLicenseApplicationBusinessLayer
{
    public class ClsLocalDrivingLicenseApplication
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int LocalDrivingLicenseApplicationID { set; get; }
        public int ApplicationID { set; get; }
        public int LicenseClassID { set; get; }

        public ClsLocalDrivingLicenseApplication()
        {
            this.LocalDrivingLicenseApplicationID = -1;
            this.ApplicationID = -1;
            this.LicenseClassID = -1;
            Mode = enMode.AddNew;
        }
        private ClsLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID)
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.ApplicationID = ApplicationID;
            this.LicenseClassID = LicenseClassID;
            Mode = enMode.Update;
        }
        private bool _AddNewLocalDrivingLicenseApplication()
        {
            this.LocalDrivingLicenseApplicationID = (int)ClsLocalDrivingLicenseApplicationData.AddNewLocalDrivingLicenseApplication(this.ApplicationID, this.LicenseClassID);
            return (this.LocalDrivingLicenseApplicationID != -1);
        }
        private bool _UpdateLocalDrivingLicenseApplication()
        {
            return ClsLocalDrivingLicenseApplicationData.UpdateLocalDrivingLicenseApplication(this.LocalDrivingLicenseApplicationID, this.ApplicationID, this.LicenseClassID);
        }
        public static bool DeleteLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            return ClsLocalDrivingLicenseApplicationData.DeleteLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID);
        }
        public static bool IsLocalDrivingLicenseApplicationExistByLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID)
        {
            return ClsLocalDrivingLicenseApplicationData.IsLocalDrivingLicenseApplicationExistByLocalDrivingLicenseApplicationID(LocalDrivingLicenseApplicationID);
        }
        public static bool IsLocalDrivingLicenseApplicationExistByApplicationID(int ApplicationID)
        {
            return ClsLocalDrivingLicenseApplicationData.IsLocalDrivingLicenseApplicationExistByApplicationID(ApplicationID);
        }
        public static bool IsLocalDrivingLicenseApplicationExistByLicenseClassID(int LicenseClassID)
        {
            return ClsLocalDrivingLicenseApplicationData.IsLocalDrivingLicenseApplicationExistByLicenseClassID(LicenseClassID);
        }
        public static ClsLocalDrivingLicenseApplication FindByLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID)
        {
            int ApplicationID = -1;
            int LicenseClassID = -1;

            bool IsFound = ClsLocalDrivingLicenseApplicationData.GetLocalDrivingLicenseApplicationByLocalDrivingLicenseApplicationID(LocalDrivingLicenseApplicationID, ref ApplicationID, ref LicenseClassID);

            if (IsFound)
                return new ClsLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID, ApplicationID, LicenseClassID);
            else
                return null;
        }
        public static ClsLocalDrivingLicenseApplication FindByApplicationID(int ApplicationID)
        {
            int LocalDrivingLicenseApplicationID = -1;
            int LicenseClassID = -1;

            bool IsFound = ClsLocalDrivingLicenseApplicationData.GetLocalDrivingLicenseApplicationByApplicationID(ref LocalDrivingLicenseApplicationID, ApplicationID, ref LicenseClassID);

            if (IsFound)
                return new ClsLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID, ApplicationID, LicenseClassID);
            else
                return null;
        }
        public static ClsLocalDrivingLicenseApplication FindByLicenseClassID(int LicenseClassID)
        {
            int LocalDrivingLicenseApplicationID = -1;
            int ApplicationID = -1;

            bool IsFound = ClsLocalDrivingLicenseApplicationData.GetLocalDrivingLicenseApplicationByLicenseClassID(ref LocalDrivingLicenseApplicationID, ref ApplicationID, LicenseClassID);

            if (IsFound)
                return new ClsLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID, ApplicationID, LicenseClassID);
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLocalDrivingLicenseApplication())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateLocalDrivingLicenseApplication();
            }
            return false;
        }
        public static DataTable GetLocalDrivingLicenseApplications()
        {
            return ClsLocalDrivingLicenseApplicationData.GetAllLocalDrivingLicenseApplications();
        }
    }
}