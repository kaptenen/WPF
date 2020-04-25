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
        public Contact Contact { get; set; }
        public string Action { get; set; }
        public ContactUpdateWindow(Contact contact)
        {
            InitializeComponent();
            this.Contact = contact;

            Action = null;

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
                    connection.Delete(Contact);
                }
                Action = "Delete";
                Close();
            }
            Close();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            Contact.Name = nameTextBox.Text;
            Contact.Email = emailTextBox.Text;
            Contact.Phone = phoneNumberTextBox.Text;

            using (SQLiteConnection connection = new SQLiteConnection(App.dbPath))
            {
                connection.CreateTable<Contact>();
                connection.Update(Contact);
            }

            Close();
        }

        private void Copy_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;



            

            if (button == nameCopy)
            {
                Clipboard.SetText(nameTextBox.Text);
            }
            if (button == emailCopy)
            {
                Clipboard.SetText(emailTextBox.Text);
            }
            if (button == phoneCopy)
            {
                Clipboard.SetText(phoneNumberTextBox.Text);
            }


        }
    }
}
