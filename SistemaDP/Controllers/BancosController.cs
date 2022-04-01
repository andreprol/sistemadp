using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDP.Controllers
{
    public class BancosController : Controller
    {
        [HttpGet]
        public IActionResult Adicionar()
        {

            return View();
        }
    }
}
