using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Http.Results;
using MWK.WebApi.Helpers;
using Newtonsoft.Json;

namespace MWK.WebApi.Controllers
{
    public class BaseApiController : ApiController
    {
        //so that 
        //  each time we dont do "return new JsonResult(model, new JsonSerializerSettings(){Formatting = Formatting.Indented})"
        //  instead will do "var returnResult = new JsonResult(model, base.JsonSettings);"
        protected JsonSerializerSettings JsonSettings { get; private set; }
        protected Encoding EncodingUtf8 { get; private set; }

        public BaseApiController()
        {
            // Instantiate a single JsonSerializerSettings object
            // that can be reused multiple times.
            //so that 
            //  each time we dont do "return new JsonResult(model, new JsonSerializerSettings(){Formatting = Formatting.Indented})"
            //  instead will do "var returnResult = new JsonResult(model, base.JsonSettings);"
            //  so use BuildJasonResult method below in actions 
            JsonSettings = new JsonSerializerSettings() { Formatting = Formatting.Indented };

            EncodingUtf8 = Encoding.UTF8;
        }

        protected JsonResult<T> BuildJasonResult<T>(T data, ApiController controller)
        {
            return new JsonResult<T>(data, JsonSettings, EncodingUtf8, controller);
        }

        protected HttpActionResult BuildResponseMessage(HttpStatusCode httpStatusCode, string errorMessage)
        {
            return new HttpActionResult(httpStatusCode, errorMessage); // can use any HTTP status code
        }
    }
}
