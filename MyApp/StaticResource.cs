using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    internal class StaticResource
    {
        private static string serverName = "HDUYSTRIX";
        private static readonly string cString = "Data Source=" + serverName + ";Initial Catalog=NhatNamFood;Integrated Security=True;TrustServerCertificate=True";

        private static string currentRole;
        private static string currentUser;

        public static string vndMoneyFormat(decimal value)
        {
            return value.ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("vi-VN"));
        }

        public static string connectionString()
        {
            return cString;
        }

        public static string getCurrentRole()
        {
            return currentRole;
        }

        public static void setCurrentRole(string role)
        {
            currentRole = role;
        }

        public static string getCurrentUser()
        {
            return currentUser;
        }

        public static void setCurrentUser(string lgName)
        {
            currentUser = lgName;
        }

        public static string convertDecimalToIntString(string value)
        {
            return value.Substring(0, value.IndexOf("."));
        }
    }
}
