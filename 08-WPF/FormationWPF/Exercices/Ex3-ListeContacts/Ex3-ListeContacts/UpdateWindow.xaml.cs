using Ex3_ListeContacts.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Ex3_ListeContacts
{
    /// <summary>
    /// Logique d'interaction pour UpdateWindow.xaml
    /// </summary>
    public partial class UpdateWindow : Window
    {
        Person _person;
        Contact _contact;
        Address _address;

        private ObservableCollection<Contact> _contactList;

        public UpdateWindow()
        {
            InitializeComponent();
            DisplayContact();
        }

        private void RechercherContact_Click(object sender, RoutedEventArgs e)
        {
            DisplayContact();
            int IdAModifier = int.Parse(TextBoxRechercher.Text);
            Contact _contact = new();
            Person _person = new Person();
            Address _address = new Address();

            foreach (var c in _contactList)
            {
                if (c.Id == IdAModifier)
                {
                    TextBoxNom.Text = c.Lastname;
                    TextBoxPrenom.Text = c.Firstname;
                    SelectDateDeNaissance.SelectedDate = c.DateOfBirth;
                    TextBoxTelephone.Text = c.PhoneNumber;
                    TextBoxEmail.Text = c.Email;
                    TextBoxNumero.Text = Convert.ToString(c.ContactAddress.Number);
                    TextBoxRue.Text = c.ContactAddress.RoadName;
                    TextBoxCodePostal.Text = Convert.ToString(c.ContactAddress.PostalCode);
                    TextBoxVille.Text = c.ContactAddress.Town;
                    TextBoxPays.Text = c.ContactAddress.Country;
                }
            }
        }
        private void ValiderModifs_click(object sender, RoutedEventArgs e)
        {
            _person = new Person();
            _contact = new Contact();
            _address = new Address();

            Address newAdress = new Address(int.Parse(TextBoxNumero.Text), TextBoxRue.Text, int.Parse(TextBoxCodePostal.Text), TextBoxVille.Text, TextBoxPays.Text);

            Contact newContact = new Contact(TextBoxNom.Text, TextBoxPrenom.Text, Convert.ToDateTime(SelectDateDeNaissance.Text), newAdress, TextBoxTelephone.Text, TextBoxEmail.Text);

            //newAdress.Update(_address.Number = int.Parse(TextBoxNumero.Text), _address.RoadName = TextBoxRue.Text, _address.PostalCode = int.Parse(TextBoxCodePostal.Text), _address.Town = TextBoxVille.Text, _address.Country = TextBoxPays.Text, _address.AddressId = _address.AddressId);
            
            newAdress.Update();

            newContact.Update();

            ResetInputs();
            DisplayContact();
        }

        private void DisplayContact()
        {
            _contactList = Contact.GetAll();
            ListeBoxContact.ItemsSource = _contactList;
        }

        private void ResetInputs()
        {
            TextBoxNom.Clear();
            TextBoxPrenom.Clear();
            SelectDateDeNaissance.SelectedDate = DateTime.Now;
            TextBoxTelephone.Clear();
            TextBoxEmail.Clear();
            TextBoxNumero.Clear();
            TextBoxRue.Clear();
            TextBoxCodePostal.Clear();
            TextBoxVille.Clear();
            TextBoxPays.Clear();
        }

    }
}
