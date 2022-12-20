using IHMAnnuaireWPF.Models;
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
//using TpListContactClassAdoNET.Classes;

namespace IHMAnnuaireWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Init();
        }

        private void Init()
        {
            Contact c = new();
        }

        private void AjouterBtn_Click(object sender, RoutedEventArgs e)
        {
            if (NomTbox.Text != "" && PrenomTbox.Text !="" && TelephoneTbox.Text !="" && EmailTbox.Text !="" && AgeTbox.Text !="")
            {
                Contact c = new (NomTbox.Text, PrenomTbox.Text, TelephoneTbox.Text, EmailTbox.Text, int.Parse(AgeTbox.Text));
                AffichageTBlock.Text += c.ToString();
                ResetInput();
            }
            else
            {
                MessageBox.Show("Erreur, veuillez remplir tout les champs!", "Erreur lors de l'ajout", MessageBoxButton.OK, MessageBoxImage.Stop);
            }

        }

        private void ResetInput()
        {
            NomTbox.Text = "";
            PrenomTbox.Text = "";
            TelephoneTbox.Text = "";
            EmailTbox.Text = "";
            AgeTbox.Text = "";
        }
    }
}
