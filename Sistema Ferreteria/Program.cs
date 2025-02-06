using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.Xpo.DB;
using DevExpress.Xpo;
using Sistema_Ferreteria.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Sistema_Ferreteria.Formularios;

namespace Sistema_Ferreteria
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Devexpress Settings
            XpoDefault.DataLayer = XpoDefault.GetDataLayer(
                 ConnectionHelper.ConnectionString,
                 AutoCreateOption.DatabaseAndSchema);

            //Aplication Settings
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new PaginaPrincipal());
            Application.Run(new frmVentas());
        }
    }
}
