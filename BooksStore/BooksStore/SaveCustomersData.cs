using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksStore
{  
    class SaveCustomersData
    {
        private string Email;
        private string Name;
        private string Surname;
        private string IDCard;
        private string Address;
        public SaveCustomersData(string email, string name, string surname, string idcard, string address)
        {
            Email = email;
            Name = name;
            Surname = surname;
            IDCard = idcard;
            Address = address;
            SaveData();
        }
        private void SaveData()
        {
            using (SqliteConnection dataBase = new SqliteConnection("Filename=CustomersData.db"))
            {
                dataBase.Open();
                SqliteCommand commandSave = new SqliteCommand();
                commandSave.Connection = dataBase;
                commandSave.CommandText = "UPDATE Customers " +
                                          "SET Name='" + Name + "', Surname='" + Surname + "', ID_Card='" + IDCard + "', Address='" + Address +"' " +
                                          "WHERE Email='" + Email + "'";
                commandSave.ExecuteReader();
                dataBase.Close();
            }
        }
    }
}
