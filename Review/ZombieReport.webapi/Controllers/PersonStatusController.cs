using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ZombieReport.webapi.Controllers
{
    [Route("api/[controller]")]
    public class PersonStatusController : Controller
    {
        PersonStatusRepository repository;

        public PersonStatusController()
        {
            repository = new PersonStatusRepository();
        }

        // GET api/PersonStatus
        [HttpGet]
        public IEnumerable<PersonStatus> Get()
        {
            return repository.GetAll();
        }

        // GET api/PersonStatus/5
        [HttpGet("{id}")]
        public PersonStatus Get(int id)
        {
            return repository.Get(id);
        }

        // POST api/PersonStatus
        [HttpPost]
        public void Post([FromBody]PersonStatus personStatus)
        {
            repository.Insert(personStatus);
        }

        // PUT api/PersonStatus/5
        [HttpPut]
        public void Put([FromBody]PersonStatus personStatus)
        {
            repository.Update(personStatus);
        }

        // DELETE api/PersonStatus/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.Delete(id);
        }
    }
}

/*
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
 */