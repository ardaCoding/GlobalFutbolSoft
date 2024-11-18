using BussinessLayer.Concrete;
using DTO.RequestDtos;
using DTO.ResponseDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        [HttpPost]

        public TeamResponseDto addTeam(string name,byte[] logo)
        {
            TeamRequestDto dto = new TeamRequestDto(name, logo);
            TeamService teamService = new TeamService();    
            return teamService.add(dto);
        }
    }
}
