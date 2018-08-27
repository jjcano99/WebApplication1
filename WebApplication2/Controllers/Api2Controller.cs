using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    //[Route("api/[controller]")]
    [Route("[controller]")]
    [ApiController]
   // public class Api2Controller : ControllerBase
 public class Api2Controller : Controller
    {

        [HttpGet("prueba1")]
        public string Prueba1()
        {
            return "Hola Mundo1";
        }

        // GET api2/prueba2
        [HttpGet("prueba2")]
        public string Prueba2()
        {
            return "Hola Mundo2";
        }

        // GET api2/prueba3
        [HttpGet("prueba3")]
        public string Prueba3()
        {
            return "Hola Mundo3";
        }




        // POST api2/<controller>
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        [HttpPost("prueba4")]
        public JsonResult Post()
        {
            return Json("Hola Mundo4 con CORS");
        }

        [HttpPost("prueba5")]
        public JsonResult Prueba5(Persona persona)
        {
            var result = $"Hola Mundo4 con CORS: {persona.nombre} {persona.apellidos} ";
            return Json(result);

        }

        [HttpPost("prueba6")]
        public string Prueba6(Persona persona)
        {
            var result = $"Hola Mundo4 con CORS: {persona.nombre} {persona.apellidos} ";
            return result;

        }



        //// GET api/values
        //[HttpGet]
        //public ActionResult<IEnumerable<string>> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public ActionResult<string> Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
