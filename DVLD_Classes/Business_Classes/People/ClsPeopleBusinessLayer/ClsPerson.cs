using ClsPeopleDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsPeopleBusinessLayer
{
    public class ClsPerson
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int PersonID { set; get; }
        public string NationalNo { set; get; }
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string ThirdName { set; get; }
        public string LastName { set; get; }
        public DateTime DateOfBirth { set; get; }
        public byte Gendor { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public int NationalityCountryID { set; get; }
        public string ImagePath { set; get; }

        public ClsPerson()
        {
            this.PersonID = -1;
            this.NationalNo = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.MinValue;
            this.Gendor = 0;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.NationalityCountryID = -1;
            this.ImagePath = "";
            Mode = enMode.AddNew;
        }
        private ClsPerson(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, byte Gendor, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;
            Mode = enMode.Update;
        }
        private bool _AddNewPerson()
        {
            this.PersonID = (int)ClsPersonData.AddNewPerson(this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth, this.Gendor, this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);
            return (this.PersonID != -1);
        }
        private bool _UpdatePerson()
        {
            return ClsPersonData.UpdatePerson(this.PersonID, this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth, this.Gendor, this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);
        }
        public static bool DeletePerson(int PersonID)
        {
            return ClsPersonData.DeletePerson(PersonID);
        }
        public static bool IsPersonExistByPersonID(int PersonID)
        {
            return ClsPersonData.IsPersonExistByPersonID(PersonID);
        }
        public static bool IsPersonExistByNationalNo(string NationalNo)
        {
            return ClsPersonData.IsPersonExistByNationalNo(NationalNo);
        }
        public static bool IsPersonExistByFirstName(string FirstName)
        {
            return ClsPersonData.IsPersonExistByFirstName(FirstName);
        }
        public static bool IsPersonExistBySecondName(string SecondName)
        {
            return ClsPersonData.IsPersonExistBySecondName(SecondName);
        }
        public static bool IsPersonExistByThirdName(string ThirdName)
        {
            return ClsPersonData.IsPersonExistByThirdName(ThirdName);
        }
        public static bool IsPersonExistByLastName(string LastName)
        {
            return ClsPersonData.IsPersonExistByLastName(LastName);
        }
        public static bool IsPersonExistByDateOfBirth(DateTime DateOfBirth)
        {
            return ClsPersonData.IsPersonExistByDateOfBirth(DateOfBirth);
        }
        public static bool IsPersonExistByGendor(byte Gendor)
        {
            return ClsPersonData.IsPersonExistByGendor(Gendor);
        }
        public static bool IsPersonExistByAddress(string Address)
        {
            return ClsPersonData.IsPersonExistByAddress(Address);
        }
        public static bool IsPersonExistByPhone(string Phone)
        {
            return ClsPersonData.IsPersonExistByPhone(Phone);
        }
        public static bool IsPersonExistByEmail(string Email)
        {
            return ClsPersonData.IsPersonExistByEmail(Email);
        }
        public static bool IsPersonExistByNationalityCountryID(int NationalityCountryID)
        {
            return ClsPersonData.IsPersonExistByNationalityCountryID(NationalityCountryID);
        }
        public static bool IsPersonExistByImagePath(string ImagePath)
        {
            return ClsPersonData.IsPersonExistByImagePath(ImagePath);
        }
        public static ClsPerson FindByPersonID(int PersonID)
        {
            string NationalNo = "";
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.MinValue;
            byte Gendor = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = -1;
            string ImagePath = "";

            bool IsFound = ClsPersonData.GetPersonByPersonID(PersonID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath);

            if (IsFound)
                return new ClsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;
        }
        public static ClsPerson FindByNationalNo(string NationalNo)
        {
            int PersonID = -1;
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.MinValue;
            byte Gendor = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = -1;
            string ImagePath = "";

            bool IsFound = ClsPersonData.GetPersonByNationalNo(ref PersonID, NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath);

            if (IsFound)
                return new ClsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;
        }
        public static ClsPerson FindByFirstName(string FirstName)
        {
            int PersonID = -1;
            string NationalNo = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.MinValue;
            byte Gendor = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = -1;
            string ImagePath = "";

            bool IsFound = ClsPersonData.GetPersonByFirstName(ref PersonID, ref NationalNo, FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath);

            if (IsFound)
                return new ClsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;
        }
        public static ClsPerson FindBySecondName(string SecondName)
        {
            int PersonID = -1;
            string NationalNo = "";
            string FirstName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.MinValue;
            byte Gendor = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = -1;
            string ImagePath = "";

            bool IsFound = ClsPersonData.GetPersonBySecondName(ref PersonID, ref NationalNo, ref FirstName, SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath);

            if (IsFound)
                return new ClsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;
        }
        public static ClsPerson FindByThirdName(string ThirdName)
        {
            int PersonID = -1;
            string NationalNo = "";
            string FirstName = "";
            string SecondName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.MinValue;
            byte Gendor = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = -1;
            string ImagePath = "";

            bool IsFound = ClsPersonData.GetPersonByThirdName(ref PersonID, ref NationalNo, ref FirstName, ref SecondName, ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath);

            if (IsFound)
                return new ClsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;
        }
        public static ClsPerson FindByLastName(string LastName)
        {
            int PersonID = -1;
            string NationalNo = "";
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            DateTime DateOfBirth = DateTime.MinValue;
            byte Gendor = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = -1;
            string ImagePath = "";

            bool IsFound = ClsPersonData.GetPersonByLastName(ref PersonID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath);

            if (IsFound)
                return new ClsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;
        }
        public static ClsPerson FindByDateOfBirth(DateTime DateOfBirth)
        {
            int PersonID = -1;
            string NationalNo = "";
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            byte Gendor = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = -1;
            string ImagePath = "";

            bool IsFound = ClsPersonData.GetPersonByDateOfBirth(ref PersonID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName, DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath);

            if (IsFound)
                return new ClsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;
        }
        public static ClsPerson FindByGendor(byte Gendor)
        {
            int PersonID = -1;
            string NationalNo = "";
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.MinValue;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = -1;
            string ImagePath = "";

            bool IsFound = ClsPersonData.GetPersonByGendor(ref PersonID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath);

            if (IsFound)
                return new ClsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;
        }
        public static ClsPerson FindByAddress(string Address)
        {
            int PersonID = -1;
            string NationalNo = "";
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.MinValue;
            byte Gendor = 0;
            string Phone = "";
            string Email = "";
            int NationalityCountryID = -1;
            string ImagePath = "";

            bool IsFound = ClsPersonData.GetPersonByAddress(ref PersonID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath);

            if (IsFound)
                return new ClsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;
        }
        public static ClsPerson FindByPhone(string Phone)
        {
            int PersonID = -1;
            string NationalNo = "";
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.MinValue;
            byte Gendor = 0;
            string Address = "";
            string Email = "";
            int NationalityCountryID = -1;
            string ImagePath = "";

            bool IsFound = ClsPersonData.GetPersonByPhone(ref PersonID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address, Phone, ref Email, ref NationalityCountryID, ref ImagePath);

            if (IsFound)
                return new ClsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;
        }
        public static ClsPerson FindByEmail(string Email)
        {
            int PersonID = -1;
            string NationalNo = "";
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.MinValue;
            byte Gendor = 0;
            string Address = "";
            string Phone = "";
            int NationalityCountryID = -1;
            string ImagePath = "";

            bool IsFound = ClsPersonData.GetPersonByEmail(ref PersonID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, Email, ref NationalityCountryID, ref ImagePath);

            if (IsFound)
                return new ClsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;
        }
        public static ClsPerson FindByNationalityCountryID(int NationalityCountryID)
        {
            int PersonID = -1;
            string NationalNo = "";
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.MinValue;
            byte Gendor = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            string ImagePath = "";

            bool IsFound = ClsPersonData.GetPersonByNationalityCountryID(ref PersonID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, NationalityCountryID, ref ImagePath);

            if (IsFound)
                return new ClsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;
        }
        public static ClsPerson FindByImagePath(string ImagePath)
        {
            int PersonID = -1;
            string NationalNo = "";
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.MinValue;
            byte Gendor = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = -1;

            bool IsFound = ClsPersonData.GetPersonByImagePath(ref PersonID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ImagePath);

            if (IsFound)
                return new ClsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdatePerson();
            }
            return false;
        }
        public static DataTable GetPeople()
        {
            return ClsPersonData.GetAllPeople();
        }
    }
}
