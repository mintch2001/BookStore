using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksStore
{
    class BooksDataRegister
    {
        private string ISBN;
        private string Title;
        private string Description;
        private int Price;

        public BooksDataRegister(string title,string description,string price)
        {
            ISBN = CreateISBN();
            Title = title;
            Description = description;
            Price = int.Parse(price);
            WriteData();
        }
        public string CreatrNumberData
        {
            get { return CreateISBN(); }
        }
        private void WriteData()
        {
            CreateTable();
            WriteDataToTable();
        }
        private void CreateTable()
        {
            using (SqliteConnection dataBase = new SqliteConnection("Filename=BooksData.db"))
            {
                dataBase.Open();
                String tableCommand = "CREATE TABLE IF NOT " +
                                      "EXISTS BookDataTable (ISBN NVACHAR(14) Primary Key," +
                                      "Title NVACHAR(100)," +
                                      "Description NVACHAR(500)," +
                                      "Price INTEGER)";
                SqliteCommand sqlite = new SqliteCommand(tableCommand, dataBase);
                sqlite.ExecuteReader();
            }
        }
        private void WriteDataToTable()
        {
            using (SqliteConnection dataBase = new SqliteConnection("Filename=BooksData.db"))
            {
                dataBase.Open();
                SqliteCommand command = new SqliteCommand();
                command.Connection = dataBase;
                command.CommandText = "INSERT INTO BookDataTable VALUES (@ISBN,@Title,@Description,@Price)";
                command.Parameters.AddWithValue("@ISBN", ISBN);
                command.Parameters.AddWithValue("@Title", Title);
                command.Parameters.AddWithValue("@Description", Description);
                command.Parameters.AddWithValue("@Price", Price);
                command.ExecuteReader();
                dataBase.Close();
            }
        }
        private string CreateISBN()
        {
            Random RandomNumber = new Random();
            int num1 = RandomNumber.Next(0, 9);
            int num2 = RandomNumber.Next(0, 9);
            int num3 = RandomNumber.Next(0, 9);
            int num4 = RandomNumber.Next(0, 9);
            int num5 = RandomNumber.Next(0, 9);
            int num6 = RandomNumber.Next(0, 9);
            string CreateNumber0 = num1.ToString() + num2.ToString() + num3.ToString();
            string CreateNumber1 = num4.ToString() + num5.ToString() + num6.ToString();
            string isbn = "974-" + CreateNumber0 + "-" + CreateNumber1 + "-" + num3;
            return isbn;
        }
    }
}
