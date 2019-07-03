using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using app.Models;
using app.Database;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Xml.Linq;

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
            listTableNames(model);

            return View(model);
        }
        
        [HttpPost]
        public IActionResult InvocarWS(Provider model)
        {         
            setDbRep();
            listTableNames(model);
            // GetUrlData(model);
            responseWS(model);
            model.columnNumber = rep.getDbColumn(model.selected_table_name).Count;
            model.columns = rep.getDbColumn(model.selected_table_name);
            // getFields(model);

            // listColumns(model);
            return View(model);
        }

        //lista dos nomes das tabelas na bd
        public void listTableNames(Provider model)
        {
            model.table_names = rep.getTableNames();
        }


        public async void responseWS(Provider model)
        {
            string url = model.url;
            string dataWs = model.dataWs;
            string isJson = "é json";
            string isSoap = "é soap";
            string invalid = "Resposta invalida json/xml";

            using (var client = new HttpClient())
            {
                model.dataWs = client.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
            
                // HttpResponseMessage response = await client.GetAsync(url);
                // response.EnsureSuccessStatusCode();
                // model.dataWs = await response.Content.ReadAsStringAsync().Result;
            }
            if (dataIsJson(model.dataWs) && !dataIsXml(model.dataWs))
            {
                model.validateResponse = isJson;
                model.validResponse = true;
            }
            else if (!dataIsJson(model.dataWs) && dataIsXml(model.dataWs))
            {
                model.validateResponse = isSoap;
                model.validResponse = true;
            }
            else
            {
                model.validateResponse = invalid;
                model.validResponse = false;
            }

            getFieldsJson(model);

        }   

        public Boolean dataIsJson(String data)
        {
            data = data.Trim();
            if ((data.StartsWith("{") && data.EndsWith("}")) || //For object
                (data.StartsWith("[") && data.EndsWith("]"))) //For array
            {
                try
                {
                    var obj = JToken.Parse(data);
                    return true;
                }
                catch (JsonReaderException jex)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public Boolean dataIsXml(String data)
        {
            if (!string.IsNullOrEmpty(data) && data.TrimStart().StartsWith("<"))
            {
                try
                {
                    XDocument.Parse(data);
                    return true;
                }   
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;   
            }
        }

        public void getFieldsJson(Provider model)
        {
            // data = model.url;
            // var fields;
            string[] words = model.dataWs.Split(':');
            model.fields = words.ToList();

        }



    }
}