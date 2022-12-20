namespace CoursAPI.Models
{
    public class Personne
    {
        private int id;
        private string nom;
        private string prenom;
        private string email;
        private string telephone;

        public Personne()
        {

        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Email { get => email; set => email = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public int Id { get => id; set => id = value; }
    }
}
