using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercice1_ListeContacts.Classes
{
    internal class Contact
    {
        public int Id { get; set; }

        [StringLength(80)]
        [Required]
        public string LastName { get; set; }

        [StringLength(80)]
        [Required]
        public string FirstName { get; set; }

        [StringLength(80)]
        [Required]
        public string BirthDate { get; set; }

        [Required]
        public int Age { get; set; }

        [StringLength(80)]
        [Required]
        public string Gender { get; set; }

        [StringLength(80)]
        [Required]
        public string PhoneNumber { get; set; }

        [StringLength(80)]
        [Required]
        public string Email { get; set; }

        public override string ToString()
        {
            return $"{Id}. {Gender}.{LastName} {FirstName}, né le {BirthDate} ({Age} ans) - Tél : {PhoneNumber} - Email : {Email}";
        }
    }
}
