using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksStore
{
    class OrderBook
    {
        private string ISBN;
        private string Email;
        private string Quatity;
        private int TotalPrice;

        public OrderBook(string isbn,string email,string quatity,string totalPrice)
        {
            ISBN = isbn;
            Email = email;
            Quatity = quatity;
            TotalPrice = int.Parse(totalPrice);
        }
        private void StackWork()
        {
            CreateTableTransactions();
            WriteDataToTable();
        }
        private void CreateTableTransactions()
        {
            using(SqliteConnection dataBase = new SqliteConnection("Filename=TransactionsTable"))
            {
                dataBase.Open();
                String tableCommand = "CREATE TABLE IF NOT, " +
                                      "EXISTS Transactions (ISBN NVACHAR(14),Email NVACHAR(50),Quatity INTEGER,TotalPrice INTEGER)";
                SqliteCommand sqliteCommand = new SqliteCommand(tableCommand, dataBase);
                sqliteCommand.ExecuteReader();
            }
        }
        private void WriteDataToTable()
        {
            using(SqliteConnection dataBase = new SqliteConnection("Filename=TransactionsTable"))
            {
                dataBase.Open();
                SqliteCommand command = new SqliteCommand();
                command.Connection = dataBase;
                command.CommandText = "INSERT INTO Transactions VALUES(@ISBN,@Email,@Quatity,@TotalPrice)";
                command.Parameters.AddWithValue("@ISBN",ISBN);
                command.Parameters.AddWithValue("@Email",Email);
                command.Parameters.AddWithValue("@Quatity",Quatity);
                command.Parameters.AddWithValue("@TotalPrice",TotalPrice);
                SqliteDataReader dataReader = command.ExecuteReader();
                dataBase.Close();
            }
        }
    }
}
