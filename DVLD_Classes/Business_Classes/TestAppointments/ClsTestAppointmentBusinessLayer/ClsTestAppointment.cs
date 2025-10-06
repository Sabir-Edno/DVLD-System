using ClsTestAppointmentDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsTestAppointmentBusinessLayer
{
    public class ClsTestAppointment
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int TestAppointmentID { set; get; }
        public int TestTypeID { set; get; }
        public int LocalDrivingLicenseApplicationID { set; get; }
        public DateTime AppointmentDate { set; get; }
        public decimal PaidFees { set; get; }
        public int CreatedByUserID { set; get; }
        public bool IsLocked { set; get; }

        public ClsTestAppointment()
        {
            this.TestAppointmentID = -1;
            this.TestTypeID = -1;
            this.LocalDrivingLicenseApplicationID = -1;
            this.AppointmentDate = DateTime.MinValue;
            this.PaidFees = -1;
            this.CreatedByUserID = -1;
            this.IsLocked = false;
            Mode = enMode.AddNew;
        }
        private ClsTestAppointment(int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, decimal PaidFees, int CreatedByUserID, bool IsLocked)
        {
            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;
            Mode = enMode.Update;
        }
        private bool _AddNewTestAppointment()
        {
            this.TestAppointmentID = (int)ClsTestAppointmentData.AddNewTestAppointment(this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked);
            return (this.TestAppointmentID != -1);
        }
        private bool _UpdateTestAppointment()
        {
            return ClsTestAppointmentData.UpdateTestAppointment(this.TestAppointmentID, this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked);
        }
        public static bool DeleteTestAppointment(int TestAppointmentID)
        {
            return ClsTestAppointmentData.DeleteTestAppointment(TestAppointmentID);
        }
        public static bool IsTestAppointmentExistByTestAppointmentID(int TestAppointmentID)
        {
            return ClsTestAppointmentData.IsTestAppointmentExistByTestAppointmentID(TestAppointmentID);
        }
        public static bool IsTestAppointmentExistByTestTypeID(int TestTypeID)
        {
            return ClsTestAppointmentData.IsTestAppointmentExistByTestTypeID(TestTypeID);
        }
        public static bool IsTestAppointmentExistByLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID)
        {
            return ClsTestAppointmentData.IsTestAppointmentExistByLocalDrivingLicenseApplicationID(LocalDrivingLicenseApplicationID);
        }
        public static bool IsTestAppointmentExistByAppointmentDate(DateTime AppointmentDate)
        {
            return ClsTestAppointmentData.IsTestAppointmentExistByAppointmentDate(AppointmentDate);
        }
        public static bool IsTestAppointmentExistByPaidFees(decimal PaidFees)
        {
            return ClsTestAppointmentData.IsTestAppointmentExistByPaidFees(PaidFees);
        }
        public static bool IsTestAppointmentExistByCreatedByUserID(int CreatedByUserID)
        {
            return ClsTestAppointmentData.IsTestAppointmentExistByCreatedByUserID(CreatedByUserID);
        }
        public static bool IsTestAppointmentExistByIsLocked(bool IsLocked)
        {
            return ClsTestAppointmentData.IsTestAppointmentExistByIsLocked(IsLocked);
        }
        public static ClsTestAppointment FindByTestAppointmentID(int TestAppointmentID)
        {
            int TestTypeID = -1;
            int LocalDrivingLicenseApplicationID = -1;
            DateTime AppointmentDate = DateTime.MinValue;
            decimal PaidFees = -1;
            int CreatedByUserID = -1;
            bool IsLocked = false;

            bool IsFound = ClsTestAppointmentData.GetTestAppointmentByTestAppointmentID(TestAppointmentID, ref TestTypeID, ref LocalDrivingLicenseApplicationID, ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked);

            if (IsFound)
                return new ClsTestAppointment(TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked);
            else
                return null;
        }
        public static ClsTestAppointment FindByTestTypeID(int TestTypeID)
        {
            int TestAppointmentID = -1;
            int LocalDrivingLicenseApplicationID = -1;
            DateTime AppointmentDate = DateTime.MinValue;
            decimal PaidFees = -1;
            int CreatedByUserID = -1;
            bool IsLocked = false;

            bool IsFound = ClsTestAppointmentData.GetTestAppointmentByTestTypeID(ref TestAppointmentID, TestTypeID, ref LocalDrivingLicenseApplicationID, ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked);

            if (IsFound)
                return new ClsTestAppointment(TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked);
            else
                return null;
        }
        public static ClsTestAppointment FindByLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID)
        {
            int TestAppointmentID = -1;
            int TestTypeID = -1;
            DateTime AppointmentDate = DateTime.MinValue;
            decimal PaidFees = -1;
            int CreatedByUserID = -1;
            bool IsLocked = false;

            bool IsFound = ClsTestAppointmentData.GetTestAppointmentByLocalDrivingLicenseApplicationID(ref TestAppointmentID, ref TestTypeID, LocalDrivingLicenseApplicationID, ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked);

            if (IsFound)
                return new ClsTestAppointment(TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked);
            else
                return null;
        }
        public static ClsTestAppointment FindByAppointmentDate(DateTime AppointmentDate)
        {
            int TestAppointmentID = -1;
            int TestTypeID = -1;
            int LocalDrivingLicenseApplicationID = -1;
            decimal PaidFees = -1;
            int CreatedByUserID = -1;
            bool IsLocked = false;

            bool IsFound = ClsTestAppointmentData.GetTestAppointmentByAppointmentDate(ref TestAppointmentID, ref TestTypeID, ref LocalDrivingLicenseApplicationID, AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked);

            if (IsFound)
                return new ClsTestAppointment(TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked);
            else
                return null;
        }
        public static ClsTestAppointment FindByPaidFees(decimal PaidFees)
        {
            int TestAppointmentID = -1;
            int TestTypeID = -1;
            int LocalDrivingLicenseApplicationID = -1;
            DateTime AppointmentDate = DateTime.MinValue;
            int CreatedByUserID = -1;
            bool IsLocked = false;

            bool IsFound = ClsTestAppointmentData.GetTestAppointmentByPaidFees(ref TestAppointmentID, ref TestTypeID, ref LocalDrivingLicenseApplicationID, ref AppointmentDate, PaidFees, ref CreatedByUserID, ref IsLocked);

            if (IsFound)
                return new ClsTestAppointment(TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked);
            else
                return null;
        }
        public static ClsTestAppointment FindByCreatedByUserID(int CreatedByUserID)
        {
            int TestAppointmentID = -1;
            int TestTypeID = -1;
            int LocalDrivingLicenseApplicationID = -1;
            DateTime AppointmentDate = DateTime.MinValue;
            decimal PaidFees = -1;
            bool IsLocked = false;

            bool IsFound = ClsTestAppointmentData.GetTestAppointmentByCreatedByUserID(ref TestAppointmentID, ref TestTypeID, ref LocalDrivingLicenseApplicationID, ref AppointmentDate, ref PaidFees, CreatedByUserID, ref IsLocked);

            if (IsFound)
                return new ClsTestAppointment(TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked);
            else
                return null;
        }
        public static ClsTestAppointment FindByIsLocked(bool IsLocked)
        {
            int TestAppointmentID = -1;
            int TestTypeID = -1;
            int LocalDrivingLicenseApplicationID = -1;
            DateTime AppointmentDate = DateTime.MinValue;
            decimal PaidFees = -1;
            int CreatedByUserID = -1;

            bool IsFound = ClsTestAppointmentData.GetTestAppointmentByIsLocked(ref TestAppointmentID, ref TestTypeID, ref LocalDrivingLicenseApplicationID, ref AppointmentDate, ref PaidFees, ref CreatedByUserID, IsLocked);

            if (IsFound)
                return new ClsTestAppointment(TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked);
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTestAppointment())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateTestAppointment();
            }
            return false;
        }
        public static DataTable GetTestAppointments()
        {
            return ClsTestAppointmentData.GetAllTestAppointments();
        }
    }
}
