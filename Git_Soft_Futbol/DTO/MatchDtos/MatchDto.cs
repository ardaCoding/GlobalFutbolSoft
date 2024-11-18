using DTO.TeamDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.MatchDtos
{
    public class MatchDto
    {
        public int MatchId { get; set; }
        public ICollection<TeamSubsDto> teamSubsDtos { get; set; }
        public string  StadiumName { get; set; }
    }
}
