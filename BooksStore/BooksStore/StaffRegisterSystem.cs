using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksStore
{
    class StaffRegisterSystem
    {
        private string Email;
        private string Password;      
        private string IDCard;
        private string Address;
        public StaffRegisterSystem(string email, string password, string idcard, string address)
        {
            Email = email;
            Password = password;
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
            using (SqliteConnection dataBase = new SqliteConnection("Filename=StaffsData.db"))
            {
                dataBase.Open();
                String tableCommand = "CREATE TABLE IF NOT " +
                                      "EXISTS StaffTable (Email NVACHAR(50) Primary Key," +
                                      "Password NVACHAR(20)," +
                                      "ID_Card NVACHAR(13)," +
                                      "Address NVACHAR(50))";
                SqliteCommand sqliteCommand = new SqliteCommand(tableCommand, dataBase);
                sqliteCommand.ExecuteReader();
            }
        }
        private void WriteDataToTable()
        {
            using (SqliteConnection dataBase = new SqliteConnection("Filename=StaffsData.db"))
            {
                dataBase.Open();
                SqliteCommand sqliteCommand = new SqliteCommand();
                sqliteCommand.Connection = dataBase;

                sqliteCommand.CommandText = "INSERT INTO StaffTable VALUES (@Email,@Password,@ID_Card,@Address)";
                sqliteCommand.Parameters.AddWithValue("@Email", Email);
                sqliteCommand.Parameters.AddWithValue("@Password", Password);
                sqliteCommand.Parameters.AddWithValue("@ID_Card", IDCard);
                sqliteCommand.Parameters.AddWithValue("@Address", Address);

                sqliteCommand.ExecuteReader();
                dataBase.Close();
            }
        }
    }
}
