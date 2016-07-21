using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConexionLINQ.Models;

namespace ConexionLINQ.Controllers
{
    public class AgricultorController : Controller
    {

        private PepinoDataContext context;
        public AgricultorController()
        {
            context = new PepinoDataContext();
        }
        // GET: Agricultor

        public ActionResult Index()
        {
            IList<AgricultorModel> agricultorList = new List<AgricultorModel>();
            var query = from Agricultor in context.Agricultors
                        select Agricultor;
            var agricultors = query.ToList();
            foreach (var agricultorData in agricultors)
            {
                agricultorList.Add(new AgricultorModel()
                {
                    Id = agricultorData.Id,
                    Nombre = agricultorData.Nombre,
                    Poblacion = agricultorData.Población,
                    CP = agricultorData.CP
                });
            }
            return View(agricultorList);
        }


        public ActionResult Create()
        {
            AgricultorModel model = new AgricultorModel();
            return View(model);
        }


        [HttpPost]
        public ActionResult Create(AgricultorModel model)
        {
            try
            {
                Agricultor agricultor = new Agricultor()
                {
                    Nombre = model.Nombre,
                    Población = model.Poblacion,
                    CP = model.CP
                };
                context.Agricultors.InsertOnSubmit(agricultor);
                context.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }

    }
}