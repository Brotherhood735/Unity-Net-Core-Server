using Server.Services;
using Microsoft.AspNetCore.Mvc;
using SharedLibrary;

namespace Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerService _playerService;
        public PlayerController(IPlayerService playerService)
        {
            _playerService = playerService;
        }


        [HttpGet("{id}")]
        public Player Get([FromRoute] int id)
        {
            var player = new Player() { Id = id, Health=19};
            Console.WriteLine(player);
            _playerService.DoSomething();
            return player;
        }

        [HttpPost]
        public Player Post(Player player)
        {
            Console.WriteLine("Player has been added to the DB");
            return player;
        }
    }
}
