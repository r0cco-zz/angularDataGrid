using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataViewService;

namespace DataViewApi.Controllers
{
    public class DataViewsController : ApiController
    {
        private readonly DataViewService.DataViewService _service;

        private DataViewsController(IDataviewService service)
        {
            _service = service;
        }


        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// returns a named dataview
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public IHttpActionResult Get(string name)
        {
            var result = 0;// _service.DoSomethingToGetMeTheHtml
            return Ok(result);
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}