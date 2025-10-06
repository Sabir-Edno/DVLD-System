using ClsDriverDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsDriverBusinessLayer
{
    public class ClsDriver
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int DriverID { set; get; }
        public int PersonID { set; get; }
        public int CreatedByUserID { set; get; }
        public DateTime CreatedDate { set; get; }

        public ClsDriver()
        {
            this.DriverID = -1;
            this.PersonID = -1;
            this.CreatedByUserID = -1;
            this.CreatedDate = DateTime.MinValue;
            Mode = enMode.AddNew;
        }
        private ClsDriver(int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;
            Mode = enMode.Update;
        }
        private bool _AddNewDriver()
        {
            this.DriverID = (int)ClsDriverData.AddNewDriver(this.PersonID, this.CreatedByUserID, this.CreatedDate);
            return (this.DriverID != -1);
        }
        private bool _UpdateDriver()
        {
            return ClsDriverData.UpdateDriver(this.DriverID, this.PersonID, this.CreatedByUserID, this.CreatedDate);
        }
        public static bool DeleteDriver(int DriverID)
        {
            return ClsDriverData.DeleteDriver(DriverID);
        }
        public static bool IsDriverExistByDriverID(int DriverID)
        {
            return ClsDriverData.IsDriverExistByDriverID(DriverID);
        }
        public static bool IsDriverExistByPersonID(int PersonID)
        {
            return ClsDriverData.IsDriverExistByPersonID(PersonID);
        }
        public static bool IsDriverExistByCreatedByUserID(int CreatedByUserID)
        {
            return ClsDriverData.IsDriverExistByCreatedByUserID(CreatedByUserID);
        }
        public static bool IsDriverExistByCreatedDate(DateTime CreatedDate)
        {
            return ClsDriverData.IsDriverExistByCreatedDate(CreatedDate);
        }
        public static ClsDriver FindByDriverID(int DriverID)
        {
            int PersonID = -1;
            int CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.MinValue;

            bool IsFound = ClsDriverData.GetDriverByDriverID(DriverID, ref PersonID, ref CreatedByUserID, ref CreatedDate);

            if (IsFound)
                return new ClsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
            else
                return null;
        }
        public static ClsDriver FindByPersonID(int PersonID)
        {
            int DriverID = -1;
            int CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.MinValue;

            bool IsFound = ClsDriverData.GetDriverByPersonID(ref DriverID, PersonID, ref CreatedByUserID, ref CreatedDate);

            if (IsFound)
                return new ClsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
            else
                return null;
        }
        public static ClsDriver FindByCreatedByUserID(int CreatedByUserID)
        {
            int DriverID = -1;
            int PersonID = -1;
            DateTime CreatedDate = DateTime.MinValue;

            bool IsFound = ClsDriverData.GetDriverByCreatedByUserID(ref DriverID, ref PersonID, CreatedByUserID, ref CreatedDate);

            if (IsFound)
                return new ClsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
            else
                return null;
        }
        public static ClsDriver FindByCreatedDate(DateTime CreatedDate)
        {
            int DriverID = -1;
            int PersonID = -1;
            int CreatedByUserID = -1;

            bool IsFound = ClsDriverData.GetDriverByCreatedDate(ref DriverID, ref PersonID, ref CreatedByUserID, CreatedDate);

            if (IsFound)
                return new ClsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDriver())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateDriver();
            }
            return false;
        }
        public static DataTable GetDrivers()
        {
            return ClsDriverData.GetAllDrivers();
        }
    }
}
