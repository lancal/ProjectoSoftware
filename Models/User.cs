using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Cotizaciones.Models{

    public class User{

        public int Id {get;set;}

        [Required(ErrorMessage = "This is required.")]

        public string UserName{get; set;}

        [Required(ErrorMessage = "This is required.")] 

        [DataType(DataType.Password)]

        public string Password {get; set;}

        [DataType(DataType.Password)]

        [DisplayName("Confirm Password")]

        [Compare("Password")]

        public string ConfirmPassword {get; set;}

        public bool IsAdmin {get; set;}

    }


}