using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO_ListContacts.Classes
{
    public enum Gender { Male, Female }
    internal class Contact
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        public Gender Gender{ get; set; }

        public DateTime DateOfBirth { get; set; }

        public int Age
        {
            get
            {
                int age = DateTime.Now.Year - DateOfBirth.Year;
                if (DateTime.Now.AddYears(-age) < DateOfBirth) age--;

                return age;
            }
        }

        [StringLength(25)]
        public string PhoneNumber{ get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public override string ToString()
        {
            return $"{Id}. {FirstName} {LastName} | {Gender} | {DateOfBirth.ToString("d")} ({Age} ans)"
                + $"\n\tMail : {Email}"
                + $"\n\tPhone : {PhoneNumber}";
        }


    }
}
