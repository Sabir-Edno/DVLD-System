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
       static ClsUser User;

        public static void LoadUserInfo(string Username ,ref bool IsUserFound)
        {
            User = ClsUser.FindByUserName(Username);

            if(User != null)
                IsUserFound = true;
            else
                IsUserFound = false;
        }
    }
}
