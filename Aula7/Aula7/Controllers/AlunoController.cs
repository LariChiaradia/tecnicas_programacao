﻿using Aula7.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aula7.Controllers
{
    public class AlunoController : Controller
    {
        // GET: AlunoController
        public ActionResult Index()
        {
            AlunoModel aModel = new AlunoModel();
            return View(aModel.Listar());
        }

        // GET: AlunoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AlunoController/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View(new AlunoModel());
        }

        // POST: AlunoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AlunoModel pModel)
        {
            pModel.Salvar();
            return RedirectToAction("index");
        }

        // GET: AlunoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AlunoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AlunoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AlunoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
