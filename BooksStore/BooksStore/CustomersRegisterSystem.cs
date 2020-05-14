using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksStore
{
    class CustomersRegisterSystem
    {

        private string Email;
        private string Name;
        private string Surname;
        private string IDCard;
        private string Address;
        public CustomersRegisterSystem(string email, string name,string surname ,string idcard, string address)
        {
            Email = email;
            Name = name;
            Surname = surname;
            IDCard = idcard;
            Address = address;
            WriteData();
        }
        private void WriteData()
        {
            CreateTable();
            WriteDataToTable();
        }
        private void CreateTable()
        {
            using(SqliteConnection dataBase = new SqliteConnection("Filename=CustomersData.db"))
            {
                dataBase.Open();
                String tableCommand = "CREATE TABLE IF NOT " +
                                      "EXISTS Customers (Email NVACHAR(50) Primary Key,Name NVACHAR(30),Surname NVACHAR(30),ID_Card NVACHAR(13),Address NVACHAR(300))";
                SqliteCommand sqliteCommand = new SqliteCommand(tableCommand, dataBase);
                sqliteCommand.ExecuteReader();
            }
        }
        private void WriteDataToTable()
        {
            using (SqliteConnection dataBase = new SqliteConnection("Filename=CustomersData.db"))
            {
                dataBase.Open();
                SqliteCommand sqliteCommand = new SqliteCommand();
                sqliteCommand.Connection = dataBase;

                sqliteCommand.CommandText = "INSERT INTO Customers VALUES (@Email,@Name,@Surname,@ID_Card,@Address)";
                sqliteCommand.Parameters.AddWithValue("@Email", Email);
                sqliteCommand.Parameters.AddWithValue("@Name", Name);
                sqliteCommand.Parameters.AddWithValue("@Surname", Surname);
                sqliteCommand.Parameters.AddWithValue("@ID_Card", IDCard);
                sqliteCommand.Parameters.AddWithValue("@Address", Address);

                sqliteCommand.ExecuteReader();
                dataBase.Close();
            }
        }
    }
}
