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
    public class HomeController : Controller
    {
        private FantasyContext dbContext;
        public HomeController(FantasyContext context)
        {
            dbContext = context;
        }
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("user/register")]
        public IActionResult Register(User user)
        {
            // Check initial ModelState
            if(ModelState.IsValid)
            {
            // If a User exists with provided Username
                if(dbContext.Users.Any(u => u.Username == user.Username))
                {
                    ModelState.AddModelError("Username", "Username already in use!");
                    return View("Index");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                user.Password = Hasher.HashPassword(user, user.Password);
                User NewUser = new User
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Username = user.Username,
                    Password = user.Password,
                    ConPass = user.Password,
                };
                dbContext.Add(NewUser);
                dbContext.SaveChanges();

                User newuser = dbContext.Users.FirstOrDefault(n => n.Username == user.Username);
                HttpContext.Session.SetInt32("UserId", newuser.UserId);
                HttpContext.Session.SetString("User", newuser.FirstName);
                return RedirectToAction("Dashboard");
            }
            return View("Index");      
        }
        
        [HttpPost("UserLogin/login")]
        public IActionResult Login(LoginUser UserLogin)
        {
            if(ModelState.IsValid)
            {
                var userInDb = dbContext.Users.FirstOrDefault(u => u.Username == UserLogin.Username);

                if(userInDb == null)
                {
                    ModelState.AddModelError("Username", "Invalid Username/Password");
                    return View("Index");
                }
            
                var hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(UserLogin, userInDb.Password, UserLogin.Password);
            
                if(result == 0)
                {
                    ModelState.AddModelError("Password", "Invalid Username/Password");
                    return View("Index");
                }
                
                HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                HttpContext.Session.SetString("User", userInDb.FirstName);
                return RedirectToAction("Dashboard");
            }
            return View("Index");
        }
    }
}
