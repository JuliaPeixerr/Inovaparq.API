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

        [HttpPost("create")]
        public ActionResult Create([FromBody] CreateUsuarioCommand command)
        {
            _usuarioFacade.Create(command);
            return Ok();
        }

        [HttpPost("login")]
        public ActionResult Login([FromBody] LoginCommand command)
        {
            _usuarioFacade.Login(command);
            return Ok();
        }
    }
}
