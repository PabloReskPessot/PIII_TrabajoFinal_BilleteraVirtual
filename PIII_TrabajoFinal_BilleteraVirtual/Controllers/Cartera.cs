﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PIII_TrabajoFinal_BilleteraVirtual.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Cartera : ControllerBase
    {
        // GET: api/<Cartera>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Cartera>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Cartera>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Cartera>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Cartera>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
