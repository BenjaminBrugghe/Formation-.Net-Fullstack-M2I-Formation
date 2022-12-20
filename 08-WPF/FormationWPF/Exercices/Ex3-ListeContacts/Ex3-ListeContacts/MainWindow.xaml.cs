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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ex3_ListeContacts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person _person;
        Contact _contact;
        Address _address;

        private ObservableCollection<Contact> _contactList;

        public MainWindow()
        {
            InitializeComponent();
            DisplayContact();
        }

        private void AjouterPersonne_Click(object sender, RoutedEventArgs e)
        {
            _person = new Person();
            _contact = new Contact();
            _address = new Address();

            //Person newPerson = new Person(TextBoxNom.Text, TextBoxPrenom.Text,Convert.ToDateTime(TextBoxDateDeNaissance.Text));

            Address newAdress = new Address(int.Parse(TextBoxNumero.Text), TextBoxRue.Text, int.Parse(TextBoxCodePostal.Text), TextBoxVille.Text, TextBoxPays.Text);

            Contact newContact = new Contact(TextBoxNom.Text, TextBoxPrenom.Text, Convert.ToDateTime(SelectDateDeNaissance.Text), newAdress, TextBoxTelephone.Text, TextBoxEmail.Text);

            //newAdress.Add();

            newContact.Add();

            ResetInputs();
            DisplayContact();

            MessageBox.Show("Contact ajouté avec succès !", "Succès de l'ajout", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }

        private void ModifierContactClick(object sender, RoutedEventArgs e)
        {
            UpdateWindow u = new();
            u.Show();
        }

        private void SupprimerContactClick(object sender, RoutedEventArgs e)
        {
            DeleteWindow d = new();
            d.Show();

        }

        private void DetailsClick(object sender, RoutedEventArgs e)
        {

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
