using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using Dto;
namespace api.Controllers
{
    [RoutePrefix("user")]
    public class UserController : ApiController
    {
        [HttpPut]
        [Route("update")]
        public IHttpActionResult Update( UserDto u)
        {
            UserDto b = BL.UserBl.Update(u);
            if(b!=null)
            return Ok(b);
            return BadRequest();
        }

        [HttpGet]
        [Route("add")]
        public IHttpActionResult Add(UserDto u)
        {
            string s = BL.UserBl.Add(u);
            if(s=="tz")
            {
                return Ok("תז קיימת במערכת ");
            }

            if(s=="password")
            {
                return Ok("סיסמא קיימת במערכת אנא החלף סיסמא");
            }

            if (s == "ok")
                return Ok("פרטיך נקלטו בהצלחה");

            return BadRequest();
        }

        [Route("getall")]
        [HttpGet]
        public IHttpActionResult GetAllVolenteer()
        {
            List<UserDto> VolenteerList = BL.UserBl.GetAllVolenteer();
            if (VolenteerList.Count() > 0)
                return Ok(VolenteerList);
            return BadRequest();
        }


        [Route("get/{tz}")]
        [HttpGet]
        public IHttpActionResult GetById(string Tz)
        {
            UserDto user = BL.UserBl.GetVolenteerById(Tz);
            if (user != null)
                return Ok(user);
            return BadRequest();
        }


        [Route("delete/{tz}")]
        [HttpDelete]
        public IHttpActionResult Delete(string tz)
        {
            bool u = BL.UserBl.Delete(tz);
            if (u) 
              return Ok();
            return BadRequest();
        }
    }
 
           
    
}
