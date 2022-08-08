using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBattles_Shared
{
    public class UserRegister
    {
        [Required,EmailAddress]
        public string Email { get; set; }
        [Required,StringLength(16, ErrorMessage = "Your username should be 16 chars long")]
        public string Username { get; set; }
        public string Bio { get; set; }
        [Required,StringLength(100,MinimumLength = 10)]
        public string Password { get; set; }
        [Required,Compare("Password",ErrorMessage ="Password do not match")]
        public string ConfirmPassword { get; set; }
        public int StartUnitId { get; set; } = 1;
        [Range(0,1000,ErrorMessage = "Please select 0 - 1000")]
        public int Bananas { get; set; } = 100;
        public DateTime DateOfBirth { get; set; } = DateTime.Now;
        [Range(typeof(bool),"true","true",ErrorMessage ="Only confirmed users can play")]
        public bool isConfirmed { get; set; } = true;
    }
}
