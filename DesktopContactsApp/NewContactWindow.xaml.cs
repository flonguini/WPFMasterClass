using DesktopContactsApp.Classes;
using SQLite;
using System;
using System.Windows;

namespace DesktopContactsApp
{
    /// <summary>
    /// Interaction logic for NewContactWindow.xaml
    /// </summary>
    public partial class NewContactWindow : Window
    {
        public NewContactWindow()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            //TODO: Save contact
            Contact contact = new Contact()
            {
                Name = nameTextBox.Text,
                Email = emailTextBox.Text,
                Phonenumber = phoneNumberTextBox.Text
            };

            

            using (var connection = new SQLiteConnection(App.databasePath)) // Objeto precisa implementar IDisposable Interface
            {
                connection.CreateTable<Contact>(); //Cria a tabela de contatos
                connection.Insert(contact);
            }

            this.Close();
        }
    }
}
