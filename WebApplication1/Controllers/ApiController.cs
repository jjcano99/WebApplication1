using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    //[Route("api/[controller]")]
    [Route("[controller]")]
    public class ApiController : Controller
    {
        // GET: api/<controller>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<controller>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}
        // GET api/prueba1
        [HttpGet("prueba1")]
        public string Prueba1()
        {
            return "Hola Mundo1";
        }

        // GET api/prueba2
        [HttpGet("prueba2")]
        public string Prueba2()
        {
            return "Hola Mundo2";
        }

        // GET api/prueba3
        [HttpGet("prueba3")]
        public string Prueba3()
        {
            return "Hola Mundo3";
        }




        // POST api/<controller>
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        [HttpPost("prueba4")]
        public JsonResult Post()
        {
            return Json( "Hola Mundo4");
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
