using Ex5_TpBanque.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Ex5_TpCompte.Classes
{
    internal class IHM
    {

        Banque bank;

        public IHM()
        {
            Init();
        }
        private void Init()
        {
            bank = new();
            bank.Comptes = bank.Injecter();
            for (int i = 0; i < bank.Comptes.Count; i++)
                bank.Comptes[i].ADecouvert += ActionNotificationADecouvert;
        }

        public void Start()
        {
            string choix = "-1";
            do
            {
                string pattern = @"^[0-5]{1}$";
                Menu();
                TryRead("\n Faites votre choix => ", () => choix = Console.ReadLine());
                while (!Regex.IsMatch(choix, pattern))
                {
                    OnDarkCyanInput("Merci de saisir 0,1,2,3,4 ou 5 : ");
                    choix = Console.ReadLine();
                }

                Console.Clear();

                switch (choix)
                {
                    case "1":
                        ActionCreationCompte();
                        break;
                    case "2":
                        ActionDepot();
                        break;
                    case "3":
                        ActionRetrait();
                        break;
                    case "4":
                        ActionAfficherCompte();
                        break;
                    case "5":
                        ActionCalculInterets();
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                }

            } while (choix != "0");
        }

        private void TryRead(string message, Action ReadElement)
        {
            bool valid = false;
            do
            {
                OnCyanInput(message);
                try
                {
                    ReadElement();
                    valid = true;
                }
                catch (Exception e)
                {
                    OnRed(e.Message);
                }
            } while (!valid);
        }

        private void Title()
        {
            OnDarkCyan("\n------------------- Banque Peu populaire -------------------");
        }

        private void Menu()
        {
            Title();

            OnDarkCyan("\n     ------------ MenuPrincipal ------------\n");
            Console.WriteLine("\t1- Créer un compte bancaire" +
                                "\n\t2- Effectuer un dépôt" +
                                "\n\t3- Effectuer un retrait" +
                                "\n\t4- Opérations et solde" +
                                "\n\t5- Calcul des Interêts");
            OnRed("\n\t0-- Quitter\n");
        }

        private void ActionCreationCompte()
        {
            Title();
            OnDarkCyan("\n------------------- Création Compte -------------------");
            OnDarkCyan("\n------------------- Création Client -------------------");
            Client c = new();
            TryRead("\nVeuillez saisir le nom : ", () => c.Nom = Console.ReadLine());
            TryRead("Veuillez saisir le prénom : ", () => c.Prenom = Console.ReadLine());
            TryRead("Veuillez saisir le téléphone : ", () => c.Telephone = Console.ReadLine());
            OnDarkCyan("\n------------------- Création Compte -------------------");
            decimal solde = 0;
            TryRead("Solde initial : ", () => solde = Convert.ToDecimal(Console.ReadLine()));
            OnDarkCyan("\nType de compte : ");
            Console.Write("\n1- Compte normal");
            Console.Write("\n2- Compte épargne");
            Console.Write("\n3- Compte payant");
            string pattern = @"^[1-3]{1}$";
            string choix = "-1";
            TryRead("\n Faites votre choix => ", () => choix = Console.ReadLine());
            while (!Regex.IsMatch(choix, pattern))
            {
                OnDarkCyanInput("Merci de saisir 1,2 ou 3 : ");
                choix = Console.ReadLine();
            }

            Compte compte = null;
            switch (choix)
            {
                case "1":
                    compte = new Compte(solde, c);
                    break;
                case "2":
                    decimal taux = 0;
                    TryRead("Veuillez saisir le taux d'épargne du compte : ", () => taux = Convert.ToDecimal(Console.ReadLine()));
                    compte = new CompteEpargne(solde, c, taux);
                    break;
                case "3":
                    decimal coutOperation = 0;
                    TryRead("Veuillez saisir le coût de chaque opération : ", () => coutOperation = Convert.ToDecimal(Console.ReadLine()));
                    compte = new ComptePayant(solde, c, coutOperation);
                    break;
            }

            if (compte != null)
            {
                compte.ADecouvert += ActionNotificationADecouvert;
                if (bank.AjouterCompte(compte))
                    OnGreen($"Le compte à été ajouté avec l'Id N° {compte.Id}.");
                else
                    OnRed($"Erreur lors de l'ajout du compte {compte.Id}.");
            }

            WaitUser();
        }

        private void ActionDepot()
        {
            Title();
            OnDarkCyan("\n------------------- Déposer des fonds -------------------");

            Compte compte = ActionRechercheCompte();

            if (compte != null)
            {
                decimal montant;
                OnCyanInput("Merci de saisir le montant de votre dépôt : ");
                while (!decimal.TryParse(Console.ReadLine(), out montant))
                {
                    OnRed("Erreur de saisie !");
                    OnCyanInput("Merci de re-saisir le montant de votre dépôt : ");
                }
                Operation o = new(montant);
                if (compte.Depot(o))
                    OnGreen("\n\nLe dépôt à été effectué");
                else
                    OnRed("\n\nErreur lors du dépôt");

                WaitUser();
            }
        }

        private void ActionRetrait()
        {
            Title();
            OnDarkCyan("\n------------------- Retirer des fonds -------------------");

            Compte compte = ActionRechercheCompte();

            if (compte != null)
            {
                decimal montant;
                OnCyanInput("Merci de saisir le montant de votre retrait : ");
                while (!decimal.TryParse(Console.ReadLine(), out montant))
                {
                    OnRed("Erreur de saisie !");
                    OnCyanInput("Merci de re-saisir le montant de votre retrait : ");
                }
                Operation o = new(montant * -1);
                if (compte.Retrait(o))
                    OnGreen("\n\nLe retrait à été effectué");
                else
                    OnRed("\n\nErreur lors du retrait");

                WaitUser();
            }

        }

        private void ActionAfficherCompte()
        {
            Title();
            OnDarkCyan("\n------------------- Afficher un compte -------------------");
            Compte compte = ActionRechercheCompte();
            if (compte != null)
            {
                OnDarkCyanInput("\n---------------------- Compte N° ");
                Console.Write(compte.Id);
                OnDarkCyanInput(" ---------------------- \n\n Nom : ");
                Console.Write(compte.ClientBanque.Nom);
                OnDarkCyanInput($"\t Prénom : ");
                Console.WriteLine(compte.ClientBanque.Prenom);
                OnDarkCyanInput($" Téléphone : ");
                Console.WriteLine(compte.ClientBanque.Telephone);

                OnDarkCyanInput($"\n\t\t\t\tSolde : ");
                if (compte.Solde >= 0)
                    OnGreen($"{Math.Round(compte.Solde)}€");
                else
                    OnRed($"{Math.Round(compte.Solde, 2)}€");

                OnDarkCyan("\n----------------------- Opérations -----------------------\n");
                if (compte.Operations.Count > 0)
                {
                    foreach (Operation o in compte.Operations)
                    {
                        OnGrayInput($"{o.ToString()} - Montant : ");
                        if (o.Montant >= 0)
                            OnGreen($"{Math.Round(o.Montant, 2)}€");
                        else
                            OnRed($"{Math.Round(Math.Abs(o.Montant), 2)}€");
                    }
                }
                else
                    Console.WriteLine("   Aucune opération enregistrée pour ce compte...");

                OnDarkCyan("\n----------------------------------------------------------");


                WaitUser();
            }
        }

        private void ActionCalculInterets()
        {
            Title();
            OnDarkCyan("\n------------------- Calculer les intérêts -------------------");
            Compte compte = ActionRechercheCompte();

            if (compte != null && compte is CompteEpargne compteEpargne)
            {
                if (compteEpargne.CalculInterets())
                    OnGreen("\n\n Intérêts ajoutés...");
                else
                    OnRed("Erreur lors du calcul des intérêts");
            }
            else if (compte != null)
                OnRed($"Le compte N° {compte.Id} n'est pas de type Compte Epargne.");

            WaitUser();
        }

        private Compte ActionRechercheCompte()
        {
            Compte compte = null;
            int index = -1;
            TryRead("\nVeuillez saisir l'Id du compte : ", () => index = Convert.ToInt32(Console.ReadLine()));
            compte = bank.RechercherCompte(index);
            if (compte == null)
                OnRed("Aucun compte avec cet Id...");
            return compte;
        }

        private void WaitUser()
        {
            OnDarkCyan("\nAppuyez sur ENTER pour revenir au menu pricipal...");
            Console.ReadLine();
            Console.Clear();
        }

        public void ActionNotificationADecouvert(decimal solde, int compteId)
        {
            OnRed($"\n Le compte numéro {compteId} est à découvert !");
            Console.Write("\n\t\t Voici le nouveau solde : ");
            OnRed($" {solde}€");
        }

        private static void OnDarkCyan(string chaine)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(chaine);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void OnDarkCyanInput(string chaine)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(chaine);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void OnCyanInput(string chaine)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(chaine);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void OnRed(string chaine)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(chaine);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void OnGreen(string chaine)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(chaine);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void OnGrayInput(string chaine)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(chaine);
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
