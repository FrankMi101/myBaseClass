﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDapper
{
    /*  ********************************************************************************
    *   This class get acture database connection string from application Web config file
    *   <connectionStrings>
    *       <add name="currentDB" connectionString="Live" />
    *       <add name="Live" connectionString="ADLUmPaQbfqtdQ8cx0uZp9ciopJqKTDflAnKjQhg3b+60NQrlg4uE5iKV7upf9dt0u2jQBwainfyUGrML1jomZLEIZ1wCoZdd5ZRi+rpmGFFZcg3CczTvu2dcqj4DreoDlb7e/cZMaruk3716nUr9YkXjffhg/z+" />
    *       <add name="AzureDb" connectionString="ADLUmPaQbfonas6izYDnBmItcfUE98wpamCszJNF4buz1qFcYSYBZviFWhraD5cIJD8VnQZRHPADJGPsopFBIV6aibZFzukqqz7b5kPavMm6/6XlUUk3kj7yJCXnyBjSi4zaznvx6VThuBMXbOtNeDtl9osYtkm0WlW6i8vR3Qk=" />
    *    </connectionStrings>
    *   The class have few methods to get a connection string        
    *   Author : Frank Mi     
    *   Version: 1.0.0.1    Date: 2020/01/01                         
    *            1.0.1.0    Date: 2021/05/01  encryption connection string method 
    ********************************************************************************/
    public static class DBConnectionHelper
    {

        public static string ConnectionSTR()
        {
            string currentDB = ConfigurationManager.ConnectionStrings["currentDB"].ConnectionString;
            return ConnectionSTR(currentDB);
        }
        public static string ConnectionSTR(string name)
        {   // if connecttion string did not encryption. will return connection string value  
            if (name.Substring(0, 12) == "Data Source=")
                return name;
            else
            {   
                // decrypted encrypted connection string by using SymtricEncryption class,  
                string conStr = ConfigurationManager.ConnectionStrings[name].ConnectionString;
                return GetConnStr(conStr);
            }

        }
        private static string GetConnStr(string conStr)
        {
            if (conStr.Substring(0, 12) == "Data Source=")
                return conStr;
            else
                return SymetricEncryption.GetDecryptedValue(conStr);
        }
    }

}