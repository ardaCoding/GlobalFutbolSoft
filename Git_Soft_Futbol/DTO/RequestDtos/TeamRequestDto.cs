using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.RequestDtos
{
    public class TeamRequestDto
    {
        //FARKLI BİR YÖNTEM OLARAK SINIFI İMMUTABLE HALE GETİRDİK
        public TeamRequestDto(string name, byte[] logo)
        {

            Name = name;
            Logo = logo;


        }
        public string Name { get; }
        public byte[] Logo { get; set; }

    }

}
