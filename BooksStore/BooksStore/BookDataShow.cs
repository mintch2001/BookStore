using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksStore
{
    class BookDataShow
    {
        private List<string> Data;        
        public BookDataShow ()
        {
            PickData();
            
        }
        public List<string> ReturnData
        {
            get { return Data; }
        }       
        private void PickData()
        {
            Data = new List<string>();
            using (SqliteConnection dataBase = new SqliteConnection("Filename=BooksData.db"))
            {
                dataBase.Open();
                SqliteCommand data = new SqliteCommand("SELECT ISBN,Title from BookDataTable",dataBase);
                
                SqliteDataReader isbnDataReader = data.ExecuteReader();             
                while (isbnDataReader.Read())
                {
                    Data.Add(isbnDataReader.GetString(0) + "| Title : " + isbnDataReader.GetString(1));
                }
                dataBase.Close();
            }
        }       
    }
}
