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
        Provider pro = new Provider();
        
        public void setDbRep()
        {
            if (rep == null)
                rep = HttpContext.RequestServices.GetService(typeof(Repositorio)) as Repositorio;
        }

        public ActionResult InvocarWS()
        {
            // pro = new Provider();

            listTableNames();
            // getTableName(pro);
            return View();
        }

        public ActionResult listTableNames()
        {
            setDbRep();
            pro.table_names = rep.getTableNames();
            //List<Provider> entidades = new List<Provider>();
            // entidades = rep.getTableNames();
            ViewBag.Entidades = new SelectList(pro.table_names);
            // var result = new SelectList(model.table_names);
            return View();
        }

        [HttpPost]
        public ActionResult getTableName(Provider model)
        {            
            // model = new Provider();
            // string strDDLValue = form["ddlVendor"].ToString();
            var selected_table = model.selected_table_name;
            ViewBag.selected_tabela = selected_table;
            return View(selected_table);
        }

        // [HttpPost]
        // public ActionResult getTableName(Provider model)
        // {            
        //     // model = new Provider();
        //     // string strDDLValue = form["ddlVendor"].ToString();
        //     var selected_table = model.selected_table_name;
        //     ViewBag.selected_tabela = selected_table;
        //     return Content(selected_table);
        // }

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