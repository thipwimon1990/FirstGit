using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace FirstAPI.Controllers
{
    public class FirstAPIController : ApiController
    {
        // GET: FirstAPI ห 
        //public JsonResult Index()
        //{

        //    return ;
        //}     // GET api/HelloWorld      
        public string Get()
        {
            return "Hello World";
        }        // GET api/HelloWorld/id       
        public string Get(string id)
        {
            return "Hello " + id; }
    
}
}