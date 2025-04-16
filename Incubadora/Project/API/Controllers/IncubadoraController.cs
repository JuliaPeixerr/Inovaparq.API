using Incubadora.Project.Domain.Command;
using Incubadora.Project.Domain.Infrastructure.Facade;
using Incubadora.Project.Domain.Query;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Incubadora.Project.API.Controllers
{
    [ApiController]
    [Route(URL)]
    public class IncubadoraController : ControllerBase
    {
        public const string URL = "incubadora";

        private IIncubadoraFacade _incubadoraFacade;

        public IncubadoraController(IIncubadoraFacade incubadoraFacade)
            => _incubadoraFacade = incubadoraFacade;

        [HttpPost("save")]
        public ActionResult Save([FromBody] SaveIncubadoraCommand command)
            => Ok(_incubadoraFacade.Save(command));

        [HttpGet("{id}")]
        public ActionResult Get(int id)
            => Ok(_incubadoraFacade.Get(id));

        [HttpGet("all")]
        public ActionResult GetAll([FromQuery] GetAllIncubadoraQuery query)
            => Ok(_incubadoraFacade.GetAll(query));
    }
}
