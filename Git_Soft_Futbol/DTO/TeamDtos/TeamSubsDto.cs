using DTO.PlayerDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.TeamDtos
{
    public class TeamSubsDto
    {
        public int Id { get; set; }
        public string TeamName { get; set; }
        public readonly int MAX_PLAYER_COUNT = 28;
        public ICollection<PlayerDto> Players { get; set; }

    }
}
