using HexaArchitecture.DomainApi.Model.Visitor;
using HexaArchitecture.DomainApi.Port;
using Microsoft.AspNetCore.Mvc;

namespace HexaArchitecture.RestAdapter.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class VisitController : ControllerBase
    {
        private readonly IRequestVisit<Visit> _requestVisit;

        public VisitController(IRequestVisit<Visit> requestVisit)
        {
            _requestVisit = requestVisit;
        }

        // GET: api/deal
        [HttpGet]
        public IActionResult Get()
        {
            var result = _requestVisit.GetVisits();
            return Ok(result);
        }

        // GET: api/deal/1
        [HttpGet]
        [Route("{id}", Name = "GetVisit")]
        public IActionResult Get(int id)
        {
            var result = _requestVisit.GetVisit(id);
            return Ok(result);
        }
    }
}
