using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using app.Models;
using app.Database;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace app.Controllers
{
    //[Route("api/[controller]")]
    public class FirstPageController : Controller
    {
        Repositorio rep;
        Provider pro;
        //GET: FirstPage/InvocarWS
        // public ActionResult InvocarWS()
        // {

            // FirstPageContext context = HttpContext.RequestServices.GetService(typeof(app.Models.FirstPageContext)) as FirstPageContext;  
            // List<Provider> list = context.getTableNames();
            // return View(list); 
            // return View();
            //var first_page = new FirstPage() {Id = 10, String1 = "valor1", String2 = "valor2"};
            
            //return View(first_page);
            //return Content("Helllo World"); //retorna o conteudo explicito
            //return new EmptyResult(); //retorna pagina em branco
            //return RedirectToAction("Index", "Home", new { page = 1, sortby = "name"});
        // }
        void setDbRep()
        {
            if (rep == null)
                rep = HttpContext.RequestServices.GetService(typeof(Repositorio)) as Repositorio;
        }

        public ActionResult InvocarWS()
        {
            // setDbRep();
            // pro = new Provider();
            // pro.table_names = rep.getTableNames();
            // ViewBag.Entidades = new SelectList(pro.table_names);
            listTableNames();
            return View();
        }
        [HttpGet]
        public ActionResult listTableNames()
        {
            setDbRep();
            pro = new Provider();
            pro.table_names = rep.getTableNames();
            //List<Provider> entidades = new List<Provider>();
            // entidades = context.getTableNames();
            ViewBag.Entidades = new SelectList(pro.table_names);
            // var result = new SelectList(model.table_names);
            return View();
        }
        [HttpPost]
        public ActionResult listTableName(Provider model)
        {
            var selected_table = model.selected_table_name;
            ViewBag.selected_tabela = selected_table;
            return View();
        }

        /* public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }
        //entidades
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        } */
    }
}