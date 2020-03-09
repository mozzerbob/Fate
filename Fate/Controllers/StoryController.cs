using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fate.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Fate.Controllers
{
    [Route("api/[controller]")]
    public class StoryController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public ActionResult<IEnumerable<Story>> Get()
        {
            return new []
            {
                new Story { 
                    Id = 1,
                    Name = "The big main story"
                },
                new Story {
                    Id = 2,
                    Name = "The subplot"
                }
            };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public ActionResult<Story> Get(int id)
        {
            return new Story
            {
                Id = id,
                Name = "The story you asked for"
            };
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
