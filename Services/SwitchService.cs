using SwitchGames.Models;
using System.Collections.Generic;
using System.Linq;

namespace SwitchGames.Services
{
    public static class SwitchService
    {
        static List<Switch> Games { get; }
        static int nextId = 3;
        static SwitchService()
        {
            Games = new List<Switch>
            {
                new Switch { Id = 1, Name = "Mario Kart 8", Owned = false },
                new Switch { Id = 2, Name = "Luigi's Mansion 3", Owned = true }
            };
        }

        public static List<Switch> GetAll() => Games;

        public static Switch Get(int id) => Games.FirstOrDefault(p => p.Id == id);

        public static void Add(Switch game)
        {
            game.Id = nextId++;
            Games.Add(game);
        }

        public static void Delete(int id)
        {
            var game = Get(id);
            if(game is null)
                return;

            Games.Remove(game);
        }

        public static void Update(Switch game)
        {
            var index = Games.FindIndex(p => p.Id == game.Id);
            if(index == -1)
                return;

            Games[index] = game;
        }
    }
}