using MeditationTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeditationTrackerApp.DAL.Interrfaces
{
    public interface IMeditationTrackerService
    {
        List<Meditation> GetAllMeditations();
        Task<Meditation> CreateMeditation(Meditation meditation);
        Task<Meditation> GetMeditationById(long id);
        Task<bool> DeleteMeditationById(long id);
        Task<Meditation> UpdateMeditation(Meditation model);
    }
}
