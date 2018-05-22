using AutoMapper;
using ProjetDDD.Infra.Data.Repositories;
using ProjetDDD.Presentation.Views.Models;
using ProjetoDDD.Domain.Entities;
using ProjtoDDD.Application;
using ProjtoDDD.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetDDD.Presentation.Controllers
{
    public class FuncionarioController : Controller
    {
        private readonly FuncionarioRepositorio _FuncionarioApp;

        public FuncionarioController(FuncionarioRepositorio FuncionarioRepositorio)
        {
            _FuncionarioApp = FuncionarioRepositorio;
        }

        // GET: Funcionario
        public ActionResult Index()
        {
            var Funcionario = Mapper.Map<IEnumerable<Funcionario>, IEnumerable<ViewModelsFuncionario>>(_FuncionarioApp.get());

            return View(Funcionario);
        }

        // GET: Funcionario/Details/5
        public ActionResult Details(int id)
        {
            var func = _FuncionarioApp.getId(id);
            var funcModel = Mapper.Map<Funcionario, ViewModelsFuncionario>(func);
            return View(funcModel);
        }

        // GET: Funcionario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Funcionario/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ViewModelsFuncionario _funcionario)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    var funcionario = Mapper.Map<ViewModelsFuncionario, Funcionario>(_funcionario);
                    _FuncionarioApp.add(funcionario);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(_funcionario);
                }

            }
            catch
            {
                return View(_funcionario);
            }
        }

        // GET: Funcionario/Edit/5
        public ActionResult Edit(int id)
        {

            var func = _FuncionarioApp.getId(id); //
            var funcModel = Mapper.Map<Funcionario, ViewModelsFuncionario>(func);
            return View(funcModel);
        }

        // POST: Funcionario/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ViewModelsFuncionario _funcionario)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    var funcionario = Mapper.Map<ViewModelsFuncionario, Funcionario>(_funcionario);
                    _FuncionarioApp.Update(funcionario);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(_funcionario);
                }

            }
            catch
            {
                return View(_funcionario);
            }
        }

        // GET: Funcionario/Delete/5
        public ActionResult Delete(int id)
        {
            var func = _FuncionarioApp.getId(id); //
            var funcModel = Mapper.Map<Funcionario, ViewModelsFuncionario>(func);
            return View(funcModel);
        }

        // POST: Funcionario/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, ViewModelsFuncionario _funcionario)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    var funcionario = Mapper.Map<ViewModelsFuncionario, Funcionario>(_funcionario);
                    _FuncionarioApp.Remove(funcionario);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(_funcionario);
                }

            }
            catch
            {
                return View(_funcionario);
            }
        }
    }
}
