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
        public ActionResult<Switch> Get(int id)
        {
            var game = SwitchService.Get(id);

            if (game == null)
                return NotFound();

            return game;
        }

        [HttpPost]
        public IActionResult Create(Switch game)
        {
            SwitchService.Add(game);
            return CreatedAtAction(nameof(Create), new { id = game.Id }, game);
        }

        // [HttpPut("{id}")]
        // public IActionResult Update(int id, Pizza pizza)
        // {
        //     // This code will update the pizza and return a result
        // }

        // [HttpDelete("{id}")]
        // public IActionResult Delete(int id)
        // {
        //     // This code will delete the pizza and return a result
        // }
    }
}