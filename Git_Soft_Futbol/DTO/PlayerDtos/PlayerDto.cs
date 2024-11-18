using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DTO.PlayerDtos
{
    public class PlayerDto
    {
        public int Id { get; set; }
        public string PlayerName { get; set; }
        public Position position { get; set; }
        public int TeamId { get; set; }
        public bool IsOnTeamSubs { get; set; }
    }
    public enum Position
    {
        GK,
        DEF,
        MİD,
        FWR
    }
}
