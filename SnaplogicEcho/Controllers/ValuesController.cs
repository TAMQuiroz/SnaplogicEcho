using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SnaplogicEcho.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public string Get()
        {
            var parameter = Request.GetQueryNameValuePairs().First();

            if (parameter.Key == "accessKey")
                return parameter.Value;
            else 
                return null;
        }
    }
}
