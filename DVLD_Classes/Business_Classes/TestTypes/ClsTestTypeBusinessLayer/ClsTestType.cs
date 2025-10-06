using ClsTestTypeDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsTestTypeBusinessLayer
{
    public class ClsTestType
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int TestTypeID { set; get; }
        public string TestTypeTitle { set; get; }
        public string TestTypeDescription { set; get; }
        public decimal TestTypeFees { set; get; }

        public ClsTestType()
        {
            this.TestTypeID = -1;
            this.TestTypeTitle = "";
            this.TestTypeDescription = "";
            this.TestTypeFees = -1;
            Mode = enMode.AddNew;
        }
        private ClsTestType(int TestTypeID, string TestTypeTitle, string TestTypeDescription, decimal TestTypeFees)
        {
            this.TestTypeID = TestTypeID;
            this.TestTypeTitle = TestTypeTitle;
            this.TestTypeDescription = TestTypeDescription;
            this.TestTypeFees = TestTypeFees;
            Mode = enMode.Update;
        }
        private bool _AddNewTestType()
        {
            this.TestTypeID = (int)ClsTestTypeData.AddNewTestType(this.TestTypeTitle, this.TestTypeDescription, this.TestTypeFees);
            return (this.TestTypeID != -1);
        }
        private bool _UpdateTestType()
        {
            return ClsTestTypeData.UpdateTestType(this.TestTypeID, this.TestTypeTitle, this.TestTypeDescription, this.TestTypeFees);
        }
        public static bool DeleteTestType(int TestTypeID)
        {
            return ClsTestTypeData.DeleteTestType(TestTypeID);
        }
        public static bool IsTestTypeExistByTestTypeID(int TestTypeID)
        {
            return ClsTestTypeData.IsTestTypeExistByTestTypeID(TestTypeID);
        }
        public static bool IsTestTypeExistByTestTypeTitle(string TestTypeTitle)
        {
            return ClsTestTypeData.IsTestTypeExistByTestTypeTitle(TestTypeTitle);
        }
        public static bool IsTestTypeExistByTestTypeDescription(string TestTypeDescription)
        {
            return ClsTestTypeData.IsTestTypeExistByTestTypeDescription(TestTypeDescription);
        }
        public static bool IsTestTypeExistByTestTypeFees(decimal TestTypeFees)
        {
            return ClsTestTypeData.IsTestTypeExistByTestTypeFees(TestTypeFees);
        }
        public static ClsTestType FindByTestTypeID(int TestTypeID)
        {
            string TestTypeTitle = "";
            string TestTypeDescription = "";
            decimal TestTypeFees = -1;

            bool IsFound = ClsTestTypeData.GetTestTypeByTestTypeID(TestTypeID, ref TestTypeTitle, ref TestTypeDescription, ref TestTypeFees);

            if (IsFound)
                return new ClsTestType(TestTypeID, TestTypeTitle, TestTypeDescription, TestTypeFees);
            else
                return null;
        }
        public static ClsTestType FindByTestTypeTitle(string TestTypeTitle)
        {
            int TestTypeID = -1;
            string TestTypeDescription = "";
            decimal TestTypeFees = -1;

            bool IsFound = ClsTestTypeData.GetTestTypeByTestTypeTitle(ref TestTypeID, TestTypeTitle, ref TestTypeDescription, ref TestTypeFees);

            if (IsFound)
                return new ClsTestType(TestTypeID, TestTypeTitle, TestTypeDescription, TestTypeFees);
            else
                return null;
        }
        public static ClsTestType FindByTestTypeDescription(string TestTypeDescription)
        {
            int TestTypeID = -1;
            string TestTypeTitle = "";
            decimal TestTypeFees = -1;

            bool IsFound = ClsTestTypeData.GetTestTypeByTestTypeDescription(ref TestTypeID, ref TestTypeTitle, TestTypeDescription, ref TestTypeFees);

            if (IsFound)
                return new ClsTestType(TestTypeID, TestTypeTitle, TestTypeDescription, TestTypeFees);
            else
                return null;
        }
        public static ClsTestType FindByTestTypeFees(decimal TestTypeFees)
        {
            int TestTypeID = -1;
            string TestTypeTitle = "";
            string TestTypeDescription = "";

            bool IsFound = ClsTestTypeData.GetTestTypeByTestTypeFees(ref TestTypeID, ref TestTypeTitle, ref TestTypeDescription, TestTypeFees);

            if (IsFound)
                return new ClsTestType(TestTypeID, TestTypeTitle, TestTypeDescription, TestTypeFees);
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTestType())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateTestType();
            }
            return false;
        }
        public static DataTable GetTestTypes()
        {
            return ClsTestTypeData.GetAllTestTypes();
        }
    }
}
