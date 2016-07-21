using ConexionLINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ConexionLINQ.Controllers
{
    public class PepinoController : Controller
    {

        private PepinoDataContext Pcontext;
        

        public PepinoController() {
            Pcontext = new PepinoDataContext();
            
        }

        private void PrepareAgricultor(PepinoModel model)
        {
            model.Agricultors = Pcontext.Agricultors.AsQueryable<Agricultor>().Select(x =>
                    new SelectListItem()
                    {
                        Text = x.Nombre,
                        Value = x.Id.ToString()
                    });
        }

        // Paginas de interés para hacerlo
        // http://www.asp.net/mvc/overview/older-versions-1/models-data/creating-model-classes-with-linq-to-sql-cs
        // http://mvcmusicstore.codeplex.com/
        // http://www.c-sharpcorner.com/UploadFile/3d39b4/simple-select-insert-update-and-delete-using-linq-to-sql/
        //http://stackoverflow.com/questions/9720225/how-to-perform-join-between-multiple-tables-in-linq-lambda

        // GET: Pepino
        // Mostrar en el Index todos los Pepinos existentes 
        public ActionResult Index()
        {
            if (Request.IsAuthenticated) { 
            IList<PepinoModel> PepinoList = new List<PepinoModel>();

            Usuario usuarioP = (from u in Pcontext.Usuarios
                                where u.Email.Equals(FormsAuthentication.Decrypt(Request.Cookies[FormsAuthentication.FormsCookieName].Value).Name)
                                select u).Single();

            var query = from Pepino in Pcontext.Pepinos
                        join Agricultor in Pcontext.Agricultors on Pepino.AgricultorId equals Agricultor.Id
                        join PepinoUsuario in Pcontext.PepinoUsuarios on Pepino.Id equals PepinoUsuario.PepinoId
                        join Usuario in Pcontext.Usuarios on  PepinoUsuario.UsuarioId equals Usuario.Id where Usuario.Id.Equals(usuarioP.Id)
                        select new PepinoModel
                        {
                            Id = Pepino.Id,
                            Nombre = Pepino.Nombre,
                            Longitud = (decimal)Pepino.Longitud,
                            Peso = (decimal)Pepino.Peso,
                            AgricultorNombre = Agricultor.Nombre,
                            Usuario = Usuario.Nickname
                        };


            PepinoList = query.ToList();

            return View(PepinoList);
        }
            else
            {
                TempData["sesion"] = "Ha expirado tu sesión.";
                return RedirectToAction("Index", "Home");
            }
        }
        
        // GET: Pepino/CreatePepino
        public ActionResult Create()
        {
            if (Request.IsAuthenticated)
            {
                PepinoModel model = new PepinoModel();
                PrepareAgricultor(model);
                return View(model);
            }
            else
            {
                TempData["sesion"] = "Ha expirado tu sesión.";
                return RedirectToAction("Index", "Home");
            }
        }

        // POST: /Pepino/CreatePepino

        [HttpPost]
        public ActionResult Create(Pepino model)
        {
            try
            {
                if (Request.IsAuthenticated)
                {
                    Pepino obj = new Pepino
                    {

                        //Id = model.Id,
                        Longitud = model.Longitud,
                        Nombre = model.Nombre,
                        Peso = model.Peso,
                        AgricultorId = model.AgricultorId
                    };
                    // Select para coger el usuario que está logeado mediante el e-mail
                    /*Usuario usuarioP = (from u in Pcontext.Usuarios
                                   where u.Email.Equals(FormsAuthentication.Decrypt(Request.Cookies[FormsAuthentication.FormsCookieName].Value).Name)
                                   select u).Single();

                    PepinoUsuario pepi = new PepinoUsuario
                    {
                        PepinoId = model.Id,
                        UsuarioId = usuarioP.Id
                    };*/


                    Pcontext.Pepinos.InsertOnSubmit(obj);
                    // Pcontext.PepinoUsuarios.InsertOnSubmit(pepi);
                    Pcontext.SubmitChanges();

                    //Enviar el nombre para unir las tablas
                    //PepinoUsuario(model.Nombre);

                    return RedirectToAction("CreatePepinoUsuario", new { nombrePepino = model.Nombre });
                }
                else
                {
                    TempData["sesion"] = "Ha expirado tu sesión.";
                    return RedirectToAction("Index", "Home");
                }
            }
            catch
            {
                return View(model);
            }
        }

        // GET: Pepino/CreatePepino
        /*public ActionResult CreatePepinoUsuario()
        {
            PepinoUsuarioModel model = new PepinoUsuarioModel();
            return View(model);
        }*/


        public ActionResult CreatePepinoUsuario(string nombrePepino) {

            if (Request.IsAuthenticated)
            {

                Pepino pepino = (from p in Pcontext.Pepinos
                                 where p.Nombre.Equals(nombrePepino)
                                 select p).Single();

                //Select para coger el usuario que está logeado mediante el e-mail
                Usuario usuarioP = (from u in Pcontext.Usuarios
                                    where u.Email.Equals(FormsAuthentication.Decrypt(Request.Cookies[FormsAuthentication.FormsCookieName].Value).Name)
                                    select u).Single();

                PepinoUsuario pepi = new PepinoUsuario
                {
                    PepinoId = pepino.Id,
                    UsuarioId = usuarioP.Id
                };

                Pcontext.PepinoUsuarios.InsertOnSubmit(pepi);
                Pcontext.SubmitChanges();

                return RedirectToAction("Index", "Pepino");
            }
            else
            {
                TempData["sesion"] = "Ha expirado tu sesión.";
                return RedirectToAction("Index", "Home");
            }
        }


        // GET: Pepino/EditPepino/5
        public ActionResult Edit(int id)
        {
            if (Request.IsAuthenticated)
            {
                PepinoModel pepino = Pcontext.Pepinos.Where(p => p.Id == id).Select(p => new PepinoModel()
                {
                    Id = p.Id,
                    Nombre = p.Nombre,
                    Longitud = (decimal)p.Longitud,
                    Peso = (decimal)p.Peso,
                    AgricultorId = (int)p.AgricultorId
                }).SingleOrDefault();
                PrepareAgricultor(pepino);
                return View(pepino);
            }
            else
            {
                TempData["sesion"] = "Ha expirado tu sesión.";
                return RedirectToAction("Index", "Home");
            }
            
        }

        // POST: Pepino/EditPepino
        [HttpPost]
        public ActionResult Edit(Pepino model)
        {
            if (Request.IsAuthenticated)
            {
                Pepino obj = Pcontext.Pepinos.Where(p => p.Id == model.Id).Single<Pepino>();

                obj.Longitud = model.Longitud;
                obj.Nombre = model.Nombre;
                obj.Peso = model.Peso;
                obj.AgricultorId = model.AgricultorId;

                Pcontext.SubmitChanges();

                return RedirectToAction("Index");
            }
            else
            {
                TempData["sesion"] = "Ha expirado tu sesión.";
                return RedirectToAction("Index", "Home");
            }
        }

        // POST: Pepino/DeletePepino/5
        public ActionResult Delete(int id)
        {
            if (Request.IsAuthenticated)
            {
                Pepino pepino = Pcontext.Pepinos.Single(p => p.Id == id);
                PepinoUsuario pepinoU = Pcontext.PepinoUsuarios.Single(p => p.PepinoId == id);
                Pcontext.Pepinos.DeleteOnSubmit(pepino);
                Pcontext.PepinoUsuarios.DeleteOnSubmit(pepinoU);
                Pcontext.SubmitChanges();

                return RedirectToAction("Index");
            }
            else
            {
                TempData["sesion"] = "Ha expirado tu sesión.";
                return RedirectToAction("Index", "Home");
            }
        }


    }
}