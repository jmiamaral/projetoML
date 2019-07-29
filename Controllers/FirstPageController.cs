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
using System.Xml;

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
        public IActionResult InvocarWS(Provider model, string Submit)
        {         
            setDbRep();
            listTableNames(model);
            responseWS(model);
            model.columnNumber = rep.getDbColumn(model.selected_table_name).Count;
            model.columns = rep.getDbColumn(model.selected_table_name);
            model.mapButton = true;

            if(!string.IsNullOrEmpty(Submit))
            {
                model.submitButton = true;
                insertDB(model);
            }

            return View(model);
        }

        //lista dos nomes das tabelas na bd
        public void listTableNames(Provider model)
        {
            model.table_names = rep.getTableNames();
        }

        public async void responseWS(Provider model)
        {
            string isJson = "é json";
            string isSoap = "é soap";
            string invalid = "Resposta invalida json/xml";

            if(model.url != null)
            {
                using (var client = new HttpClient())
                {    
                    model.dataWs = client.GetAsync(model.url).Result.Content.ReadAsStringAsync().Result;
                }
                if (dataIsJson(model.dataWs))
                {
                    model.validateResponse = isJson;
                    model.validResponse = true;
                    model.isJson = true;
                    model.isXml = false;
                    getFieldsJson(model);
                    getDataJson(model);
                }
                else if (dataIsXml(model.dataWs))
                {
                    model.validateResponse = isSoap;
                    model.validResponse = true;
                    model.isJson = false;
                    model.isXml = true;
                    getDataXml(model);
                }
                else if (!dataIsJson(model.dataWs) && !dataIsXml(model.dataWs))
                {
                    model.validateResponse = invalid;
                    model.validResponse = false;
                }
            }
        }   
        //validar formato json
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
        //validar formato xml
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
        //obter campos json
        public void getFieldsJson(Provider model)
        {
            model.dataWs = model.dataWs.TrimStart('['); //apagar tudo na string anterior a '['
            model.dataWs = model.dataWs.TrimEnd(']').Trim(); //apagar ']' do fim e espacos existentes
          
            var firstSplit = model.dataWs.Split("}", System.StringSplitOptions.RemoveEmptyEntries); //primeiro split pela '}' para separar os valores dos varios campos
            var numberOfFields = firstSplit[0].Split(",").Length; //numero de campos
            var dataTrimmed = firstSplit[0].TrimStart('{'); //apagar '{' do inicio da string
            var dataSplit = dataTrimmed.Split(","); //separar cada campo numa string

            List<string> field = new List<string>();
            for (var i = 0; i < numberOfFields; i++)
            {
                var secondSplit = dataSplit[i].Split(":");
                secondSplit[0] = secondSplit[0].Replace("\"", ""); //remover aspas da string
                field.Add(secondSplit[0]);
            }
            model.fieldsJson = field;
        }
        //obter valores dos campos
        public void getDataJson(Provider model)
        {
            var firstSplit = model.dataWs.Split("}", System.StringSplitOptions.RemoveEmptyEntries);
            var numberFields = firstSplit.Length;
            List<string> data = new List<string>();
            int numberTitles = 0;
            for(var fields = 0; fields<numberFields; fields++)
            {
                var secondSplit = firstSplit[fields].Split(",", System.StringSplitOptions.RemoveEmptyEntries);
                numberTitles = secondSplit.Length;
                for(var titles = 0; titles<numberTitles; titles++)
                {
                    var datas = secondSplit[titles].Split(":");
                    data.Add(datas[1]);
                }
            }
            model.dataJson = data;
            model.numberTitles = numberTitles;
        }
        //obter campos xml
        public void getDataXml(Provider model)
        {
            XmlDocument Doc = new XmlDocument();
            var data = XDocument.Parse(model.dataWs);
            Doc.LoadXml(model.dataWs);
            // var teste = data.Elements(data.Elements().First().Name.LocalName);  
            var elements = data.Root.DescendantNodes().OfType<XElement>().Select(x => x.Name);
            var node = elements.First();
            string no = node.ToString();
            // string teste = node.ToString();
            // string element = elements[0];
            XmlNode nodes = Doc.GetElementsByTagName(no).Item(0);
            var list = new List<string>();
            //Loop through the child nodes
            foreach (XmlNode item in nodes.ChildNodes)
            {
                if ((item).NodeType == XmlNodeType.Element)
                {
                    //Get the Element value here
                    string value = ((item).FirstChild).Value;
                    list.Add(value);
                }        
            }
            ViewBag.teste = list;    
        }
        //inserir na base de dados
        public void insertDB(Provider model)
        {
            var tableSelected = model.selected_table_name;
            int counterTitles = model.numberTitles;
            int counterRow = 0;
            if(model.isJson)
            {      
                counterRow += rep.insertIntoDB(tableSelected, model.columnsSelected, model.dataJson);
                model.counterRow = counterRow;
                model.dataFinal = rep.getDataFinal(tableSelected, model.columnNumber);
                model.dataFinalCount = model.dataFinal.Count();
            }
        }

    }
}