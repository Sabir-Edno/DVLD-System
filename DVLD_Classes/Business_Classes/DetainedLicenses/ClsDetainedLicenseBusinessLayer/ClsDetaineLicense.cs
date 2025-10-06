using ClsDetainedLicenseDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsDetainedLicenseBusinessLayer
{
    public class ClsDetaineLicense
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int DetainID { set; get; }
        public int LicenseID { set; get; }
        public DateTime DetainDate { set; get; }
        public decimal FineFees { set; get; }
        public int CreatedByUserID { set; get; }
        public bool IsReleased { set; get; }
        public DateTime ReleaseDate { set; get; }
        public int ReleasedByUserID { set; get; }
        public int ReleaseApplicationID { set; get; }

        public ClsDetaineLicense()
        {
            this.DetainID = -1;
            this.LicenseID = -1;
            this.DetainDate = DateTime.MinValue;
            this.FineFees = -1;
            this.CreatedByUserID = -1;
            this.IsReleased = false;
            this.ReleaseDate = DateTime.MinValue;
            this.ReleasedByUserID = -1;
            this.ReleaseApplicationID = -1;
            Mode = enMode.AddNew;
        }
        private ClsDetaineLicense(int DetainID, int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID, bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            this.DetainID = DetainID;
            this.LicenseID = LicenseID;
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsReleased = IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseApplicationID = ReleaseApplicationID;
            Mode = enMode.Update;
        }
        private bool _AddNewDetain()
        {
            this.DetainID = (int)ClsDetaineLicenseData.AddNewDetain(this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID, this.IsReleased, this.ReleaseDate, this.ReleasedByUserID, this.ReleaseApplicationID);
            return (this.DetainID != -1);
        }
        private bool _UpdateDetain()
        {
            return ClsDetaineLicenseData.UpdateDetain(this.DetainID, this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID, this.IsReleased, this.ReleaseDate, this.ReleasedByUserID, this.ReleaseApplicationID);
        }
        public static bool DeleteDetain(int DetainID)
        {
            return ClsDetaineLicenseData.DeleteDetain(DetainID);
        }
        public static bool IsDetainExistByDetainID(int DetainID)
        {
            return ClsDetaineLicenseData.IsDetainExistByDetainID(DetainID);
        }
        public static bool IsDetainExistByLicenseID(int LicenseID)
        {
            return ClsDetaineLicenseData.IsDetainExistByLicenseID(LicenseID);
        }
        public static bool IsDetainExistByDetainDate(DateTime DetainDate)
        {
            return ClsDetaineLicenseData.IsDetainExistByDetainDate(DetainDate);
        }
        public static bool IsDetainExistByFineFees(decimal FineFees)
        {
            return ClsDetaineLicenseData.IsDetainExistByFineFees(FineFees);
        }
        public static bool IsDetainExistByCreatedByUserID(int CreatedByUserID)
        {
            return ClsDetaineLicenseData.IsDetainExistByCreatedByUserID(CreatedByUserID);
        }
        public static bool IsDetainExistByIsReleased(bool IsReleased)
        {
            return ClsDetaineLicenseData.IsDetainExistByIsReleased(IsReleased);
        }
        public static bool IsDetainExistByReleaseDate(DateTime ReleaseDate)
        {
            return ClsDetaineLicenseData.IsDetainExistByReleaseDate(ReleaseDate);
        }
        public static bool IsDetainExistByReleasedByUserID(int ReleasedByUserID)
        {
            return ClsDetaineLicenseData.IsDetainExistByReleasedByUserID(ReleasedByUserID);
        }
        public static bool IsDetainExistByReleaseApplicationID(int ReleaseApplicationID)
        {
            return ClsDetaineLicenseData.IsDetainExistByReleaseApplicationID(ReleaseApplicationID);
        }
        public static ClsDetaineLicense FindByDetainID(int DetainID)
        {
            int LicenseID = -1;
            DateTime DetainDate = DateTime.MinValue;
            decimal FineFees = -1;
            int CreatedByUserID = -1;
            bool IsReleased = false;
            DateTime ReleaseDate = DateTime.MinValue;
            int ReleasedByUserID = -1;
            int ReleaseApplicationID = -1;

            bool IsFound = ClsDetaineLicenseData.GetDetainByDetainID(DetainID, ref LicenseID, ref DetainDate, ref FineFees, ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID);

            if (IsFound)
                return new ClsDetaineLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            else
                return null;
        }
        public static ClsDetaineLicense FindByLicenseID(int LicenseID)
        {
            int DetainID = -1;
            DateTime DetainDate = DateTime.MinValue;
            decimal FineFees = -1;
            int CreatedByUserID = -1;
            bool IsReleased = false;
            DateTime ReleaseDate = DateTime.MinValue;
            int ReleasedByUserID = -1;
            int ReleaseApplicationID = -1;

            bool IsFound = ClsDetaineLicenseData.GetDetainByLicenseID(ref DetainID, LicenseID, ref DetainDate, ref FineFees, ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID);

            if (IsFound)
                return new ClsDetaineLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            else
                return null;
        }
        public static ClsDetaineLicense FindByDetainDate(DateTime DetainDate)
        {
            int DetainID = -1;
            int LicenseID = -1;
            decimal FineFees = -1;
            int CreatedByUserID = -1;
            bool IsReleased = false;
            DateTime ReleaseDate = DateTime.MinValue;
            int ReleasedByUserID = -1;
            int ReleaseApplicationID = -1;

            bool IsFound = ClsDetaineLicenseData.GetDetainByDetainDate(ref DetainID, ref LicenseID, DetainDate, ref FineFees, ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID);

            if (IsFound)
                return new ClsDetaineLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            else
                return null;
        }
        public static ClsDetaineLicense FindByFineFees(decimal FineFees)
        {
            int DetainID = -1;
            int LicenseID = -1;
            DateTime DetainDate = DateTime.MinValue;
            int CreatedByUserID = -1;
            bool IsReleased = false;
            DateTime ReleaseDate = DateTime.MinValue;
            int ReleasedByUserID = -1;
            int ReleaseApplicationID = -1;

            bool IsFound = ClsDetaineLicenseData.GetDetainByFineFees(ref DetainID, ref LicenseID, ref DetainDate, FineFees, ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID);

            if (IsFound)
                return new ClsDetaineLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            else
                return null;
        }
        public static ClsDetaineLicense FindByCreatedByUserID(int CreatedByUserID)
        {
            int DetainID = -1;
            int LicenseID = -1;
            DateTime DetainDate = DateTime.MinValue;
            decimal FineFees = -1;
            bool IsReleased = false;
            DateTime ReleaseDate = DateTime.MinValue;
            int ReleasedByUserID = -1;
            int ReleaseApplicationID = -1;

            bool IsFound = ClsDetaineLicenseData.GetDetainByCreatedByUserID(ref DetainID, ref LicenseID, ref DetainDate, ref FineFees, CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID);

            if (IsFound)
                return new ClsDetaineLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            else
                return null;
        }
        public static ClsDetaineLicense FindByIsReleased(bool IsReleased)
        {
            int DetainID = -1;
            int LicenseID = -1;
            DateTime DetainDate = DateTime.MinValue;
            decimal FineFees = -1;
            int CreatedByUserID = -1;
            DateTime ReleaseDate = DateTime.MinValue;
            int ReleasedByUserID = -1;
            int ReleaseApplicationID = -1;

            bool IsFound = ClsDetaineLicenseData.GetDetainByIsReleased(ref DetainID, ref LicenseID, ref DetainDate, ref FineFees, ref CreatedByUserID, IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID);

            if (IsFound)
                return new ClsDetaineLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            else
                return null;
        }
        public static ClsDetaineLicense FindByReleaseDate(DateTime ReleaseDate)
        {
            int DetainID = -1;
            int LicenseID = -1;
            DateTime DetainDate = DateTime.MinValue;
            decimal FineFees = -1;
            int CreatedByUserID = -1;
            bool IsReleased = false;
            int ReleasedByUserID = -1;
            int ReleaseApplicationID = -1;

            bool IsFound = ClsDetaineLicenseData.GetDetainByReleaseDate(ref DetainID, ref LicenseID, ref DetainDate, ref FineFees, ref CreatedByUserID, ref IsReleased, ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID);

            if (IsFound)
                return new ClsDetaineLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            else
                return null;
        }
        public static ClsDetaineLicense FindByReleasedByUserID(int ReleasedByUserID)
        {
            int DetainID = -1;
            int LicenseID = -1;
            DateTime DetainDate = DateTime.MinValue;
            decimal FineFees = -1;
            int CreatedByUserID = -1;
            bool IsReleased = false;
            DateTime ReleaseDate = DateTime.MinValue;
            int ReleaseApplicationID = -1;

            bool IsFound = ClsDetaineLicenseData.GetDetainByReleasedByUserID(ref DetainID, ref LicenseID, ref DetainDate, ref FineFees, ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ReleasedByUserID, ref ReleaseApplicationID);

            if (IsFound)
                return new ClsDetaineLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            else
                return null;
        }
        public static ClsDetaineLicense FindByReleaseApplicationID(int ReleaseApplicationID)
        {
            int DetainID = -1;
            int LicenseID = -1;
            DateTime DetainDate = DateTime.MinValue;
            decimal FineFees = -1;
            int CreatedByUserID = -1;
            bool IsReleased = false;
            DateTime ReleaseDate = DateTime.MinValue;
            int ReleasedByUserID = -1;

            bool IsFound = ClsDetaineLicenseData.GetDetainByReleaseApplicationID(ref DetainID, ref LicenseID, ref DetainDate, ref FineFees, ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ReleaseApplicationID);

            if (IsFound)
                return new ClsDetaineLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDetain())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateDetain();
            }
            return false;
        }
        public static DataTable GetDetainedLicenses()
        {
            return ClsDetaineLicenseData.GetAllDetainedLicenses();
        }
    }
}
