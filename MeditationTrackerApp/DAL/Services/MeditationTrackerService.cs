using MeditationTrackerApp.DAL.Interrfaces;
using MeditationTrackerApp.DAL.Services.Repository;
using MeditationTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace MeditationTrackerApp.DAL.Services
{
    public class MeditationTrackerService : IMeditationTrackerService
    {
        private readonly IMeditationTrackerRepository _repository;

        public MeditationTrackerService(IMeditationTrackerRepository repository)
        {
            _repository = repository;
        }

        public Task<Meditation> CreateMeditation(Meditation expense)
        {
            return _repository.CreateMeditation(expense);
        }

        public Task<bool> DeleteMeditationById(long id)
        {
            return _repository.DeleteMeditationById(id);
        }

        public List<Meditation> GetAllMeditations()
        {
            return _repository.GetAllMeditations();
        }

        public Task<Meditation> GetMeditationById(long id)
        {
            return _repository.GetMeditationById(id); ;
        }

        public Task<Meditation> UpdateMeditation(Meditation model)
        {
            return _repository.UpdateMeditation(model);
        }
    }
}