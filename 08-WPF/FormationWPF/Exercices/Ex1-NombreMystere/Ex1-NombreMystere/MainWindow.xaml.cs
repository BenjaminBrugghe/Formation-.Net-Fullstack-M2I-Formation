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

namespace Ex1_NombreMystere
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random aleatoire = new Random();
        //int nbUser;
        int nbMystere;
        int nbCoups;

        public MainWindow()
        {
            InitializeComponent();
            Start();
        }

        private void Start()
        {
            userNumber.Focus();
            nombreCoups.Text = "";
            nbMystere = aleatoire.Next(1, 51);
            nbCoups = 0;
            Ligne1.Text = "";
            Ligne2.Text = "Veuillez saisir un chiffre/nombre";
        }

        private void Valider_click(object sender, RoutedEventArgs e)
        {

            bool isANumber = int.TryParse(userNumber.Text, out int number);

            if (isANumber)
            {
                nbCoups++;

                if (Convert.ToInt32(userNumber.Text) > nbMystere)
                {
                    Ligne1.Text = "Le nombre est plus petit !";
                }
                else if (Convert.ToInt32(userNumber.Text) < nbMystere)
                {
                    Ligne1.Text = "Le nombre est plus grand !";
                }
                else
                {
                    Ligne1.Text = $"Bravo ! Vous avez trouvé en {nbCoups} coups !";
                    Ligne2.Text = $"Le nombre mystère était {nbMystere}";
                    ValiderBtn.IsEnabled = false;
                }

                nombreCoups.Text = $"{nbCoups}";
                userNumber.Clear();
                userNumber.Focus();
            }
            else
            {
                Ligne1.Text = "ERREUR ! Saisie non valide";
                userNumber.Clear();
                userNumber.Focus();
            }
        }

        private void Restart_click(object sender, RoutedEventArgs e)
        {
            Start();
        }

        private void Valider_click_key(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Valider_click(sender, e);
            }
        }
    }
}
