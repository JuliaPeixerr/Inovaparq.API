using Incubadora.Project.Domain.Command;
using Incubadora.Project.Domain.Infrastructure.Facade;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Incubadora.Project.API.Controllers
{
    [ApiController]
    [Route(URL)]
    public class UsuarioController : ControllerBase
    {
        public const string URL = "usuario";

        private IUsuarioFacade _usuarioFacade;

        public UsuarioController(IUsuarioFacade usuarioFacade)
            => _usuarioFacade = usuarioFacade;

        [HttpPost("save")]
        public ActionResult Save([FromBody] CreateUsuarioCommand command)
            => Ok(_usuarioFacade.Save(command));

        [HttpPost("login")]
        public ActionResult Login([FromBody] LoginCommand command)
        {
            _usuarioFacade.Login(command);
            return Ok();
        }
    }
}
