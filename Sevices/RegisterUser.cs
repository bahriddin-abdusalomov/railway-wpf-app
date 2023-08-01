using RailWayWpfApp.Data;
using RailWayWpfApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailWayWpfApp.Sevices
{
    public class RegisterUser : IRegisterUser
    {
        RailWayDB db = new RailWayDB();
        public void Add(Registratsiya user)
        {
            db.Registratsiyas.Add(user);
            db.SaveChanges();
        }
    }
}
