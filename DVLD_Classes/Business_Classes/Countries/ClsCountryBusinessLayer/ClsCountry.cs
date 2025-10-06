using ClsCountryDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsCountryBusinessLayer
{
    public class ClsCountry
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int CountryID { set; get; }
        public string CountryName { set; get; }

        public ClsCountry()
        {
            this.CountryID = -1;
            this.CountryName = "";
            Mode = enMode.AddNew;
        }
        private ClsCountry(int CountryID, string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
            Mode = enMode.Update;
        }
        private bool _AddNewCountry()
        {
            this.CountryID = (int)ClsCountryData.AddNewCountry(this.CountryName);
            return (this.CountryID != -1);
        }
        private bool _UpdateCountry()
        {
            return ClsCountryData.UpdateCountry(this.CountryID, this.CountryName);
        }
        public static bool DeleteCountry(int CountryID)
        {
            return ClsCountryData.DeleteCountry(CountryID);
        }
        public static bool IsCountryExistByCountryID(int CountryID)
        {
            return ClsCountryData.IsCountryExistByCountryID(CountryID);
        }
        public static bool IsCountryExistByCountryName(string CountryName)
        {
            return ClsCountryData.IsCountryExistByCountryName(CountryName);
        }
        public static ClsCountry FindByCountryID(int CountryID)
        {
            string CountryName = "";

            bool IsFound = ClsCountryData.GetCountryByCountryID(CountryID, ref CountryName);

            if (IsFound)
                return new ClsCountry(CountryID, CountryName);
            else
                return null;
        }
        public static ClsCountry FindByCountryName(string CountryName)
        {
            int CountryID = -1;

            bool IsFound = ClsCountryData.GetCountryByCountryName(ref CountryID, CountryName);

            if (IsFound)
                return new ClsCountry(CountryID, CountryName);
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewCountry())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateCountry();
            }
            return false;
        }
        public static DataTable GetCountries()
        {
            return ClsCountryData.GetAllCountries();
        }
    }
}
