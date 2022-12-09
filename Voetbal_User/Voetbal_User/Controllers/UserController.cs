using DAL.Context;
using Logic.Classes;
using Logic.Container;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Voetbal_User.Controllers
{
    [ApiController]
    [EnableCors]
    public class UserController : Controller
    {
        private UserContainer pc;
        private readonly IConfiguration configuration;

        public UserController(IConfiguration ic)
        {
            configuration = ic;
            pc = new(new UserContext(configuration["db:ConnectionString"]));
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult JsonConverter(User user)
        {
            User us = pc.attemptLogin(user);
            var json = JsonSerializer.Serialize(us);
            return Ok(json);
        }
    }
}