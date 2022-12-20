using Ex3_ListeContacts.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace Ex3_ListeContacts
{
    /// <summary>
    /// Logique d'interaction pour DeleteWindow.xaml
    /// </summary>
    public partial class DeleteWindow : Window
    {
        Person _person;
        Contact _contact;
        Address _address;

        private ObservableCollection<Contact> _contactList;

        public DeleteWindow()
        {
            InitializeComponent();
            DisplayContact();
        }

        private void RechercherContact_Click(object sender, RoutedEventArgs e)
        {
            DisplayContact();
            int IdASupprimer = int.Parse(TextBoxRechercher.Text);
            Contact _contact = new();
            Person _person = new Person();
            Address _address = new Address();

            foreach (var c in _contactList)
            {
                if (c.Id == IdASupprimer)
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
                    TextBlockIDContact.Text = c.Id.ToString();
                }
            }
        }

        private void ValiderDelete_click(object sender, RoutedEventArgs e)
        {
            if (TextBoxNom.Text != "" && TextBoxPrenom.Text != "")
            {
                Address _address = new Address()
                {
                    Number = int.Parse(TextBoxNumero.Text),
                    RoadName = TextBoxRue.Text,
                    PostalCode = int.Parse(TextBoxCodePostal.Text),
                    Town = TextBoxVille.Text,
                    Country = TextBoxPays.Text
                };

                Contact _contact = new()
                {
                    Id = int.Parse(TextBlockIDContact.Text),
                    Lastname = TextBoxNom.Text,
                    Firstname = TextBoxPrenom.Text,
                    DateOfBirth = (DateTime)SelectDateDeNaissance.SelectedDate, // aaaa-mm-jj
                    PhoneNumber = TextBoxTelephone.Text,
                    Email = TextBoxEmail.Text,
                    ContactAddress = _address

                };
                _contact.Delete();
                ResetInputs();
            }
            else
            {
                MessageBox.Show("ERREUR ! Veuillez remplir tout les champs !");
            }
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
