using MeditationTrackerApp.DAL.Interrfaces;
using MeditationTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace MeditationTrackerApp.Controllers
{
    public class MeditationController : ApiController
    {
        private readonly IMeditationTrackerService _service;
        public MeditationController(IMeditationTrackerService service)
        {
            _service = service;
        }
        public MeditationController()
        {
            // Constructor logic, if needed
        }
        [HttpPost]
        [Route("api/Meditation/CreateMeditation")]
        [AllowAnonymous]
        public async Task<IHttpActionResult> CreateMeditation([FromBody] Meditation model)
        {
            var leaveExists = await _service.GetMeditationById(model.MeditationSessionId);
            var result = await _service.CreateMeditation(model);
            return Ok(new Response { Status = "Success", Message = "Meditation created successfully!" });
        }


        [HttpPut]
        [Route("api/Meditation/UpdateMeditation")]
        public async Task<IHttpActionResult> UpdateMeditation([FromBody] Meditation model)
        {
            var result = await _service.UpdateMeditation(model);
            return Ok(new Response { Status = "Success", Message = "Meditation updated successfully!" });
        }


        [HttpDelete]
        [Route("api/Meditation/DeleteMeditation")]
        public async Task<IHttpActionResult> DeleteMeditation(long id)
        {
            var result = await _service.DeleteMeditationById(id);
            return Ok(new Response { Status = "Success", Message = "Meditation deleted successfully!" });
        }


        [HttpGet]
        [Route("api/Meditation/GetMeditationById")]
        public async Task<IHttpActionResult> GetMeditationById(long id)
        {
            var expense = await _service.GetMeditationById(id);
            return Ok(expense);
        }


        [HttpGet]
        [Route("api/Meditation/GetAllMeditations")]
        public async Task<IEnumerable<Meditation>> GetAllMeditations()
        {
            return _service.GetAllMeditations();
        }
    }
}
