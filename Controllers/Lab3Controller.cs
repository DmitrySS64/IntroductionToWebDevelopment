using LW_1.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LW_1.Controllers
{
    public class Lab3Controller : Controller
    {
        // GET: Lab3
        [HttpGet]
        public ActionResult CreateGroup()
        {
            Dictionary<string, Guid> institutes = new Dictionary<string, Guid>();
            Dictionary<string, int> formOfTraining = new Dictionary<string, int>();
            Dictionary<string, string> areasOfTraining = new Dictionary<string, string>();
            

            using (var db = new TPUEntities()) 
            {
                institutes = db.Институты.ToDictionary(x => x.Наименование, x => x.ID_института);
                formOfTraining = db.Формы_обучения.ToDictionary(x => x.Наименование, x => x.Код_формы_обучения);
                areasOfTraining = db.Направления_подготовки.ToDictionary(x => x.Наименование, x => x.Код_направления_подготовки);
            }

            ViewBag.Institutes = new SelectList(institutes, "Value", "Key");
            ViewBag.FormOfTraining = new SelectList(formOfTraining, "Value", "Key");
            ViewBag.AreasOfTraining = new SelectList(areasOfTraining, "Value", "Key");

            return View();
        }

        [HttpPost]
        public ActionResult AddGroup(Группы newGroup)
        {
            if(ModelState.IsValid)
            {

                return RedirectToAction("ListGroup");
            }
            return View(newGroup);
        }
    }
}