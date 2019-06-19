using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace app.Models
{
    public class Provider
    {
        

        public String url { get; set; } //url referente ao WS

        public String selected_table_name { get; set; } //referencia entidade

        public List<string> table_names { get; set; } //tabelas

        // public List<Entity> entity { get; set; } = new List<Entity>();

        public List<string> columns { get; set; } //lista dos dados referentes a bd
        public List<string> fields { get; set; } //dados das colunas
        public int columnNumber { get; set; }//numero de colunas da tabela

        public String column { get; set; }
        //public List<string, string> map {get; set; } //lista de dados mapeados

        // public struct Data
        // {
        //     public Data(string str1Value, string str2Value)
        //     {
        //         string1 = str1Value;
        //         string2 = str2Value;
        //     }
        //     public string string1 { get; set; }
        //     public string string2 { get; set; }
        // }
        // public List<Data> map { get; set; }
            
    }
}