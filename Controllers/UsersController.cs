using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdealPoultryApp.Models;
using IdealPoultryApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace IdealPoultryApp.Controllers
{
    public class UsersController : Controller
    {
        private IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]LoginModel model)
        {
            return Ok(_userService.IsUserValid(model));
        }
    }
}