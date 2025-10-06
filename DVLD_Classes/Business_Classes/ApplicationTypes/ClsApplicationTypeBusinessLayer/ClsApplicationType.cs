using ClsApplicationTypeDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsApplicationTypeBusinessLayer
{
    public class ClsApplicationType
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int ApplicationTypeID { set; get; }
        public string ApplicationTypeTitle { set; get; }
        public decimal ApplicationFees { set; get; }

        public ClsApplicationType()
        {
            this.ApplicationTypeID = -1;
            this.ApplicationTypeTitle = "";
            this.ApplicationFees = -1;
            Mode = enMode.AddNew;
        }
        private ClsApplicationType(int ApplicationTypeID, string ApplicationTypeTitle, decimal ApplicationFees)
        {
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeTitle = ApplicationTypeTitle;
            this.ApplicationFees = ApplicationFees;
            Mode = enMode.Update;
        }
        private bool _AddNewApplicationType()
        {
            this.ApplicationTypeID = (int)ClsApplicationTypeData.AddNewApplicationType(this.ApplicationTypeTitle, this.ApplicationFees);
            return (this.ApplicationTypeID != -1);
        }
        private bool _UpdateApplicationType()
        {
            return ClsApplicationTypeData.UpdateApplicationType(this.ApplicationTypeID, this.ApplicationTypeTitle, this.ApplicationFees);
        }
        public static bool DeleteApplicationType(int ApplicationTypeID)
        {
            return ClsApplicationTypeData.DeleteApplicationType(ApplicationTypeID);
        }
        public static bool IsApplicationTypeExistByApplicationTypeID(int ApplicationTypeID)
        {
            return ClsApplicationTypeData.IsApplicationTypeExistByApplicationTypeID(ApplicationTypeID);
        }
        public static bool IsApplicationTypeExistByApplicationTypeTitle(string ApplicationTypeTitle)
        {
            return ClsApplicationTypeData.IsApplicationTypeExistByApplicationTypeTitle(ApplicationTypeTitle);
        }
        public static bool IsApplicationTypeExistByApplicationFees(decimal ApplicationFees)
        {
            return ClsApplicationTypeData.IsApplicationTypeExistByApplicationFees(ApplicationFees);
        }
        public static ClsApplicationType FindByApplicationTypeID(int ApplicationTypeID)
        {
            string ApplicationTypeTitle = "";
            decimal ApplicationFees = -1;

            bool IsFound = ClsApplicationTypeData.GetApplicationTypeByApplicationTypeID(ApplicationTypeID, ref ApplicationTypeTitle, ref ApplicationFees);

            if (IsFound)
                return new ClsApplicationType(ApplicationTypeID, ApplicationTypeTitle, ApplicationFees);
            else
                return null;
        }
        public static ClsApplicationType FindByApplicationTypeTitle(string ApplicationTypeTitle)
        {
            int ApplicationTypeID = -1;
            decimal ApplicationFees = -1;

            bool IsFound = ClsApplicationTypeData.GetApplicationTypeByApplicationTypeTitle(ref ApplicationTypeID, ApplicationTypeTitle, ref ApplicationFees);

            if (IsFound)
                return new ClsApplicationType(ApplicationTypeID, ApplicationTypeTitle, ApplicationFees);
            else
                return null;
        }
        public static ClsApplicationType FindByApplicationFees(decimal ApplicationFees)
        {
            int ApplicationTypeID = -1;
            string ApplicationTypeTitle = "";

            bool IsFound = ClsApplicationTypeData.GetApplicationTypeByApplicationFees(ref ApplicationTypeID, ref ApplicationTypeTitle, ApplicationFees);

            if (IsFound)
                return new ClsApplicationType(ApplicationTypeID, ApplicationTypeTitle, ApplicationFees);
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplicationType())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateApplicationType();
            }
            return false;
        }
        public static DataTable GetApplicationTypes()
        {
            return ClsApplicationTypeData.GetAllApplicationTypes();
        }
    }
}
