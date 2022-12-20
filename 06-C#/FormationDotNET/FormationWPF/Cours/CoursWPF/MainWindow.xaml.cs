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

        void MakeBtn()
        {
            Button button1 = new Button()
            {
                Content = "Click me !",
                Foreground = Brushes.Tomato,
                Background = Brushes.Black
            };
            button1.Click += ClickBtn;
            grid.Children.Add(button1);
        }

        private void ValiderBtn_Click(object sender, RoutedEventArgs e)
        {
            if (nomTextBox.Text != "" && prenomTextBox.Text != "")
            {
                string nom = nomTextBox.Text;
                string prenom = prenomTextBox.Text;
                ResultTextBlock.Text += $"Nom : {nom} - Prénom : {prenom}";
            }
            else
            {
                MessageBox.Show("Veuillez renseigner tout les champs", "Alert", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void SourceBtn_Click(object sender, RoutedEventArgs e)
        {
            object o = sender;
            MessageBox.Show(e.OriginalSource.ToString());
            MessageBox.Show(o.ToString());

            ResultTextBlock.Text += e.OriginalSource.ToString();
            ResultTextBlock.Text += o.ToString();
        }

        private void ClickBtn(object sender, RoutedEventArgs e)
        {
            MessageBoxResult message = MessageBox.Show("Etes-vous sûr ?", "Question", MessageBoxButton.YesNoCancel, MessageBoxImage.Asterisk);
            // (Message, Titre de la fenêtre, type de bouton, image/icone)

            switch (message)
            {
                case MessageBoxResult.None:
                    MessageBox.Show(message.ToString());
                    break;

                case MessageBoxResult.OK:
                    MessageBox.Show(message.ToString());
                    break;

                case MessageBoxResult.Cancel:
                    MessageBox.Show(message.ToString());
                    break;

                case MessageBoxResult.Yes:
                    MessageBox.Show(message.ToString());
                    break;

                case MessageBoxResult.No:
                    MessageBox.Show(message.ToString());
                    break;

                default:
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

        private void DocPanel_Click(object sender, RoutedEventArgs e)
        {
            DocPanel d = new();
            d.Show();
        }
    }
}
