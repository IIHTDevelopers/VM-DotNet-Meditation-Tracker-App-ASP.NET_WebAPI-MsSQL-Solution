using MeditationTrackerApp.Models;
using MeditationTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeditationTrackerApp.DAL.Services.Repository
{
    public interface IMeditationTrackerRepository
    {
        List<Meditation> GetAllMeditations();
        Task<Meditation> CreateMeditation(Meditation meditation);
        Task<Meditation> GetMeditationById(long id);
        Task<bool> DeleteMeditationById(long id);
        Task<Meditation> UpdateMeditation(Meditation model);
    }
}

