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

        [HttpGet("{id}")]
        public ActionResult<Switch> Get(int id) {
            var game = SwitchService.Get(id);

            if(game == null)
                return NotFound();

            return game;
        }

        // POST action

        // PUT action

        // DELETE action
    }
}