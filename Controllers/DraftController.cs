using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using FantasySnowdown.Models;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FantasySnowdown.Controllers
{
    public class DraftController : Controller
    {
        private FantasyContext dbContext;
        public DraftController(FantasyContext context)
        {
            dbContext = context;
        }
        [HttpGet]
        [Route("DraftTIME")]
        public IActionResult DraftPage()
        {
            return View();
        }
    }
}