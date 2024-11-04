using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace API_Application.Controllers; 
[ApiController]
[Route("APIApplication/employee")]

public class EmployeeController : ControllerBase
{
  //Get method
  //Link to local database using dockercompose
  [HttpGet]
  public ActionResult Get()
  {
    return Ok("Hello World!");
  }
  
}