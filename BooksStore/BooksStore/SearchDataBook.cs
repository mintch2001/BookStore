using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksStore
{
    class SearchDataBook
    {
        private string ISBN;
        private string Title;
        private string Description;
        private int Price;
        public SearchDataBook(string isbn)
        {
            ISBN = isbn;
            StackWork();
        }
        public string TitleData
        {
            get { return Title; }
        }
        public string DescriptionData
        {
            get { return Description; }
        }
        public int PriceData
        {
            get { return Price; }
        }
        private void StackWork()
        {
            PickTitle();
            PickDescription();
            PickPrice();
        }
        private void PickTitle()
        {
            using (SqliteConnection dataBase = new SqliteConnection("Filename=BooksData.db"))
            {
                dataBase.Open();
                SqliteCommand command = new SqliteCommand("SELECT Title from BookDataTable WHERE ISBN='" + ISBN +"'",dataBase);
                SqliteDataReader dataReader = command.ExecuteReader();
                while(dataReader.Read())
                {
                    Title = dataReader.GetString(0);
                }    
            }
        }
        private void PickDescription()
        {
            using (SqliteConnection dataBase = new SqliteConnection("Filename=BooksData.db"))
            {
                dataBase.Open();
                SqliteCommand command = new SqliteCommand("SELECT Description from BookDataTable WHERE ISBN='" + ISBN + "'", dataBase);
                SqliteDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Description = dataReader.GetString(0);
                }
            }
        }
        private void PickPrice()
        {
            using (SqliteConnection dataBase = new SqliteConnection("Filename=BooksData.db"))
            {
                dataBase.Open();
                SqliteCommand command = new SqliteCommand("SELECT Price from BookDataTable WHERE ISBN='" + ISBN + "'", dataBase);
                SqliteDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Price = int.Parse(dataReader.GetString(0));
                }
            }
        }
    }
}
