using DataAcess.DBContext;
using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Repositories
{
    public class TeamRepository
    {
        public int insert (Team team) { 
            GfsAppContext context = new GfsAppContext ();
            context.Teams.Add (team);
            return team.Id;
        }
    }
}
