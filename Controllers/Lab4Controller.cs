using LW_1.Models.Entities;
using LW_1.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LW_1.Controllers
{
    public class Lab4Controller : Controller
    {
        // GET: Lab4
        [HttpGet]
        public ActionResult EditGroup(Guid groupID)
        {
            GroupVM model;
            using (var context = new TPUEntities())
            {
                Группы group = context.Группы.Find(groupID);
                model = new GroupVM
                {
                    ID_группы = group.ID_группы,
                    ID_института = group.ID_института,
                    Наименование = group.Наименование,
                    Год_поступления = group.Год_поступления,
                    Длительность_обучения = group.Длительность_обучения,
                    Код_формы_обучения = group.Код_формы_обучения,
                    Код_направления_подготовки = group.Код_направления_подготовки
                };
            }

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

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken()]
        public ActionResult EditGroup(GroupVM model)
        {
            if (ModelState.IsValid)
            {
                using (var context = new TPUEntities())
                {
                    Группы group = new Группы
                    {
                        ID_группы = model.ID_группы,
                        ID_института = model.ID_института,
                        Наименование = model.Наименование,
                        Год_поступления = model.Год_поступления,
                        Длительность_обучения = model.Длительность_обучения,
                        Код_формы_обучения = model.Код_формы_обучения,
                        Код_направления_подготовки = model.Код_направления_подготовки
                    };

                    context.Группы.Attach(group);
                    context.Entry(group).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            return View(model);
        }
    }
}