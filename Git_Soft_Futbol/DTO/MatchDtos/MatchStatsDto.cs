using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EntityLayer.Models.MatchStats;

namespace DTO.MatchDtos
{
    public class MatchStatsDto
    {
        public string MatchName { get; set; }
        public string PlayerName { get; set; }
       public bool IsPlaying { get; set; } // ilk 11 mi
        public CardStats cardStats { get; set; }  //  kart istatistiği
        public GoalStats goalStats { get; set; }  //  skor istatistiği

    }
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
