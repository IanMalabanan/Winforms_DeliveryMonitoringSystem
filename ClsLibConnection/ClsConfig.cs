using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace ClsLibConnection
{
    public class ClsConfig
    {
        //public static String AccessConnectionString
        //{
        //    get { return ConfigurationManager.AppSettings["ConStrAccess"]; }
        //}

        //public static String SqlConnectionString
        //{
        //    get { return ConfigurationManager.AppSettings["ConStrSQL"]; }
        //}

        public static DirectoryInfo di = new DirectoryInfo(Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\");
        
        //public static String strProvider
        //{
        //    get { return ConfigurationManager.AppSettings["Provider"].ToString(); }
        //}

        //public static String AccessLink
        //{
        //    get { return ConfigurationManager.AppSettings["AccessLink"].ToString(); }
        //}


        public static String Server
        {
            get { return ConfigurationManager.AppSettings["Server"].ToString(); }
        }

        public static string Database
        {
            get { return ConfigurationManager.AppSettings["Database"].ToString(); }
        }

        public static String User
        {
            get { return ConfigurationManager.AppSettings["User"].ToString(); }
        }

        public static String Password
        {
            get { return ConfigurationManager.AppSettings["Password"].ToString(); }
        }



        public static String Server_APPS1
        {
            get { return ConfigurationManager.AppSettings["Server_Apps1"].ToString(); }
        }

        public static string Database_SOMS
        {
            get { return ConfigurationManager.AppSettings["Database_SOMS"].ToString(); }
        }

        public static string Database_PIS
        {
            get { return ConfigurationManager.AppSettings["Database_PIS"].ToString(); }
        }

        public static String User_APPS1
        {
            get { return ConfigurationManager.AppSettings["User_Apps1"].ToString(); }
        }

        public static String Password_APPS1
        {
            get { return ConfigurationManager.AppSettings["Password_Apps1"].ToString(); }
        }


        public static Int32 ProgramID
        {
            get { return 1; }
        }

        public static String ProgramVersion
        {
            get { return "1.0"; }
        }


        //public static String AccessConnectionString
        //{
        //    get { return string.Format(Properties.Resources.AccConStr, strProvider, AccessLink); }
        //}

        public static String SqlConnectionString
        {
            get { return string.Format(Properties.Resources.SQLConStr, Server, Database, User, Password); }
        }

        public static String SOMSConnectionString
        {
            get { return string.Format(Properties.Resources.SQLConStr, Server_APPS1, Database_SOMS, User_APPS1, Password_APPS1); }
        }

        public static String PISConnectionString
        {
            get { return string.Format(Properties.Resources.SQLConStr, Server_APPS1, Database_PIS, User_APPS1, Password_APPS1); }
        }


        public static string PrintMonthlySchedule
        {
            get
            {
                if (File.Exists(ConfigurationManager.AppSettings["DeploymentPath64Bit"] + ConfigurationManager.AppSettings["rptMonthlySchedule"]))
                {
                    return ConfigurationManager.AppSettings["DeploymentPath64Bit"] + ConfigurationManager.AppSettings["rptMonthlySchedule"];
                }
                else if (File.Exists(ConfigurationManager.AppSettings["DeploymentPath32Bit"] + ConfigurationManager.AppSettings["rptMonthlySchedule"]))
                {
                    return ConfigurationManager.AppSettings["DeploymentPath32Bit"] + ConfigurationManager.AppSettings["rptMonthlySchedule"];
                }
                else
                {
                    return di.FullName + ConfigurationManager.AppSettings["rptMonthlySchedule"];
                }
            }
        }
    }
}
