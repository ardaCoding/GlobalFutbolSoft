using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Models
{
    public class Player
    {
        public int Id { get; set; }
        public bool IsOnTeamSubs { get; set; } // oyuncu takımın maç kadrosuna yazıldı mı ?
        public string NameSurName { get; set; }
        public string Nationality { get; set; }
        public byte[] PlayerPhoto { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
        ICollection<MatchStats> MatchStats { get; set; }
        public Position Position { get; set; }

    }
    public enum Position
    {
        GK,
        DEF,
        MİD,
        FWR
    }
}
