using ClsLicenseClassDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsLicenseClassBusinessLayer
{
    public class ClsLicenseClass
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int LicenseClassID { set; get; }
        public string ClassName { set; get; }
        public string ClassDescription { set; get; }
        public byte MinimumAllowedAge { set; get; }
        public byte DefaultValidityLength { set; get; }
        public decimal ClassFees { set; get; }

        public ClsLicenseClass()
        {
            this.LicenseClassID = -1;
            this.ClassName = "";
            this.ClassDescription = "";
            this.MinimumAllowedAge = 0;
            this.DefaultValidityLength = 0;
            this.ClassFees = -1;
            Mode = enMode.AddNew;
        }
        private ClsLicenseClass(int LicenseClassID, string ClassName, string ClassDescription, byte MinimumAllowedAge, byte DefaultValidityLength, decimal ClassFees)
        {
            this.LicenseClassID = LicenseClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;
            Mode = enMode.Update;
        }
        private bool _AddNewLicenseClass()
        {
            this.LicenseClassID = (int)ClsLicenseClassData.AddNewLicenseClass(this.ClassName, this.ClassDescription, this.MinimumAllowedAge, this.DefaultValidityLength, this.ClassFees);
            return (this.LicenseClassID != -1);
        }
        private bool _UpdateLicenseClass()
        {
            return ClsLicenseClassData.UpdateLicenseClass(this.LicenseClassID, this.ClassName, this.ClassDescription, this.MinimumAllowedAge, this.DefaultValidityLength, this.ClassFees);
        }
        public static bool DeleteLicenseClass(int LicenseClassID)
        {
            return ClsLicenseClassData.DeleteLicenseClass(LicenseClassID);
        }
        public static bool IsLicenseClassExistByLicenseClassID(int LicenseClassID)
        {
            return ClsLicenseClassData.IsLicenseClassExistByLicenseClassID(LicenseClassID);
        }
        public static bool IsLicenseClassExistByClassName(string ClassName)
        {
            return ClsLicenseClassData.IsLicenseClassExistByClassName(ClassName);
        }
        public static bool IsLicenseClassExistByClassDescription(string ClassDescription)
        {
            return ClsLicenseClassData.IsLicenseClassExistByClassDescription(ClassDescription);
        }
        public static bool IsLicenseClassExistByMinimumAllowedAge(byte MinimumAllowedAge)
        {
            return ClsLicenseClassData.IsLicenseClassExistByMinimumAllowedAge(MinimumAllowedAge);
        }
        public static bool IsLicenseClassExistByDefaultValidityLength(byte DefaultValidityLength)
        {
            return ClsLicenseClassData.IsLicenseClassExistByDefaultValidityLength(DefaultValidityLength);
        }
        public static bool IsLicenseClassExistByClassFees(decimal ClassFees)
        {
            return ClsLicenseClassData.IsLicenseClassExistByClassFees(ClassFees);
        }
        public static ClsLicenseClass FindByLicenseClassID(int LicenseClassID)
        {
            string ClassName = "";
            string ClassDescription = "";
            byte MinimumAllowedAge = 0;
            byte DefaultValidityLength = 0;
            decimal ClassFees = -1;

            bool IsFound = ClsLicenseClassData.GetLicenseClassByLicenseClassID(LicenseClassID, ref ClassName, ref ClassDescription, ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees);

            if (IsFound)
                return new ClsLicenseClass(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            else
                return null;
        }
        public static ClsLicenseClass FindByClassName(string ClassName)
        {
            int LicenseClassID = -1;
            string ClassDescription = "";
            byte MinimumAllowedAge = 0;
            byte DefaultValidityLength = 0;
            decimal ClassFees = -1;

            bool IsFound = ClsLicenseClassData.GetLicenseClassByClassName(ref LicenseClassID, ClassName, ref ClassDescription, ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees);

            if (IsFound)
                return new ClsLicenseClass(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            else
                return null;
        }
        public static ClsLicenseClass FindByClassDescription(string ClassDescription)
        {
            int LicenseClassID = -1;
            string ClassName = "";
            byte MinimumAllowedAge = 0;
            byte DefaultValidityLength = 0;
            decimal ClassFees = -1;

            bool IsFound = ClsLicenseClassData.GetLicenseClassByClassDescription(ref LicenseClassID, ref ClassName, ClassDescription, ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees);

            if (IsFound)
                return new ClsLicenseClass(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            else
                return null;
        }
        public static ClsLicenseClass FindByMinimumAllowedAge(byte MinimumAllowedAge)
        {
            int LicenseClassID = -1;
            string ClassName = "";
            string ClassDescription = "";
            byte DefaultValidityLength = 0;
            decimal ClassFees = -1;

            bool IsFound = ClsLicenseClassData.GetLicenseClassByMinimumAllowedAge(ref LicenseClassID, ref ClassName, ref ClassDescription, MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees);

            if (IsFound)
                return new ClsLicenseClass(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            else
                return null;
        }
        public static ClsLicenseClass FindByDefaultValidityLength(byte DefaultValidityLength)
        {
            int LicenseClassID = -1;
            string ClassName = "";
            string ClassDescription = "";
            byte MinimumAllowedAge = 0;
            decimal ClassFees = -1;

            bool IsFound = ClsLicenseClassData.GetLicenseClassByDefaultValidityLength(ref LicenseClassID, ref ClassName, ref ClassDescription, ref MinimumAllowedAge, DefaultValidityLength, ref ClassFees);

            if (IsFound)
                return new ClsLicenseClass(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            else
                return null;
        }
        public static ClsLicenseClass FindByClassFees(decimal ClassFees)
        {
            int LicenseClassID = -1;
            string ClassName = "";
            string ClassDescription = "";
            byte MinimumAllowedAge = 0;
            byte DefaultValidityLength = 0;

            bool IsFound = ClsLicenseClassData.GetLicenseClassByClassFees(ref LicenseClassID, ref ClassName, ref ClassDescription, ref MinimumAllowedAge, ref DefaultValidityLength, ClassFees);

            if (IsFound)
                return new ClsLicenseClass(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLicenseClass())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateLicenseClass();
            }
            return false;
        }
        public static DataTable GetLicenseClasses()
        {
            return ClsLicenseClassData.GetAllLicenseClasses();
        }
    }
}
