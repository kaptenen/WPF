using System;
using System.Windows;

namespace WPFcontact
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static string dbName = "Contacts.db";
        static string dbFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static string dbPath = System.IO.Path.Combine(dbFolder, dbName);
    }
}
