using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksStore
{
    class PickPriceOfBooks
    {
        private string ISBN;
        private string Quatity;
        private string Price;
        
        public PickPriceOfBooks(string isbn,string quatity)
        {
            ISBN = isbn;
            Quatity = quatity;
        }
        public int CalculatePriceOutput
        {
            get { return CalculatePrice(); }
        }
        private int CalculatePrice()
        {
            PickPrice();
            int calculate = int.Parse(Price) * int.Parse(Quatity);
            return calculate;
        }
        private void PickPrice()
        {
            using (SqliteConnection dataBase = new SqliteConnection("Filename=BooksData.db"))
            {
                dataBase.Open();
                SqliteCommand command = new SqliteCommand();
                command.Connection = dataBase;
                command.CommandText = "SELECT Price from BookDataTable WHERE ISBN='" + ISBN + "'";
                SqliteDataReader dataReader = command.ExecuteReader();
                while(dataReader.Read())
                {
                    Price = dataReader.GetString(0);
                }
                dataBase.Close();
            }
        }
    }
}
