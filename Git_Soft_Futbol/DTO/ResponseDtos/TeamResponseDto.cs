using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ResponseDtos
{
    public class TeamResponseDto:BaseResponseDto<Int32>
    {
        public TeamResponseDto(int id ) : base(id)
        {

        }
    }
}
