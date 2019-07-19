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
        //relativo a ws
        [Required]
        public String url { get; set; } //url referente ao WS
        public String dataWs { get; set; } //resposta ws
        public String validateResponse { get; set; }
        public Boolean validResponse { get; set; }
        public List<string> fieldsJson { get; set; } //campos do ws
        public String[] teste { get; set; }


        //relativo a bd
        [Required]
        public String selected_table_name { get; set; } //referencia entidade
        public List<string> table_names { get; set; } //tabelas
        public int columnNumber { get; set; }//numero de colunas da tabela
        public String column { get; set; }
        public List<string> columns { get; set; } //colunas da tabela

        // public List<Entity> entity { get; set; } = new List<Entity>();

        // public List<string> fields { get; set; } //dados das colunas
 
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