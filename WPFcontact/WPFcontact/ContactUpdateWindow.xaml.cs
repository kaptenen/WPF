using SQLite;
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

namespace WPFcontact
{
    /// <summary>
    /// Interaction logic for ContactUpdateWindow.xaml
    /// </summary>
    public partial class ContactUpdateWindow : Window
    {
        private readonly Contact _contact;

        public ContactUpdateWindow(Contact contact)
        {
            InitializeComponent();
            this._contact = contact;

            nameTextBox.Text = contact.Name;
            emailTextBox.Text = contact.Email;
            phoneNumberTextBox.Text = contact.Phone;
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Do you want to delete this contact?", "Contact delete", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                using (SQLiteConnection connection = new SQLiteConnection(App.dbPath))
                {
                    connection.Delete(_contact);
                }
                Close();
            }
            Close();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            _contact.Name = nameTextBox.Text;
            _contact.Email = emailTextBox.Text;
            _contact.Phone = phoneNumberTextBox.Text;

            using (SQLiteConnection connection = new SQLiteConnection(App.dbPath))
            {
                connection.CreateTable<Contact>();
                connection.Update(_contact);
            }

            Close();
        }
    }
}
