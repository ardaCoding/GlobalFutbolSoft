using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Models
{
    public class Match
    {
        public int Id { get; set; }
        public string StadiumName { get; set; }
        public DateTime MatchDate { get; set; }
        public ICollection<Team> Teams { get; set; }
        public ICollection<MatchStats> MatchStats { get; set; }

    }
}
