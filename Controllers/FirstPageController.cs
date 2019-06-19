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
        Provider model;
        
        public void setDbRep()
        {
            if (rep == null)
                rep = HttpContext.RequestServices.GetService(typeof(Repositorio)) as Repositorio;
        }

        public ActionResult InvocarWS()
        {
            setDbRep();
            model = new Provider();

            listTableNames();
            // getTablePost(model);
            // teste();
            listColumns();
            listDataTEST();
            return View(model);
        }
        
        public void listTableNames()
        {
            model.table_names = rep.getTableNames();
        }

        [HttpPost]
        public ActionResult getTablePost(Provider model)
        {            
            listTableNames();
            // model = new Provider();
            var selected_table_name = model.selected_table_name;
            var url = model.url;
            // model.columns = rep.getDbColumn(selected_table);
            // model.selected_table_name = Request.Query["selected_table_name"].ToString();
            // var selected_table = Request.Query["selected_table_name"];
            // model.selected_table_name = selected_table;
            // ViewBag.selected_tabela = model.selected_table_name;
            return View(model);
        }
        
        public void listColumns()
        {
            var table = model.selected_table_name;
            // model.entity = rep.getDbColumn(table);
            // List<Entity> columns = new List<Entity>();
            // var getTable = Request.Form["selected_table_name"].ToString();
            // var columns = getTableName(getTable);
            model.columns = rep.getDbColumn(table);
        }

        public void listDataTEST()
        {
            var numColumns = rep.getDbColumn("entidade3").Count;
            model.columnNumber = numColumns;
            // var data = rep.getColumnData(0,"entidade2");
            // model.fields = data;
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