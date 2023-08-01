using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailWayWpfApp.Models
{
    public class Registratsiya
    {
        public int RegistratsiyaId { get; set; }
        public string Email { get ; set; }
        public string Password { get; set; }
        public string RepeatPassword { get ; set; }

    }
}
