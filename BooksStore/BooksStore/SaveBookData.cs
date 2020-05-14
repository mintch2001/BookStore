using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksStore
{
    class SaveBookData
    {
        private string ISBN;
        private string Title;
        private string Description;
        private int Price;
        public SaveBookData(string isbn, string title, string description, string price)
        {
            ISBN = isbn;
            Title = title;
            Description =  description;
            Price = int.Parse(price);
            SaveData();
        }
        private void SaveData()
        {
            using (SqliteConnection dataBase = new SqliteConnection("Filename=BooksData.db"))
            {
                dataBase.Open();
                SqliteCommand commandSave = new SqliteCommand();
                commandSave.Connection = dataBase;
                commandSave.CommandText = "UPDATE BookDataTable " +
                                          "SET Title='" + Title + "', Description='" + Description + "', Price='" + Price + "' " +
                                          "WHERE ISBN='" + ISBN + "'";
                commandSave.ExecuteReader();
                dataBase.Close();
            }
        }
    }
}