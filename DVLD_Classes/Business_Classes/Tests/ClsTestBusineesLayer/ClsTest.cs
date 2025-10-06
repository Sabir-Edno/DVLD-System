using ClsTestDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsTestBusineesLayer
{
    public class ClsTest
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int TestID { set; get; }
        public int TestAppointmentID { set; get; }
        public bool TestResult { set; get; }
        public string Notes { set; get; }
        public int CreatedByUserID { set; get; }

        public ClsTest()
        {
            this.TestID = -1;
            this.TestAppointmentID = -1;
            this.TestResult = false;
            this.Notes = "";
            this.CreatedByUserID = -1;
            Mode = enMode.AddNew;
        }
        private ClsTest(int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            this.TestID = TestID;
            this.TestAppointmentID = TestAppointmentID;
            this.TestResult = TestResult;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;
            Mode = enMode.Update;
        }
        private bool _AddNewTest()
        {
            this.TestID = (int)ClsTestData.AddNewTest(this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);
            return (this.TestID != -1);
        }
        private bool _UpdateTest()
        {
            return ClsTestData.UpdateTest(this.TestID, this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);
        }
        public static bool DeleteTest(int TestID)
        {
            return ClsTestData.DeleteTest(TestID);
        }
        public static bool IsTestExistByTestID(int TestID)
        {
            return ClsTestData.IsTestExistByTestID(TestID);
        }
        public static bool IsTestExistByTestAppointmentID(int TestAppointmentID)
        {
            return ClsTestData.IsTestExistByTestAppointmentID(TestAppointmentID);
        }
        public static bool IsTestExistByTestResult(bool TestResult)
        {
            return ClsTestData.IsTestExistByTestResult(TestResult);
        }
        public static bool IsTestExistByNotes(string Notes)
        {
            return ClsTestData.IsTestExistByNotes(Notes);
        }
        public static bool IsTestExistByCreatedByUserID(int CreatedByUserID)
        {
            return ClsTestData.IsTestExistByCreatedByUserID(CreatedByUserID);
        }
        public static ClsTest FindByTestID(int TestID)
        {
            int TestAppointmentID = -1;
            bool TestResult = false;
            string Notes = "";
            int CreatedByUserID = -1;

            bool IsFound = ClsTestData.GetTestByTestID(TestID, ref TestAppointmentID, ref TestResult, ref Notes, ref CreatedByUserID);

            if (IsFound)
                return new ClsTest(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
            else
                return null;
        }
        public static ClsTest FindByTestAppointmentID(int TestAppointmentID)
        {
            int TestID = -1;
            bool TestResult = false;
            string Notes = "";
            int CreatedByUserID = -1;

            bool IsFound = ClsTestData.GetTestByTestAppointmentID(ref TestID, TestAppointmentID, ref TestResult, ref Notes, ref CreatedByUserID);

            if (IsFound)
                return new ClsTest(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
            else
                return null;
        }
        public static ClsTest FindByTestResult(bool TestResult)
        {
            int TestID = -1;
            int TestAppointmentID = -1;
            string Notes = "";
            int CreatedByUserID = -1;

            bool IsFound = ClsTestData.GetTestByTestResult(ref TestID, ref TestAppointmentID, TestResult, ref Notes, ref CreatedByUserID);

            if (IsFound)
                return new ClsTest(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
            else
                return null;
        }
        public static ClsTest FindByNotes(string Notes)
        {
            int TestID = -1;
            int TestAppointmentID = -1;
            bool TestResult = false;
            int CreatedByUserID = -1;

            bool IsFound = ClsTestData.GetTestByNotes(ref TestID, ref TestAppointmentID, ref TestResult, Notes, ref CreatedByUserID);

            if (IsFound)
                return new ClsTest(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
            else
                return null;
        }
        public static ClsTest FindByCreatedByUserID(int CreatedByUserID)
        {
            int TestID = -1;
            int TestAppointmentID = -1;
            bool TestResult = false;
            string Notes = "";

            bool IsFound = ClsTestData.GetTestByCreatedByUserID(ref TestID, ref TestAppointmentID, ref TestResult, ref Notes, CreatedByUserID);

            if (IsFound)
                return new ClsTest(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTest())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateTest();
            }
            return false;
        }
        public static DataTable GetTests()
        {
            return ClsTestData.GetAllTests();
        }
    }
}
