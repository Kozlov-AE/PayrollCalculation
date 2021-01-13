using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PayrollCalculation.Api.Models;
using PayrollCalculation.Api.ResourceModels;
using PayrollCalculation.Api.Services;

namespace PayrollCalculation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost]
        public ActionResult<bool> Test(LoginRequest request)
        {
            var authService = new AuthService();
            return Ok(authService.Login(request.LastName));
        }
    }
}

