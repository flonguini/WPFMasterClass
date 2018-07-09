using DesktopContactsApp.Classes;
using System;
using System.Windows;
using System.Windows.Controls;

namespace DesktopContactsApp.Controls
{
    /// <summary>
    /// Interaction logic for ContactControl.xaml
    /// </summary>
    public partial class ContactControl : UserControl
    {



        public Contact Contact
        {
            get { return (Contact)GetValue(ContactProperty); }
            set { SetValue(ContactProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Contact.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ContactProperty =
            DependencyProperty.Register("Contact", typeof(Contact), typeof(ContactControl), new PropertyMetadata(null, SetText)); //SetText irá definir os valores de cada propriedade e é executado a cada mudança de valor

        private static void SetText(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ContactControl control = d as ContactControl;

            if (control != null)
            {
                control.nameTextBlock.Text = (e.NewValue as Contact).Name;
                control.emailTextBlock.Text = (e.NewValue as Contact).Email;
                control.celphoneTextBlock.Text = (e.NewValue as Contact).Phonenumber;
            }
        }


        //private Contact _contact;

        //public Contact Contact
        //{
        //    get { return _contact; }
        //    set
        //    {
        //        _contact = value;
        //        nameTextBlock.Text = _contact.Name;
        //        emailTextBlock.Text = _contact.Email;
        //        celphoneTextBlock.Text = _contact.Phonenumber;
        //    }
        //}

        public ContactControl()
        {
            InitializeComponent();
        }
    }
}
