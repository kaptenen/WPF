using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFcontact
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Contact> contacts;
        public List<Contact> ItemsSource { get; internal set; }


        public MainWindow()
        {
            InitializeComponent();
            contacts = new List<Contact>();
            ReadDb();
        }

        private void NewContactButton_Click(object sender, RoutedEventArgs e)
        {
            newContactWindow newContactWindow = new newContactWindow();
            newContactWindow.ShowDialog();
            ReadDb();
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox searchTextBox = sender as TextBox;
            var filterList = contacts.Where(x => x.Name.ToLower().Contains(searchTextBox.Text.ToLower())).ToList();

            contactListView.ItemsSource = filterList;
        }

        public void ReadDb()
        {
            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.dbPath))
            {
                conn.CreateTable<Contact>();
                contacts = conn.Table<Contact>().ToList().OrderBy(x => x.Name).ToList();
            }

            if (contacts != null)
            {
                contactListView.ItemsSource = null;
                contactListView.ItemsSource = contacts;
            }
        }

        private void contactListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Contact selectedContact = (Contact)contactListView.SelectedItem;

            if (selectedContact != null)
            {
                ContactUpdateWindow contactUpdateWindow = new ContactUpdateWindow(selectedContact);
                contactUpdateWindow.ShowDialog();

                if (contactUpdateWindow.Action == "Delete")
                {
                    DeletedContact(selectedContact);
                }
            }
        }

        private void DeletedContact(Contact selectedContact)
        {
            contacts.Remove(selectedContact);
            contactListView.ItemsSource = null;
            contactListView.ItemsSource = contacts;
        }
    }
}
