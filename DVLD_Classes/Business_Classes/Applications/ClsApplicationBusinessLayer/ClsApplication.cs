using ClsApplicationDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsApplicationBusinessLayer
{
    public class ClsApplication
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int ApplicationID { set; get; }
        public int ApplicantPersonID { set; get; }
        public DateTime ApplicationDate { set; get; }
        public int ApplicationTypeID { set; get; }
        public byte ApplicationStatus { set; get; }
        public DateTime LastStatusDate { set; get; }
        public decimal PaidFees { set; get; }
        public int CreatedByUserID { set; get; }

        public ClsApplication()
        {
            this.ApplicationID = -1;
            this.ApplicantPersonID = -1;
            this.ApplicationDate = DateTime.MinValue;
            this.ApplicationTypeID = -1;
            this.ApplicationStatus = 0;
            this.LastStatusDate = DateTime.MinValue;
            this.PaidFees = -1;
            this.CreatedByUserID = -1;
            Mode = enMode.AddNew;
        }
        private ClsApplication(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            Mode = enMode.Update;
        }
        private bool _AddNewApplication()
        {
            this.ApplicationID = (int)ClsApplicationData.AddNewApplication(this.ApplicantPersonID, this.ApplicationDate, this.ApplicationTypeID, this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);
            return (this.ApplicationID != -1);
        }
        private bool _UpdateApplication()
        {
            return ClsApplicationData.UpdateApplication(this.ApplicationID, this.ApplicantPersonID, this.ApplicationDate, this.ApplicationTypeID, this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);
        }
        public static bool DeleteApplication(int ApplicationID)
        {
            return ClsApplicationData.DeleteApplication(ApplicationID);
        }
        public static bool IsApplicationExistByApplicationID(int ApplicationID)
        {
            return ClsApplicationData.IsApplicationExistByApplicationID(ApplicationID);
        }
        public static bool IsApplicationExistByApplicantPersonID(int ApplicantPersonID)
        {
            return ClsApplicationData.IsApplicationExistByApplicantPersonID(ApplicantPersonID);
        }
        public static bool IsApplicationExistByApplicationDate(DateTime ApplicationDate)
        {
            return ClsApplicationData.IsApplicationExistByApplicationDate(ApplicationDate);
        }
        public static bool IsApplicationExistByApplicationTypeID(int ApplicationTypeID)
        {
            return ClsApplicationData.IsApplicationExistByApplicationTypeID(ApplicationTypeID);
        }
        public static bool IsApplicationExistByApplicationStatus(byte ApplicationStatus)
        {
            return ClsApplicationData.IsApplicationExistByApplicationStatus(ApplicationStatus);
        }
        public static bool IsApplicationExistByLastStatusDate(DateTime LastStatusDate)
        {
            return ClsApplicationData.IsApplicationExistByLastStatusDate(LastStatusDate);
        }
        public static bool IsApplicationExistByPaidFees(decimal PaidFees)
        {
            return ClsApplicationData.IsApplicationExistByPaidFees(PaidFees);
        }
        public static bool IsApplicationExistByCreatedByUserID(int CreatedByUserID)
        {
            return ClsApplicationData.IsApplicationExistByCreatedByUserID(CreatedByUserID);
        }
        public static ClsApplication FindByApplicationID(int ApplicationID)
        {
            int ApplicantPersonID = -1;
            DateTime ApplicationDate = DateTime.MinValue;
            int ApplicationTypeID = -1;
            byte ApplicationStatus = 0;
            DateTime LastStatusDate = DateTime.MinValue;
            decimal PaidFees = -1;
            int CreatedByUserID = -1;

            bool IsFound = ClsApplicationData.GetApplicationByApplicationID(ApplicationID, ref ApplicantPersonID, ref ApplicationDate, ref ApplicationTypeID, ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID);

            if (IsFound)
                return new ClsApplication(ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
            else
                return null;
        }
        public static ClsApplication FindByApplicantPersonID(int ApplicantPersonID)
        {
            int ApplicationID = -1;
            DateTime ApplicationDate = DateTime.MinValue;
            int ApplicationTypeID = -1;
            byte ApplicationStatus = 0;
            DateTime LastStatusDate = DateTime.MinValue;
            decimal PaidFees = -1;
            int CreatedByUserID = -1;

            bool IsFound = ClsApplicationData.GetApplicationByApplicantPersonID(ref ApplicationID, ApplicantPersonID, ref ApplicationDate, ref ApplicationTypeID, ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID);

            if (IsFound)
                return new ClsApplication(ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
            else
                return null;
        }
        public static ClsApplication FindByApplicationDate(DateTime ApplicationDate)
        {
            int ApplicationID = -1;
            int ApplicantPersonID = -1;
            int ApplicationTypeID = -1;
            byte ApplicationStatus = 0;
            DateTime LastStatusDate = DateTime.MinValue;
            decimal PaidFees = -1;
            int CreatedByUserID = -1;

            bool IsFound = ClsApplicationData.GetApplicationByApplicationDate(ref ApplicationID, ref ApplicantPersonID, ApplicationDate, ref ApplicationTypeID, ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID);

            if (IsFound)
                return new ClsApplication(ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
            else
                return null;
        }
        public static ClsApplication FindByApplicationTypeID(int ApplicationTypeID)
        {
            int ApplicationID = -1;
            int ApplicantPersonID = -1;
            DateTime ApplicationDate = DateTime.MinValue;
            byte ApplicationStatus = 0;
            DateTime LastStatusDate = DateTime.MinValue;
            decimal PaidFees = -1;
            int CreatedByUserID = -1;

            bool IsFound = ClsApplicationData.GetApplicationByApplicationTypeID(ref ApplicationID, ref ApplicantPersonID, ref ApplicationDate, ApplicationTypeID, ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID);

            if (IsFound)
                return new ClsApplication(ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
            else
                return null;
        }
        public static ClsApplication FindByApplicationStatus(byte ApplicationStatus)
        {
            int ApplicationID = -1;
            int ApplicantPersonID = -1;
            DateTime ApplicationDate = DateTime.MinValue;
            int ApplicationTypeID = -1;
            DateTime LastStatusDate = DateTime.MinValue;
            decimal PaidFees = -1;
            int CreatedByUserID = -1;

            bool IsFound = ClsApplicationData.GetApplicationByApplicationStatus(ref ApplicationID, ref ApplicantPersonID, ref ApplicationDate, ref ApplicationTypeID, ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID);

            if (IsFound)
                return new ClsApplication(ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
            else
                return null;
        }
        public static ClsApplication FindByLastStatusDate(DateTime LastStatusDate)
        {
            int ApplicationID = -1;
            int ApplicantPersonID = -1;
            DateTime ApplicationDate = DateTime.MinValue;
            int ApplicationTypeID = -1;
            byte ApplicationStatus = 0;
            decimal PaidFees = -1;
            int CreatedByUserID = -1;

            bool IsFound = ClsApplicationData.GetApplicationByLastStatusDate(ref ApplicationID, ref ApplicantPersonID, ref ApplicationDate, ref ApplicationTypeID, ref ApplicationStatus, LastStatusDate, ref PaidFees, ref CreatedByUserID);

            if (IsFound)
                return new ClsApplication(ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
            else
                return null;
        }
        public static ClsApplication FindByPaidFees(decimal PaidFees)
        {
            int ApplicationID = -1;
            int ApplicantPersonID = -1;
            DateTime ApplicationDate = DateTime.MinValue;
            int ApplicationTypeID = -1;
            byte ApplicationStatus = 0;
            DateTime LastStatusDate = DateTime.MinValue;
            int CreatedByUserID = -1;

            bool IsFound = ClsApplicationData.GetApplicationByPaidFees(ref ApplicationID, ref ApplicantPersonID, ref ApplicationDate, ref ApplicationTypeID, ref ApplicationStatus, ref LastStatusDate, PaidFees, ref CreatedByUserID);

            if (IsFound)
                return new ClsApplication(ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
            else
                return null;
        }
        public static ClsApplication FindByCreatedByUserID(int CreatedByUserID)
        {
            int ApplicationID = -1;
            int ApplicantPersonID = -1;
            DateTime ApplicationDate = DateTime.MinValue;
            int ApplicationTypeID = -1;
            byte ApplicationStatus = 0;
            DateTime LastStatusDate = DateTime.MinValue;
            decimal PaidFees = -1;

            bool IsFound = ClsApplicationData.GetApplicationByCreatedByUserID(ref ApplicationID, ref ApplicantPersonID, ref ApplicationDate, ref ApplicationTypeID, ref ApplicationStatus, ref LastStatusDate, ref PaidFees, CreatedByUserID);

            if (IsFound)
                return new ClsApplication(ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplication())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateApplication();
            }
            return false;
        }
        public static DataTable GetApplications()
        {
            return ClsApplicationData.GetAllApplications();
        }
    }
}
