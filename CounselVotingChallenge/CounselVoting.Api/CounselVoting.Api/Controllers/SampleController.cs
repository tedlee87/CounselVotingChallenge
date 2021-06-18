using CounselVoting.Domain.Model;
using CounselVoting.Infrastructure.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace CounselVoting.Api.Controllers
{
    [ApiController]
    [Route("sample")]
    public class SampleController : ControllerBase
    {
        private readonly ILogger<SampleController> logger;
        private readonly ISampleService service;

        public SampleController(
            ILogger<SampleController> logger,
            ISampleService service)
        {
            this.logger = logger;
            this.service = service;
        }

        [HttpPost]
        public SampleModel Post([FromBody] SampleModel model)
        {
            return service.Insert(model);
        }

        [HttpPut("{id}")]
        public SampleModel Put(long id, [FromBody] SampleModel model)
        {
            return service.Update(id, model);
        }

        [HttpDelete("{id}")]
        public SampleModel Delete(long id)
        {
            return service.Delete(id);
        }

        [HttpGet("{id}")]
        public SampleModel Get(long id)
        {
            return service.Get(id);
        }

        [HttpGet]
        public IEnumerable<SampleModel> Get()
        {
            return service.Get();
        }
    }
}
