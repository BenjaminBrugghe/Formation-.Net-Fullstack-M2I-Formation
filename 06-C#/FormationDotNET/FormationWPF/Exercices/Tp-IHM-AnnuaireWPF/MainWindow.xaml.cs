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
using Tp_IHM_AnnuaireWPF.Classes;
//using TpListContactClassAdoNET.Classes;

namespace Tp_IHM_AnnuaireWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ApplicationDbContext _context = new();

        public MainWindow()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            Contact c = new();
        }

        private void ValiderBtn_Click(object sender, RoutedEventArgs e)
        {
            if (nomTextBox.Text != "" && prenomTextBox.Text != "" && ageTextBox.Text != "")
            {
                string nom = nomTextBox.Text;
                string prenom = prenomTextBox.Text;
                int age = Convert.ToInt32(ageTextBox.Text);

                Contact c = new(nomTextBox.Text, prenomTextBox.Text, int.Parse(ageTextBox.Text));

                AffichageTextBlock.Text += c.ToString();

                nomTextBox.Clear();
                prenomTextBox.Clear();
                ageTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Veuillez renseigner tout les champs", "Alert", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
    }
}
