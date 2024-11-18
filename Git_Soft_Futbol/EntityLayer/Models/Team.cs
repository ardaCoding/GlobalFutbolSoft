using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string TeamName { get; set; }

        public readonly int MAX_PLAYER_COUNT = 28;
        public byte[] TeamLogo { get; set; }

        public ICollection<Leauge> Leauges { get; set; }
        public ICollection<Player> Players
        {
            get { return Players; }
            set
            {
                if (value.Count <= MAX_PLAYER_COUNT)
                {

                    Players = value;
                }
                else
                {
                    throw new ArgumentException("28 futbolcu sınırı");
                }// set ile bir iş kuralı yapmış olmak için böyle bir örnek yaptık!!!
            }




        }

    }
}
