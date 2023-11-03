using System.ComponentModel.DataAnnotations;

namespace Forms.Models
{
    public class Form
    {
        [Required(ErrorMessage = "Imię jest wymagane")]
        [MinLength(2, ErrorMessage = "Imię musi posiadać conajmniej 2 litery")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Nazwisko jest wymagane")]
        [MinLength(2, ErrorMessage = "Nazwisko musi posiadać conajmniej 2 litery")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "E-mail jest wymagany")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Coś się nie zgadza...pamiętasz o @ i domenie?")]
        [MinLength(8, ErrorMessage = "E-mail musi mieć conajmniej 8 znaków")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Hasło jest wymagane")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).{8,}$", ErrorMessage = "Hasło musi miec conajmniej 8 znaków w tym conajmniej jedna mała i duża litera oraz cyfra")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Powtórzenie hasła jest wymagane")]
        [Compare("Password", ErrorMessage = "Hasła się nie zgadzają")]
        public string PasswordConfirm { get; set; }
        [RegularExpression("[0-9]{3}-[0-9]{3}-[0-9]{3}", ErrorMessage = "Numer ma format 000-000-000")]
        public string PhoneNumber { get; set; }
        [Range(10, 80, ErrorMessage = "Musisz mieć conajmniej 10 lat i maksymalnie 80 aby wziąć udział w tym formularzu")]
        public int Age { get; set; }

        public string City { get; set; }
        public enum Cities { Krakow = 0, Warszawa = 1, Wroclaw = 2, Gdansk = 3, Lublin = 4 }


    }
}
