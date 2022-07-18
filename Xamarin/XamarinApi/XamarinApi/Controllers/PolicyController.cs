using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using XamarinApi.Services;
using XamarinApi.Models;

namespace XamarinApi.Controllers
{
    public class PolicyController : ApiController
    {

        XamarinService xamarinService;
        // GET: Policy
        public PolicyController()
        {
          XamarinService = new XamarinService();
        }

        [System.Web.Http.HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(XamarinService.getPolicies());
        }

        [System.Web.Http.HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            return Ok(XamarinService.deletePolicy(id));
        }

        [System.Web.Http.HttpPost]
        public IHttpActionResult Post(POLICY policy)
        {
            return Ok(XamarinService.addPolicy(policy));
        }





        public XamarinService XamarinService { get => xamarinService; set => xamarinService = value; }
    }
}