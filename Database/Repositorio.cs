using MySql.Data.MySqlClient;    
using System;    
using System.Collections.Generic;    
using Microsoft.AspNetCore.Mvc.Rendering;

    
namespace app.Database    
{    
    public class Repositorio    
    {    
        public string ConnectionString { get; set; }    
    
        public Repositorio(string connectionString)    
        {    
            this.ConnectionString = connectionString;    
        }    
    
        private MySqlConnection GetConnection()    
        {    
            return new MySqlConnection(ConnectionString);    
        }

        
        public List<string> getTableNames()
        {
            List<string> table_names = new List<string>();

            using (MySqlConnection conn = GetConnection())  
        {  
            conn.Open();  
            MySqlCommand cmd = new MySqlCommand("SELECT table_name FROM information_schema.tables where table_schema='projeto'", conn);  
    
            using (var reader = cmd.ExecuteReader())  
            {  
                while (reader.Read())  
                {  
                    var val = reader["table_name"].ToString();
                    table_names.Add(  val);
                }  
            }  
        }  
        return table_names;  
        }    
        
        public List<string> getDbColumn(String value)
        {
            List<string> columns = new List<string>();

            using (MySqlConnection conn = GetConnection())  
        {  
            conn.Open();  
            MySqlCommand cmd = new MySqlCommand("SELECT column_name FROM information_schema.columns where table_schema='projeto' and table_name = '" + value +"'" ,conn);  

            using (var reader = cmd.ExecuteReader())  
            {  
                while (reader.Read())  
                {  
                    var column = reader["column_name"].ToString();
                    columns.Add(column);
                }  
            }  
        }  
        return columns;  
        }    

        // public List<string> getColumnData(int column, string entity)
        // {
        //     List<string> entityColumns = getDbColumn(entity);
        //     List<string> result = new List<string>();

        //     using (MySqlConnection conn = GetConnection())  
        // {  
        //     conn.Open();  
        //     MySqlCommand cmd = new MySqlCommand("select '" + entityColumns.get(column) + "' from projeto.'" + entity + "'" ,conn);  

        //     using (var reader = cmd.ExecuteReader())  
        //     {  
        //         while (reader.Read())  
        //         {  
        //             var data = reader[entityColumns[column]].ToString();
        //             result.Add(data);
        //         }  
        //     }  
        // }  
        // return result; 

        // }
    }    
}  