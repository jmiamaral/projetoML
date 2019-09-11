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
using System.Xml.XPath;

namespace app.Controllers
{
    //[Route("api/[controller]")]
    public class ProjetoController : Controller
    {
        Repositorio rep;
        Provider model;
        
        public void setDbRep()
        {
            if (rep == null)
                rep = HttpContext.RequestServices.GetService(typeof(Repositorio)) as Repositorio;
        }
        //get invocar ws
        public ActionResult InvocarWS()
        {
            setDbRep();
            model = new Provider();
            listTableNames(model);
            // model.InvokeWsProvider.teste= "yay";
            return View(model);
        }
        //post invocar ws
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
            model.fieldsWs = field;
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
            model.dataFieldWs = data;
            model.numberTitles = numberTitles;
        }
        //obter campos xml
        public void getDataXml(Provider model)
        {
            XDocument data = XDocument.Parse(model.dataWs);
            var elements = data.Root.DescendantNodes().OfType<XElement>().Select(x => x.Name).Distinct();
            var root = elements.First();
            string firstElement = root.ToString();
            var elements_ = data.Root.Element(firstElement).DescendantNodes().OfType<XElement>().Select(x => x.Name).Distinct();
            List<string> elementsModel = new List<string>();
            foreach(var i in elements_)
            {
                var eleString = i.ToString();
                elementsModel.Add(eleString);
            }
            model.fieldsWs = elementsModel; //popular variavel com os campos

            var descendants = data.Descendants(firstElement);
            List<string> elementValue = new List<string>();

            foreach (var node in descendants) 
            {
                var children = node.Elements(); 
                foreach (var child in children)
                {
                    elementValue.Add(child.Value.ToString());
                }
            }
            for(var index = 0; index < elementValue.Count; index++)
            {
                 if (!isNumber(elementValue[index])) //entra se o valor nao for um inteiro
                 {
                     elementValue[index] = "\"" + elementValue[index] + "\""; //adicionar aspas para poder inserir na bd como string
                 }
            }
            model.dataFieldWs = elementValue;
        }

        // Retorna falso se encontrar algum carater alem de numeros else true 
        static bool isNumber(string s) 
        { 
            for (int i = 0; i < s.Length; i++) 
            if (char.IsDigit(s[i]) == false) 
                return false; 
            return true; 
        } 

        //inserir na base de dados
        public void insertDB(Provider model)
        {
            var tableSelected = model.selected_table_name;
            int counterTitles = model.numberTitles;
            int counterRow = 0;
            counterRow += rep.insertIntoDB(tableSelected, model.columnsSelected, model.dataFieldWs);
            model.counterRow = counterRow;
            model.dataFinal = rep.getDataFinal(tableSelected, model.columnNumber);
            model.dataFinalCount = model.dataFinal.Count();
        }

        //get gerar ws
        public ActionResult GerarWS()
        {
            setDbRep();
            model = new Provider();
            listTableNames(model);
            return View(model);
        }
        //post gerar ws
        [HttpPost]
        public IActionResult GerarWS(Provider model)
        {         
            setDbRep();
            listTableNames(model);
            model.columnNumber = rep.getDbColumn(model.selected_table_name).Count;
            model.columns = rep.getDbColumn(model.selected_table_name);
            model.submitButton = true;
            if(model.selected_protocol != null)
            {
                model.dataFinal = rep.getDataFinal(model.selected_table_name, model.columnNumber);
                if(model.selected_protocol.Equals("rest"))
                {
                    jsonConvert(model);
                }
                else
                {
                    soapConvert(model);
                }
            }
            
            return View(model);
        }

        public void jsonConvert(Provider model)
        {
            model.isJson = true;
            List<string> list = new List<string>();
            int dataCountLast = model.dataFinal.Count - 1;
            int columnCountLast = model.columnNumber - 1;
            var str = "";
            list.Add("{");
            for (var data = 0; data < model.dataFinal.Count; data+=0)
            {
                str += "{";
                for(var column = 0; column < model.columnNumber; column++)
                {
                            
                    if(column >= columnCountLast)
                    {
                        str += model.columns[column] + " : " + model.dataFinal[data++] + "},";
                        list.Add(str);
                    }    
                    else
                    {
                        str += model.columns[column] + " : " + model.dataFinal[data++] + ", ";
                    }
                }
                str = "";       
            }
            list.Add("}");
            model.dataFormatJson = JsonConvert.SerializeObject(list);
            model.dataFormatJsonList= list;
        }

        public void soapConvert(Provider model)
        {
            int columnCount = model.columnNumber;

            model.isXml = true;
            XDocument xml = new XDocument();
            XElement root = new XElement("Entity");
            xml.Add(root);
            for(var data = 0; data < model.dataFinal.Count; data += 0)
            {
                XElement element = new XElement(model.selected_table_name, "");
                root.Add(element);
                for(var column = 0; column < columnCount; column++)
                {
                    if(model.dataFinal[data].Equals("null"))
                    {
                        XElement elementChild = new XElement(model.columns[column]);
                        element.Add(elementChild);
                        data++;
                    }
                    else
                    {
                        XElement elementChild = new XElement(model.columns[column], model.dataFinal[data++]);
                        element.Add(elementChild);
                    }
                }
            }
            model.dataFormatXml = xml.ToString();

        }
    }
}