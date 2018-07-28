using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GradeBook.webapi
{
    [Route("api/[controller]")]
   public class GradeReportController : Repository
    {
        GradeReportRepository repository;

        public GradeReportController()
        {
            repository = new GradeReportRepository();
        }

        // GET api/GradeReport
        [HttpGet]
        public IEnumerable<GradeReport> Get()
        {
            return repository.GetAll();
        }

        // GET api/GradeReport/5
        [HttpGet("{id}")]
        public GradeReport Get(int id)
        {
            return repository.Get(id);
        }

        // POST api/GradeReport
        [HttpPost]
        public void Post([FromBody]GradeReport gradeReport)
        {
            repository.Insert(gradeReport);
        }

        // PUT api/GradeReport/5
        [HttpPut]
        public void Put([FromBody]GradeReport gradeReport)
        {
            repository.Update(gradeReport);
        }

        // DELETE api/GradeReport/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.Delete(id);
        }
    }
}
