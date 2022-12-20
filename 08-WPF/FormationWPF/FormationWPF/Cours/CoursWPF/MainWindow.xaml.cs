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

namespace CoursWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MakeBtn();
        }
        // Création d'objets depuis le code Behind
        void MakeBtn()
        {
            Button button1 = new Button()
            {
                Content = "Sources",
                Foreground = Brushes.Tomato,
                Background = Brushes.Black
            };
            button1.Click += ClickBtn;
            grid.Children.Add(button1);
        }
        // Methode activée par le click du Button ValiderBtn
        private void ValiderBtn_Click(object sender, RoutedEventArgs e)
        {
            if (NomTbox.Text != "" && PrenomTBox.Text != "")
            {
                string nom = NomTbox.Text;
                string prenom = PrenomTBox.Text;
                ResultTB.Text += $"Nom : {nom} - Prénom :{prenom}";
            }
            else
                MessageBox.Show("Veuillez saisir les champs nom et prénom", "Alert", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }
        
        private void SourceBtn_Click(object sender, RoutedEventArgs e)
        {
            //object o = sender;
            //MessageBox.Show(e.OriginalSource.ToString());
            //MessageBox.Show(sender.ToString());

            ResultTB.Text += $"{e.OriginalSource.ToString()}  \n" +
                $"{sender.ToString()}";
        }
        private void ClickBtn(object sender, RoutedEventArgs e)
        {
            MessageBoxResult message = MessageBox.Show("Etes-vous sur?","Question", MessageBoxButton.YesNoCancel,MessageBoxImage.Question );

            switch (message)
            {
                case MessageBoxResult.None:
                    ResultTB.Text += message.ToString();
                    break;
                case MessageBoxResult.OK:
                    ResultTB.Text += message.ToString();
                    break;
                case MessageBoxResult.Cancel:
                    ResultTB.Text += message.ToString();
                    break;
                case MessageBoxResult.Yes:
                    ResultTB.Text += message.ToString();
                    break;
                case MessageBoxResult.No:
                    ResultTB.Text += message.ToString();
                    break;
            }            
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void GridWindow_Click(object sender, RoutedEventArgs e)
        {
            GridWindow g = new();
            g.Show();
        }

        private void DockPanel_Click(object sender, RoutedEventArgs e)
        {
            DockPanel d = new();
            d.Show();
        }

        private void UniformGrid_Click(object sender, RoutedEventArgs e)
        {
            UniformGridWindow u = new();
            u.Show();
        }

        private void ListView_Click(object sender, RoutedEventArgs e)
        {
            ListViewWindow l = new();
            l.Show();
        }
    }
}
