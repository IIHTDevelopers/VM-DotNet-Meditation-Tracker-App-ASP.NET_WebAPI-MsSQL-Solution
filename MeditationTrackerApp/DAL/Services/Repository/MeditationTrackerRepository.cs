using MeditationTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace MeditationTrackerApp.DAL.Services.Repository
{
    public class MeditationTrackerRepository : IMeditationTrackerRepository
    {
        private readonly DatabaseContext _dbContext;
        public MeditationTrackerRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<Meditation> CreateMeditation(Meditation expense)
        {
            try
            {
                var result =  _dbContext.Meditations.Add(expense);
                await _dbContext.SaveChangesAsync();
                return expense;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<bool> DeleteMeditationById(long id)
        {
            try
            {
                _dbContext.Meditations.Remove(_dbContext.Meditations.Single(a => a.MeditationSessionId == id));
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public List<Meditation> GetAllMeditations()
        {
            try
            {
                var result = _dbContext.Meditations.ToList();
                return result;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<Meditation> GetMeditationById(long id)
        {
            try
            {
                return await _dbContext.Meditations.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

      
        

        public async Task<Meditation> UpdateMeditation(Meditation model)
        {
            var ex = await _dbContext.Meditations.FindAsync(model.MeditationSessionId);
            try
            {
                await _dbContext.SaveChangesAsync();
                return ex;
            }
            catch (Exception exc)
            {
                throw (exc);
            }
        }
    }
}