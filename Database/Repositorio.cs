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

        public int insertIntoDB(String table, String[] columns, List<string> data)
        {
            var rowsAffected = 0;
            int numberColumns = columns.Length;
            String[] dataInsert = new String[numberColumns];
            using (MySqlConnection conn = GetConnection())  
            {  
                conn.Open();  
                for(int value = 0; value < data.Count; value++)
                {
                    for(int dataRow = 0; dataRow < numberColumns; dataRow++)
                    {
                        dataInsert[dataRow] = data[value++];
                    }
                    var teste1 = string.Join("," , columns);
                    var teste2 = string.Join("," , dataInsert);
                    MySqlCommand cmd = new MySqlCommand("Insert Into projeto." + table + "(" + teste1 + ") Values( " + teste2 + " )",conn);
                    rowsAffected += cmd.ExecuteNonQuery(); 
                    value--;
                }
            }
            return rowsAffected;
        }

        // public List<string> selectDB(string table)
        // {
        //     List<string> data = new List<string>();

        //     using (MySqlConnection conn = GetConnection())  
        //     {  
        //         conn.Open();  
                
        //            MySqlCommand cmd = new MySqlCommand("Select * from projeto." + table ,conn);
        //            cmd.ExecuteNonQuery(); 
                
        //     }
        // }
    }    
}  