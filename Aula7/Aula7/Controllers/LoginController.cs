﻿using Aula7.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aula7.Controllers
{
    public class LoginController : Controller
    {
        // GET: LoginController
        public ActionResult Index()
        {
            return View(new UsuarioModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Logar(UsuarioModel userModel)
        {
            try
            {
                if (userModel.Login())
                {
                    return RedirectToAction("Index", "Aluno");
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }
        // GET: LoginController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LoginController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoginController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: LoginController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LoginController/Edit/5
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

        // GET: LoginController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LoginController/Delete/5
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
