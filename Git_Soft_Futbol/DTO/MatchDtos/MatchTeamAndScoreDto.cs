using DTO.RequestDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.MatchDtos
{
    public class MatchTeamAndScoreDto
    {
        List<TeamRequestDto> Teams { get; set; }
        public byte[] Scores=new byte[2];
            

    }
}
