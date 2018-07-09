using DesktopContactsApp.Classes;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace DesktopContactsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ReadDatabase();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NewContactWindow newContact = new NewContactWindow();
            //newContact.Show();
            newContact.ShowDialog();

            ReadDatabase();
        }

        void ReadDatabase()
        {
            List<Contact> contacts;
            using (SQLiteConnection conn = new SQLiteConnection(App.databasePath))
            {
                conn.CreateTable<Contact>();
                contacts = conn.Table<Contact>().ToList();
            }

            if (contacts != null)
            {
                //foreach (var c in contacts)
                //{
                //    ContactsListView.Items.Add(new ListViewItem()
                //    {
                //        Content = c
                //    });
                //}
                ContactsListView.ItemsSource = contacts;
            }
        }
    }
}
