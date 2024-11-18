using DTO.TeamDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.LeaugeDtos
{
    public class LeaugeDto
    {
        public int Id {  get; set; }
        public string LeaugeName { get; set; }
        public ICollection<TeamListDto> teamListDtos { get; set; }

    }
}
