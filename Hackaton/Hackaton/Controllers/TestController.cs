using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using Hackaton.Core;
using Hackaton.Core.DataContracts;
using Hackaton.Models;


namespace Hackaton.Controllers {
    [RoutePrefix("Test")]
    public class TestController : ApiController {
        
        /// <summary>
        /// Envia o request do teste
        /// </summary>
        /// <param name="test"></param>
        /// <returns></returns>
        [HttpPost]
        [Route(@"")]
        [ResponseType(typeof(TestResponse))]
        public HttpResponseMessage PostAccount([FromBody]TestRequest testRequest) {

            TestResponse testResponse = new TestResponse();

            TestsFactory testFactory = new TestsFactory();

            testResponse = testFactory.TestProcessor(testRequest);

            

            return this.Request.CreateResponse<TestResponse>(testResponse);
        }

    }
}