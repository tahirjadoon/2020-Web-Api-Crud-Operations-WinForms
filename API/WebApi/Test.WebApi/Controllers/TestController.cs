using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MWK.WebApi.Validators;
using Test.Helpers;

namespace MWK.WebApi.Controllers
{
    public class TestController : BaseApiController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            return base.BuildResponseMessage(HttpStatusCode.OK, "Standard Get executed");
        }

        [HttpGet]
        public IHttpActionResult Get(string id)
        {
            return base.BuildResponseMessage(HttpStatusCode.OK, $"Get with {id} executed");
        }

        [HttpGet]
        public IHttpActionResult All()
        {
            //multiline return 
            var dummies = new List<DummyPost>
            {
                new DummyPost {Id = 1, Message = "One M", Name = "One"},
                new DummyPost {Id = 2, Message = "Two M", Name = "Two"}
            };

            //we can do this - prefered by me
            return base.BuildJasonResult<List<DummyPost>>(dummies, this);
        }

        [HttpPost]
        public IHttpActionResult Post([FromBody]DummyPost dummy)
        {
            //dummy is not null
            if (dummy == null)
            {
                //return BadRequest("Dummy data null");
                //we can also do something like 
                return Content(HttpStatusCode.BadRequest, "Dummy data null");
            }

            //fluent validation
            var result = new DummyPostValidator().Validate(dummy);
            if (!result.IsValid)
            {
                foreach (var f in result.Errors)
                {
                    ModelState.AddModelError(f.PropertyName, f.ErrorMessage);
                }
            }

            //dummy model state is valid
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //over write the Id value of the dummy
            dummy.Id = 50;
            dummy.Message = "Standard Post";

            return base.BuildJasonResult<DummyPost>(dummy, this);
        }

        [HttpPost]
        public IHttpActionResult ExtraPost([FromBody]DummyPost dummy)
        {
            //dummy is not null
            if (dummy == null)
            {
                return BadRequest("Dummy data null");
            }

            //dummy model state is valid
            if (!ModelState.IsValid)
            {
                return BadRequest("Dummy data model state is not valid");
            }

            //over write the Id value of the dummy
            dummy.Id = 50;
            dummy.Message = "Extra Post";

            return base.BuildJasonResult<DummyPost>(dummy, this);
        }

        [HttpPost]
        public IHttpActionResult ExtraPostOk([FromBody]DummyPost dummy)
        {
            //dummy is not null
            if (dummy == null)
            {
                return BadRequest("Dummy data null");
            }

            //dummy model state is valid
            if (!ModelState.IsValid)
            {
                return BadRequest("Dummy data model state is not valid");
            }

            return base.BuildResponseMessage(HttpStatusCode.OK, "Posted Ok");
        }

        [HttpPost]
        public IHttpActionResult ExtraPostMultiLineReturn([FromBody]DummyPost dummy)
        {
            //dummy is not null
            if (dummy == null)
            {
                return BadRequest("Dummy data null");
            }

            //dummy model state is valid
            if (!ModelState.IsValid)
            {
                return BadRequest("Dummy data model state is not valid");
            }

            //multiline return 
            var dummies = new List<DummyPost>
            {
                new DummyPost {Id = 1, Message = "One M", Name = "One"},
                new DummyPost {Id = 2, Message = "Two M", Name = "Two"}
            };
            dummy.Id = 50;
            dummy.Message = "Extra Post";

            return base.BuildJasonResult<List<DummyPost>>(dummies, this);
        }

        [HttpPut]
        public IHttpActionResult Put(int id, [FromBody]DummyPost dummy)
        {
            // dummy is not null
            if (dummy == null)
            {
                return BadRequest("Dummy data null");
            }

            //dummy model state is valid
            if (!ModelState.IsValid)
            {
                return BadRequest("Dummy data model state is not valid");
            }

            //over write the Id value of the dummy
            dummy.Id = 50;
            dummy.Message = "PUT Post";

            return base.BuildJasonResult<DummyPost>(dummy, this);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            return base.BuildResponseMessage(HttpStatusCode.OK, $"{id} deleted...");
        }

    }
}
