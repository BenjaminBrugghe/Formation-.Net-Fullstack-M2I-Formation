using Ex2_LePendu.Classes;
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

namespace Ex2_LePendu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LePendu _pendu;

        public MainWindow()
        {
            InitializeComponent();
            Start();
        }

        private void Start()
        {
            _pendu = new LePendu();
            Ligne1.Text = $"Mot à trouver : {_pendu.Masque} - Essais restants : {_pendu.NbEssai}";
            userLetter.Focus();
            ValidBtn.IsEnabled = true;
            userLetter.KeyDown += Valider_click_key;
        }

        private void Valider_click(object sender, RoutedEventArgs e)
        {
            if (_pendu.NbEssai > 1)
            {
                if (_pendu.TestChar(Convert.ToChar(userLetter.Text)))
                {
                    _pendu.TestWin();
                }
                else
                {
                    Update_Image();
                }

                Ligne1.Text = $"Mot à trouver : {_pendu.Masque} - Essais restants : {_pendu.NbEssai}";

                userLetter.Clear();
                userLetter.Focus();

                if (_pendu.NbEssai > 0 && _pendu.MotATrouver == _pendu.Masque)
                {
                    Ligne1.Text = "Félicitations ! Vous avez trouvé le mot mystère !";
                    ValidBtn.IsEnabled = false;
                    userLetter.KeyDown -= Valider_click_key;
                }
            }
            else
            {
                userLetter.Clear();
                Ligne1.Text = $"Perdu ! Le mot à trouver était : {_pendu.MotATrouver}";
                ImagePendu.Source = new BitmapImage(new Uri(@"/img/pendu-11.jpg", UriKind.Relative));
            }
        }

        private void Valider_click_key(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Valider_click(sender, e);
            }
        }

        private void Update_Image()
        {
            switch (_pendu.NbEssai)
            {
                case 10:
                    ImagePendu.Source = new BitmapImage(new Uri(@"/img/pendu-1.jpg", UriKind.Relative));
                    break;
                case 9:
                    ImagePendu.Source = new BitmapImage(new Uri(@"/img/pendu-2.jpg", UriKind.Relative));
                    break;
                case 8:
                    ImagePendu.Source = new BitmapImage(new Uri(@"/img/pendu-3.jpg", UriKind.Relative));
                    break;
                case 7:
                    ImagePendu.Source = new BitmapImage(new Uri(@"/img/pendu-4.jpg", UriKind.Relative));
                    break;
                case 6:
                    ImagePendu.Source = new BitmapImage(new Uri(@"/img/pendu-5.jpg", UriKind.Relative));
                    break;
                case 5:
                    ImagePendu.Source = new BitmapImage(new Uri(@"/img/pendu-6.jpg", UriKind.Relative));
                    break;
                case 4:
                    ImagePendu.Source = new BitmapImage(new Uri(@"/img/pendu-7.jpg", UriKind.Relative));
                    break;
                case 3:
                    ImagePendu.Source = new BitmapImage(new Uri(@"/img/pendu-8.jpg", UriKind.Relative));
                    break;
                case 2:
                    ImagePendu.Source = new BitmapImage(new Uri(@"/img/pendu-9.jpg", UriKind.Relative));
                    break;
                case 1:
                    ImagePendu.Source = new BitmapImage(new Uri(@"/img/pendu-10.jpg", UriKind.Relative));
                    break;
                case 0:
                    ImagePendu.Source = new BitmapImage(new Uri(@"/img/pendu-11.jpg", UriKind.Relative));
                    break;
                default:
                    break;
            }
        }
    }
}
