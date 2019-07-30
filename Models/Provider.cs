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
        public List<string> fieldsWs { get; set; } //campos do ws
        public List<string> dataFieldWs { get; set; } //dados dos campos
        public Boolean isJson { get; set; }
        public Boolean isXml { get; set; }
        public int numberTitles { get; set; } //numero titulos ex: "id" "title"
        public String[] columnsSelected { get; set; }

        public Boolean mapButton { get; set; } //estado butao map 
        public Boolean submitButton { get; set; } //estado butao submit
        
        public List<string> teste { get; set; }

        //relativo a bd
        [Required]
        public String selected_table_name { get; set; } //referencia entidade
        public List<string> table_names { get; set; } //tabelas
        public int columnNumber { get; set; }//numero de colunas da tabela
        public String column { get; set; }
        public List<string> columns { get; set; } //colunas da tabela
        public int counterRow { get; set; } //numero de rows afetadas
        public List<string> dataFinal {get; set; } //dados atualizados
        public int dataFinalCount {get; set; }//numero total de valores na tabela
            
    }
}