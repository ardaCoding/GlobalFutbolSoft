using DataAcess.Repositories;
using DTO.RequestDtos;
using DTO.ResponseDtos;
using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class TeamService
    {
        public TeamResponseDto add(TeamRequestDto teamRequestDto)
        {
            // mapping
            Team team = new Team();
            team.TeamName=teamRequestDto.Name;
            team.TeamLogo=teamRequestDto.Logo;
            TeamRepository teamRepo = new TeamRepository();
            int teamId = teamRepo.insert(team);
            TeamResponseDto teamResponseDto = new TeamResponseDto(teamId);
            return teamResponseDto;
        }
    }
}
