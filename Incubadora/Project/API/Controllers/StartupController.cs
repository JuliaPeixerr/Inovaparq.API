using Incubadora.Project.Domain.Command;
using Incubadora.Project.Domain.Infrastructure.Facade;
using Incubadora.Project.Domain.Query;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Incubadora.Project.API.Controllers
{
    [ApiController]
    [Route(URL)]
    public class StartupController : ControllerBase
    {
        public const string URL = "startup";

        private IStartupFacade _incubadoraFacade;

        public StartupController(IStartupFacade incubadoraFacade)
            => _incubadoraFacade = incubadoraFacade;

        [HttpPost("save")]
        public ActionResult Save([FromBody] SaveStartupCommand command)
            => Ok(_incubadoraFacade.Save(command));

        [HttpGet("{id}")]
        public ActionResult Get(int id)
            => Ok(_incubadoraFacade.Get(id));

        [HttpGet("all")]
        public ActionResult GetAll([FromQuery] GetAllStartupQuery query)
            => Ok(_incubadoraFacade.GetAll(query));
    }
}
