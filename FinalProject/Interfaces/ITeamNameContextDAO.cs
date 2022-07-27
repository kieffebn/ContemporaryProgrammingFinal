using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Interfaces
{
    public interface ITeamNameContextDAO
    {
        List<TeamName> GetTeamNames();
        TeamName GetTeamNameById(int id);
        int? RemoveTeamNameById(int id);
        int? UpdateTeamName(TeamName name);
        int? Add(TeamName name);
    }
}
