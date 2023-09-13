using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View(new AlunoModel2());
        }
        public IActionResult Details()
        {
            return View(new AlunoModel2());
        }
        public IActionResult Edit()
        {
            return View(new AlunoModel2());
        }
        public IActionResult List()
        {
            var lista = new List<AlunoModel2>();
            lista.Add(new AlunoModel2());
            //lista.Add(new AlunoModel2.CriarEmerson());
            return View();
        }
    }
}