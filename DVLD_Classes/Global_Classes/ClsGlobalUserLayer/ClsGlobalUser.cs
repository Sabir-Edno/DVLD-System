using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClsUserBusinessLayer;

namespace ClsGlobalUserLayer
{
    public static class ClsGlobalUser
    {
       public static ClsUser CurrentUser;

        public static void LoadUserInfo(string Username ,ref bool IsUserFound)
        {
            CurrentUser = ClsUser.FindByUserName(Username);

            if(CurrentUser != null)
                IsUserFound = true;
            else
                IsUserFound = false;
        }
    }
}
