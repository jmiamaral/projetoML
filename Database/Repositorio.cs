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
                table_names.Add(  

                    reader["table_name"].ToString());    

            }  
        }  
    }  
    return table_names;  
    }    
    }    
}  