using Superhero003.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero003.Repository.Interfaces
{
    public interface ITeamRepository
    {
            public Task<List<Team>> GetAllTeam(); // signature
            public Task<Team> GetTeamById(int id);
            public Task<bool> CreateTeam(TeamDTO team);
    
    }
}
