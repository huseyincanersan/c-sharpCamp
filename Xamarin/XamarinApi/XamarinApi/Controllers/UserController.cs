using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using XamarinApi.Models;
using XamarinApi.Services;

namespace XamarinApi.Controllers
{
    public class UserController : ApiController
    {

        // GET: User

        private XamarinService XamarinService;
        public UserController()
        {
           XamarinService  = new XamarinService();
        }

        [System.Web.Http.HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(XamarinService.getUsers());
        }

        [System.Web.Http.HttpGet]
        public IHttpActionResult Get(int id)
        {
            return Ok(XamarinService.getUserById(id));
        }

        [System.Web.Http.HttpGet]
        public IHttpActionResult Get(string username,string password)
        {
            return Ok(XamarinService.loginFunction(username,password));
        }

        [System.Web.Http.HttpPost]
        public IHttpActionResult Post(USER u)
        {
            return Ok(XamarinService.addUser(u));
        }


    }
}