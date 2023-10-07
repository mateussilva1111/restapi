using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using restapi.Models;
using restapi.Services.Interfaces;

namespace restapi.Controllers
{
    [ApiController]
    [Route("[person]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;
        private IPersonService _personService;

        public PersonController(ILogger<PersonController> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }

        [HttpGet("FindById/{id}")]
        public ActionResult FindById(long id)
        {
            var person = _personService.FindById(id);
            if (person == null) return NotFound();
            return Ok(person);
        }

        [HttpGet]
        public ActionResult FindAll()
        {
            return Ok(_personService.FindAll());
        }

        [HttpDelete]
        public ActionResult Delete(long id)
        {
            _personService.Delete(id);
            return Ok();            
        }

        [HttpPost]
        public ActionResult Create(PersonModel person)
        {
            var personCreate = _personService.CreatePerson(person);
            if (personCreate == null) return NotFound();
            return Ok(personCreate);
        }

        [HttpPut]
        public ActionResult Update(PersonModel person)
        {
            var personUpdate = _personService.Update(person);
            if (personUpdate == null) return NotFound();
            return Ok(personUpdate);
        }

    }
}
