﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
   public static  class AppSettings
    {
        public static string ConnectionString()
        {
            string conString = "Server=localhost;Database=testvc;Uid=root;Pwd=''";
            return conString;

        }
    }
}
