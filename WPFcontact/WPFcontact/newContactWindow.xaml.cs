using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using SQLite;

namespace WPFcontact
{
    /// <summary>
    /// Interaction logic for newContactWindow.xaml
    /// </summary>
    public partial class newContactWindow : Window
    {

        public newContactWindow()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            Contact contact = new Contact()
            {
                Name = nameTextBox.Text,
                Email = emailTextBox.Text,
                Phone = phoneNumberTextBox.Text
            };
            using (SQLiteConnection connection = new SQLiteConnection(App.dbPath))
            {
                connection.CreateTable<Contact>();
                connection.Insert(contact);
            }
            Close();
        }

        private void Grid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Close();
        }
    }
}
