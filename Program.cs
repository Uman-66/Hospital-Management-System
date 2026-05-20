using System;
using System.Windows.Forms;
using Hospital_Management.Databases;

namespace Hospital_Management
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            DatabaseHelper.InitializeDatabase();
            Application.Run(new Forms.loginform());
        }
    }
}