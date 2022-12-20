using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_TpBanque.Classes
{
    public class Banque
    {
        private List<Compte> comptes = new();


        public Banque()
        {
            Comptes = new();
        }

        public List<Compte> Comptes { get => comptes; set => comptes = value; }

        public bool AjouterCompte(Compte c)
        {
            int nb1 = Comptes.Count;
            comptes.Add(c);
            int nb2 = Comptes.Count;
            return nb2 - nb1 == 1;
        }

        public Compte RechercherCompte(int id)
        {
            return comptes.Find(compte => compte.Id == id);
        }
        public List<Compte> Injecter()
        {
            List<Compte> compteList = new List<Compte>();
            Client client1 = new Client("Di Persio", "Anthony", "+33 6 07 08 09 10");
            Client client2 = new Client("Abadi", "Ihab", "+33 6 09 10 11 12");
            Client client3 = new Client("Abadi", "Marine", "+33 6 09 10 11 12");

            Compte c1 = new Compte(500.00M, client1);
            Operation o1 = new(350.00M);
            Operation o2 = new(-150.00M);
            Operation o3 = new(30.00M);
            c1.Depot(o1);
            c1.Retrait(o2);
            c1.Depot(o3);
            compteList.Add(c1);

            Compte c2 = new CompteEpargne(500.00M, client2, 4);
            Operation o4 = new(399.90M);
            Operation o5 = new(-50.00M);
            Operation o6 = new(35.00M);
            c2.Depot(o4);
            c2.Retrait(o5);
            c2.Depot(o6);
            compteList.Add(c2);

            Compte c3 = new ComptePayant(500.00M, client3, 2);
            Operation o7 = new(199.90M);
            Operation o8 = new(-252.20M);
            Operation o9 = new(135.00M);
            c3.Depot(o7);
            c3.Retrait(o8);
            c3.Depot(o9);
            compteList.Add(c3);

            return compteList;
        }
    }


}
