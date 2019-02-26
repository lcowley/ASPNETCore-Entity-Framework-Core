using System;
using System.Linq;
using System.Net;
using AspnetCoreEFCoreExample.Models;
using AspnetCoreEFCoreExample.Repositories;
using AspnetCoreEFCoreExample.Service;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AspnetCoreEFCoreExample.Controllers
{
    [Route("api/[controller]")]
    public class MyModelController : Controller
    {
        private readonly IMyFirstService _myFirstService;

        public MyModelController(IMyFirstService myFirstService)
        {
            _myFirstService = myFirstService;
        }

        // GET: api/mymodel
        [HttpGet("", Name = "GetAll")]
        public IActionResult Get()
        {
            try
            {
                var data = _myFirstService.GetModels();
                return Ok(data);
            }
            catch (Exception exception)
            {
                //logg exception or do anything with it
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }
        }
    }
}
