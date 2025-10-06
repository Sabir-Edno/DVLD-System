using ClsUserDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsUserBusinessLayer
{
    public class ClsUser
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int UserID { set; get; }
        public int PersonID { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
        public bool IsActive { set; get; }

        public ClsUser()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.UserName = "";
            this.Password = "";
            this.IsActive = false;
            Mode = enMode.AddNew;
        }
        private ClsUser(int UserID, int PersonID, string UserName, string Password, bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;
            Mode = enMode.Update;
        }
        private bool _AddNewUser()
        {
            this.UserID = (int)ClsUserData.AddNewUser(this.PersonID, this.UserName, this.Password, this.IsActive);
            return (this.UserID != -1);
        }
        private bool _UpdateUser()
        {
            return ClsUserData.UpdateUser(this.UserID, this.PersonID, this.UserName, this.Password, this.IsActive);
        }
        public static bool DeleteUser(int UserID)
        {
            return ClsUserData.DeleteUser(UserID);
        }
        public static bool IsUserExistByUserID(int UserID)
        {
            return ClsUserData.IsUserExistByUserID(UserID);
        }
        public static bool IsUserExistByPersonID(int PersonID)
        {
            return ClsUserData.IsUserExistByPersonID(PersonID);
        }
        public static bool IsUserExistByUserName(string UserName)
        {
            return ClsUserData.IsUserExistByUserName(UserName);
        }
        public static bool IsUserExistByPassword(string Password)
        {
            return ClsUserData.IsUserExistByPassword(Password);
        }
        public static bool IsUserExistByIsActive(bool IsActive)
        {
            return ClsUserData.IsUserExistByIsActive(IsActive);
        }
        public static ClsUser FindByUserID(int UserID)
        {
            int PersonID = -1;
            string UserName = "";
            string Password = "";
            bool IsActive = false;

            bool IsFound = ClsUserData.GetUserByUserID(UserID, ref PersonID, ref UserName, ref Password, ref IsActive);

            if (IsFound)
                return new ClsUser(UserID, PersonID, UserName, Password, IsActive);
            else
                return null;
        }
        public static ClsUser FindByPersonID(int PersonID)
        {
            int UserID = -1;
            string UserName = "";
            string Password = "";
            bool IsActive = false;

            bool IsFound = ClsUserData.GetUserByPersonID(ref UserID, PersonID, ref UserName, ref Password, ref IsActive);

            if (IsFound)
                return new ClsUser(UserID, PersonID, UserName, Password, IsActive);
            else
                return null;
        }
        public static ClsUser FindByUserName(string UserName)
        {
            int UserID = -1;
            int PersonID = -1;
            string Password = "";
            bool IsActive = false;

            bool IsFound = ClsUserData.GetUserByUserName(ref UserID, ref PersonID, UserName, ref Password, ref IsActive);

            if (IsFound)
                return new ClsUser(UserID, PersonID, UserName, Password, IsActive);
            else
                return null;
        }
        public static ClsUser FindByPassword(string Password)
        {
            int UserID = -1;
            int PersonID = -1;
            string UserName = "";
            bool IsActive = false;

            bool IsFound = ClsUserData.GetUserByPassword(ref UserID, ref PersonID, ref UserName, Password, ref IsActive);

            if (IsFound)
                return new ClsUser(UserID, PersonID, UserName, Password, IsActive);
            else
                return null;
        }
        public static ClsUser FindByIsActive(bool IsActive)
        {
            int UserID = -1;
            int PersonID = -1;
            string UserName = "";
            string Password = "";

            bool IsFound = ClsUserData.GetUserByIsActive(ref UserID, ref PersonID, ref UserName, ref Password, IsActive);

            if (IsFound)
                return new ClsUser(UserID, PersonID, UserName, Password, IsActive);
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateUser();
            }
            return false;
        }
        public static DataTable GetUsers()
        {
            return ClsUserData.GetAllUsers();
        }
    }
}
