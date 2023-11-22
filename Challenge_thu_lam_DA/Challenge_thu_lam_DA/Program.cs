﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using Challenge_thu_lam_DA.Model;

namespace Challenge_thu_lam_DA
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            User user= new User();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDashboard(user));
        }
        public static string CaculateMD5(string input)
        {
            MD5 md5=System.Security.Cryptography.MD5.Create();
            byte[] inputBytes=System.Text.Encoding.UTF8.GetBytes(input);
            byte[] hash =md5.ComputeHash(inputBytes);

            //step2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++) {
                sb.Append(hash[i].ToString("X2"));
                    }
            return sb.ToString();   
        }

    }
}
