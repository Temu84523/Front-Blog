using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WithFront.Controllers
{
    public class ContactController : ApiController 
    {
        [HttpGet]
        public object Get()
        {
           var ret= new string[,]{{ "ric", "198/1/1", "0912345678", "eric@gmail.com", "台北市光復南路179號13樓" }, {"Eric", "1980/1/1", "0912345678", "eric@gmail.com", "台北市光復南路179號13樓" }};
            return ret;
        }
    }
}
