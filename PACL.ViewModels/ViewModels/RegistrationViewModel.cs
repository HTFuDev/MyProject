using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace PACL.ViewModels.ViewModels
{
    public class RegistrationViewModel
    {
        [Required]
        public string UserId { get; set; }

        [Required]
        public string Mobile { get; set; }

        [Required]
        public string OTP { get; set; }

        [Required]
        public string Captcha { get; set; }

        [Required]
        
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
