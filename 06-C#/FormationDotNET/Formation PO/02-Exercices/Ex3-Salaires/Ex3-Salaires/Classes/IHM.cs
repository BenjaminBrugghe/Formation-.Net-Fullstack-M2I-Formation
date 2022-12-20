using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_Salaires.Classes
{
    public class IHM
    {
        Salarie[] employees;
        int maxEmployees = 20;

        public IHM()
        {
            employees = new Salarie[maxEmployees];
            Salarie Toto = new Salarie("M001", "C001", "S001", "Toto", 1200);
            Salarie Titi = new Commercial("M002", "C002", "S002", "Titi", 1000, 30000, 3);
            employees[0] = Toto;
            employees[1] = Titi;
        }


        public void Start()
        {
            string choix = "";
            do
            {
                bool valid = false;
                Console.Clear();
                Console.WriteLine("===== Gestion des Employés =====");
                MenuPrincipal();
                Console.WriteLine("Veuillez faire votre choix :");
                choix = Console.ReadLine();
                while (valid)
                {
                    if (choix == "1" && choix == "2" && choix == "3" && choix == "0")
                        valid = true;
                    else
                    {
                        OnRed("Erreur de saisie, entrez votre choix");
                        choix = Console.ReadLine();
                    }
                }

                switch (choix)
                {
                    case "1":
                        Console.Clear();
                        CreationEmploye();
                        break;
                    case "2":
                        Console.Clear();
                        SalaireEmploye();
                        break;
                    case "3":
                        Console.Clear();
                        RechercherEmploye();
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;

                }


            } while (choix != "0");



        }

        private void MenuPrincipal()
        {
            Console.WriteLine("1-- Ajouter un employé ");
            Console.WriteLine("2-- Afficher le salaire des employés");
            Console.WriteLine("3-- Rechercher un employé");
            Console.WriteLine("0-- Quitter\n");
        }

        private void MenuCreationEmploye()
        {
            Console.WriteLine("=== Ajouter un employé ===");
            Console.WriteLine("1-- Salarié");
            Console.WriteLine("2-- Commerciale");
            Console.WriteLine("0-- Retour\n");
        }

        private void OnRed(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private void CreationEmploye()
        {
            bool valid = false;
            MenuCreationEmploye();
            Console.WriteLine("Veuillez faire votre choix :");
            string choix = Console.ReadLine();
            while (valid)
            {
                if (choix == "1" && choix == "2" && choix == "0")
                    valid = true;
                else
                {
                    OnRed("Erreur de saisie, entrez votre choix");
                    choix = Console.ReadLine();
                }
            }

            Salarie s = null;

            switch (choix)
            {
                case "1":
                    s = CreationSalarie();
                    Console.WriteLine("Le salarié à été crée");
                    break;
                case "2":
                    s = CreationCommercial();
                    Console.WriteLine("Le commercial à été crée");
                    break;
                case "0":
                    break;
            }

            if (s != null)
            {
                for (int i = 0; i < employees.Length; i++)
                {
                    if (employees[i] == null)
                    {
                        employees[i] = s;
                        break;
                    }

                }
            }

            Console.Clear();
        }

        private Salarie CreationSalarie()
        {
            Console.Write("Merci de saisir le nom : ");
            string nom = Console.ReadLine();
            Console.Write("Merci de saisir le matricule : ");
            string mat = Console.ReadLine();
            Console.Write("Merci de saisir la categorie: ");
            string cat = Console.ReadLine();
            Console.Write("Merci de saisir le service : ");
            string service = Console.ReadLine();
            Console.Write("Merci de saisir le salaire: ");
            decimal salaire = Convert.ToDecimal(Console.ReadLine());

            return new Salarie(mat, cat, service, nom, salaire);
        }

        private Commercial CreationCommercial()
        {
            Salarie tmp = CreationSalarie();
            Console.Write("Merci de saisir le chiffre d'affaire du commerciale : ");
            decimal chiffreAffaire = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Merci de saisir la commission : ");
            int commission = Convert.ToInt32(Console.ReadLine());
            return new Commercial(tmp.Matricule, tmp.Categorie, tmp.Service, tmp.Nom, tmp.Salaire, chiffreAffaire, commission);
        }


        private void SalaireEmploye()
        {
            Console.WriteLine("===== Salaire des employés =====");
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] != null)
                {
                    Console.WriteLine("----------------------");
                    Console.WriteLine(employees[i].GetType());
                    Console.WriteLine(employees[i]);

                    if (employees[i] is Commercial c)
                        c.AfficherCommercial();

                    employees[i].CalculerSalaire();

                    Console.WriteLine("----------------------");
                }
            }
            WaitUser();
        }
        private void RechercherEmploye()
        {
            Console.WriteLine("===== Rechercher un salarié par nom =====");
            Console.Write("Veuillez saisir le nom : ");
            string nom = Console.ReadLine();
            Salarie s = null;
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] != null)
                {
                    if (employees[i].Nom == nom)
                    {
                        s = employees[i];
                        break;
                    }
                }
            }
            if (s != null)
                s.CalculerSalaire();
            else
                Console.WriteLine("Aucun employé avec ce nom...");

            WaitUser();
        }

        private void WaitUser()
        {
            Console.WriteLine("Appuyez sur ENTER pour retourner au menu principal...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
