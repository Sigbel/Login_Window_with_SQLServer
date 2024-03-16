using Login_Window_with_SQLServer.forms;
using System;
using System.Data.SqlClient;

namespace Login_Window_with_SQLServer {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            DataInit.Initialize();

            Application.Run(new FrmLogin());
        }
    }
}