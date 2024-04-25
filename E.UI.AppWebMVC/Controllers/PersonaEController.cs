using E.EntidadesDeNegocio;
using E.LogicaNegocio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace E.UI.AppWebMVC.Controllers
{
    public class PersonaEController : Controller
    {
        // GET: PersonaEController
        public async Task<ActionResult> Index()
        {
            var personaEs = await PersonaE_LogicaNegocio.GetAll();
            return View(personaEs);
        }

        // GET: PersonaEController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var personaE = await PersonaE_LogicaNegocio.GetById(id);
            return View(personaE);
        }

        // GET: PersonaEController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonaEController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(PersonaE pPersonaE)
        {
            try
            {
                var result = await PersonaE_LogicaNegocio.Create(pPersonaE);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaEController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var personaE = await PersonaE_LogicaNegocio.GetById(id);
            return View(personaE);
        }

        // POST: PersonaEController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(PersonaE pPersonaE)
        {
            try
            {
                var result = await PersonaE_LogicaNegocio.Update(pPersonaE);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaEController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var pPersonaE = await PersonaE_LogicaNegocio.GetById(id);
            return View(pPersonaE);

        }

        // POST: PersonaEController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(PersonaE pPersonaE)
        {
            try
            {
                var result = await PersonaE_LogicaNegocio.Delete(pPersonaE);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
