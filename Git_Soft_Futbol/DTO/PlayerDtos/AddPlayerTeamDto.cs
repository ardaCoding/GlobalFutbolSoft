using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.PlayerDtos
{
    public class AddPlayerTeamDto
    {
        public int PlayerId { get; set; }
        public int PlayerName { get; set; }
        public int TeamId { get; set; }
    }
}
