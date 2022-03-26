using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Actividad4.Models;

namespace Actividad4.Controllers
{
    public class UserController : Controller
    {
      
        public IActionResult Index()
        {
            // UserModel User = new UserModel();
            List<UserModel> ListUser = new List<UserModel>()
            {
                new UserModel() {Id = "1", name = "Sergio", rol = "Administrador"},
                new UserModel() {Id = "2", name = "Nicolas", rol="Administrador"},
                new UserModel() {Id = "3", name = "Diana", rol="Usuario"}
            };
            
            return View(ListUser.ToList());
        }

    }
}
