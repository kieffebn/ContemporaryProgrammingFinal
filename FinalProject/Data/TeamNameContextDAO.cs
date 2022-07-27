using FinalProject.Interfaces;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Data
{
    public class TeamNameContextDAO : ITeamNameContextDAO
    {
        private TeamNameContext _context;
        public TeamNameContextDAO(TeamNameContext context)
        {
            _context = context;
        }

        public List<TeamName> GetTeamNames()
        {
            return _context.TeamNames.ToList();
        }

        public TeamName GetTeamNameById(int id)
        {
            return _context.TeamNames.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public int? RemoveTeamNameById(int id)
        {
            var name = this.GetTeamNameById(id);
            if (name == null) return null;
            try
            {
                _context.TeamNames.Remove(name);
                _context.SaveChanges();
                return 1;
            }
            catch(Exception ex)
            {
                return 0;
            }
        }

        public int? UpdateTeamName(TeamName name)
        {
            var teamNameToUpdate = this.GetTeamNameById(name.Id);
            if (teamNameToUpdate == null)
                return null;

            teamNameToUpdate.PersonName = name.PersonName;
            teamNameToUpdate.Birthday = name.Birthday;
            teamNameToUpdate.Program = name.Program;
            teamNameToUpdate.Year = name.Year;
            try 
            {
                _context.TeamNames.Update(teamNameToUpdate);
                _context.SaveChanges();
                return 1;
            }
            catch(Exception)
            {
                return 0;
            }
        }

        public int? Add(TeamName name)
        {
            var names = _context.TeamNames.Where(x => x.PersonName.Equals(name.PersonName)).FirstOrDefault();

            if (name == null)
                return null;
            try
            {
                _context.TeamNames.Add(name);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
