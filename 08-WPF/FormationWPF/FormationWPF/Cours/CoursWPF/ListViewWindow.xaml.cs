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

namespace CoursWPF
{
    /// <summary>
    /// Logique d'interaction pour ListViewWindow.xaml
    /// </summary>
    public partial class ListViewWindow : Window
    {
        //private ObservableCollection<Contact> _contactList;

        public ListViewWindow()
        {
            InitializeComponent();
            //DisplayContact();
        }

        private void DisplayContact()
        {
            //_contactList = Contact.GetAll();
            //ListeBoxContact.ItemsSource = _contactList;
        }

        private void AjouterPersonne_Click(object sender, RoutedEventArgs e)
        {
            //if (ListeBoxContact.SelectedItem is Contact c)
            //{
            //    MessageBox.Show(c.ToString());
            //}
        }
    }
}
