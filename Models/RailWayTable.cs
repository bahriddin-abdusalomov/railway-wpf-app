using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailWayWpfApp.Models
{
    public class RailWayTable
    {
        public int RailWayTableId { get; set; }
        public string Reys { get; set; }
        public DateTime MahalliyVaqt { get; set; }       
    }
}

