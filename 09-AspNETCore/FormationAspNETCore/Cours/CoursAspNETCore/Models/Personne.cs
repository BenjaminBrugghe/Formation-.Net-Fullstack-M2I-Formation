using System.Collections.ObjectModel;

namespace CoursAspNETCore.Models
{
    public class Personne
    {
        private static int counter = 0;

        private int id;

        private string nom;

        private string prenom;

        private string email;

        private static ObservableCollection<Personne> personnes = new();

        public Personne()
        {
            Id = ++counter;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Email { get => email; set => email = value; }
        public static ObservableCollection<Personne> Personnes { get => personnes; set => personnes = value; }

        public override string ToString()
        {
            return $"Id : {Id} - Nom : {nom} - prénom : {prenom} - Email : {email}";
        }

        public static Personne Find(int index)
        {
            return Personnes[index-1];
        }

        public void Add()
        {
            Personnes.Add(this);
        }
    }
}
