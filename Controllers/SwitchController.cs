using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SwitchGames.Models;
using SwitchGames.Services;

namespace SwitchGames.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SwitchController : ControllerBase
    {
        public SwitchController()
        {
        }

        [HttpGet]
        public ActionResult<List<Switch>> GetAll() =>
            SwitchService.GetAll(); 

        // GET by Id action

        // POST action

        // PUT action

        // DELETE action
    }
}