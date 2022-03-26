using System.ComponentModel.DataAnnotations;

namespace MovieApp.Models
{
    public class User
    {
        [Required (ErrorMessage ="Enter name")]
        public string name { get; set; }

        [Required (ErrorMessage ="Enter email")]
        [EmailAddress(ErrorMessage ="Rewrite your email.")]
        public string email { get; set; }

        [Required (ErrorMessage =   "Enter phone number")]
        public string phone { get; set; }

         [Required (ErrorMessage =   "Select your gender")]
        public string gender { get; set; }

          [Required (ErrorMessage =   "Enter your Password")]
        public string password { get; set; }

 
    }
}