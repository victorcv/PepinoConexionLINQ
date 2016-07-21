using ConexionLINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ConexionLINQ.Controllers
{
    public class UsuarioController : Controller
    {

        //http://stackoverflow.com/questions/23448510/linq-to-sql-authenticate-login-credentials
        //https://msdn.microsoft.com/en-us/library/ms178581.aspx

        private PepinoDataContext context;
        public UsuarioController()
        {
            context = new PepinoDataContext();
        }

        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }
        // GET: Usuario/CreateUsuario
        public ActionResult CreateUsuario()
        {
            RegisterModel model = new RegisterModel();
            return View(model);
        }

        // POST: /Usuario/CreateUsuario

        [HttpPost]
        public ActionResult CreateUsuario(RegisterModel model)
        {
            try
            {
                if (model.Password == model.ConfirmPassword) { 
                Usuario obj = new Usuario
                {

                    //Id = model.Id,
                    Email = model.Email,
                    Nickname = model.Nickname,
                    Password = model.Password

                };

                context.Usuarios.InsertOnSubmit(obj);
                context.SubmitChanges();
                }

                return RedirectToAction("Index","Pepino");
                
            }
            catch
            {
                return View(model);
            }
        }

        // GET: Usuario/CreateUsuario
        public ActionResult Login()
        {
            LoginModel model = new LoginModel();
            return View(model);
        }
        // POST: Usuario/CreateUsuario
        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            {
                Usuario usu = (from u in context.Usuarios
                                   where u.Email.Equals(model.Email) &&
                                   u.Password.Equals(model.Password)
                                   select u).Single();

                //Session["mail"] = usu.Email;

                if (usu != null)
                {
                    FormsAuthentication.SetAuthCookie(usu.Email,false);

                    return RedirectToAction("Index", "Pepino");
                }
                return RedirectToAction("Login");
            }
        }
        // Usuario/Logout
        public ActionResult Logout()
        {
            //Session.Abandon();
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }



    }
}