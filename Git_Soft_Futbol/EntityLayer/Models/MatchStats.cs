  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Models
{
    public class MatchStats
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public Player Player { get; set; }  
        public int MatchId { get; set; }
        public Match Match { get; set; }
        public bool IsPlaying { get; set; } // oyuncu ilk 11de forma giyiyor mu eğer ki giymiyor ise Cardstats ve goalStats devre dışı olacak
        public CardStats cardStats { get; set; }  
        public GoalStats goalStats { get; set; }  
        public enum CardStats
        {
            KartGormedi,
            Sarı,
            Kırmızı
        }
        public enum GoalStats
        {
            KartGormedi,
            Sarı,
            Kırmızı
        }

    }
}

