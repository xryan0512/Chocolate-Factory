using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Factory
{
    public class PersonProfile
    {
        public PersonProfile() 
        {
            money = new Money();
        }
        public PersonProfile(string name,string lastname,int age, string email)
        {
            FirstName = name;
            LastName = lastname;
            Age = age;
            Email = email;
            money = new Money();
            
        }
        [Key]
        public int IdPerson { get; set; }

        [Required(ErrorMessage = "FirstName is required")]
        public string FirstName { get; set; }
        
        [Required(ErrorMessage = "LastName is required")]
        public string LastName { get; set; }

        //[StringLength(12)]
        //[Required(ErrorMessage = "UserName is required")]
        //public string UserName { get; set; }

        //[Required(ErrorMessage = "Password is required")]
        //public string Password { get; set; }
        
        //[Required(ErrorMessage = "Age is required")]

        public int Age { get; set; }

        public string Email { get; set; }

        public Money money;

    }
}