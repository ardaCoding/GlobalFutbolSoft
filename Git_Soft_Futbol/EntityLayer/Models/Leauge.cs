using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Models
{
    public class Leauge
    {
        public int Id { get; set; }
        public ICollection<Team> Teams { get; set; }
    }
}
