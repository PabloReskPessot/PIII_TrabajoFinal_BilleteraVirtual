using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using PIII_TrabajoFinal_BilleteraVirtual.Data;
using PIII_TrabajoFinal_BilleteraVirtual.Modelos;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PIII_TrabajoFinal_BilleteraVirtual.Controllers
{



    [Route("api/ppp")]
    [ApiController]
    public class WebAPIcontrollers : ControllerBase
    {
        public SQLconsulta database;   

        // GET: api/<WebAPIcontrollers>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            string URL =  "https://criptoya.com/api/lemoncash/BTC/ARS/1";
            HttpClient client = new HttpClient();

            var respuesta = client.GetAsync(URL).Result;
            Console.WriteLine(respuesta.Content.ReadAsStringAsync().Result);

            return new string[] { "value1", "value2" };
        }

        // GET api/<WebAPIcontrollers>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {

            return "value";
        }

        // POST api/<WebAPIcontrollers>
        [HttpPost]
        public string Post([FromBody] string value)
        {
            string hola = "hola mundo";
            return hola ;
        }

        // PUT api/<WebAPIcontrollers>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WebAPIcontrollers>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
