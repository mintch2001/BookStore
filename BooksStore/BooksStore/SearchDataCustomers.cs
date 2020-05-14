using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksStore
{
    class SearchDataCustomers
    {
        private string Email;
        private string Name;
        private string Surname;
        private string IDCard;
        private string Address;
        public SearchDataCustomers(string email)
        {
            Email = email;
            StackWorkMethod();           
        }
        public string NameOutput
        {
            get { return Name; }
        }
        public string SurnameOutput
        {
            get { return Surname; }
        }
        public string IDCardOutput
        {
            get { return IDCard; }
        }
        public string AddressOutput
        {
            get { return Address; }
        }
        private void StackWorkMethod()
        {
            SearchName();
            SearchSurname();
            SearchIDCard();
            SearchAddress();
        }     
        private void SearchName()
        {
            using(SqliteConnection dataBase = new SqliteConnection("Filename=CustomersData.db"))
            {
                dataBase.Open();
                SqliteCommand name = new SqliteCommand();
                name.Connection = dataBase;
                name.CommandText = "SELECT Name from Customers WHERE Email='" + Email +"'";
                SqliteDataReader nameOutput = name.ExecuteReader();
                while(nameOutput.Read())
                {
                    Name = nameOutput.GetString(0);
                }    
            }
        }
        private void SearchSurname()
        {
            using (SqliteConnection dataBase = new SqliteConnection("Filename=CustomersData.db"))
            {
                dataBase.Open();
                SqliteCommand surname = new SqliteCommand();
                surname.Connection = dataBase;
                surname.CommandText = "SELECT Surname from Customers WHERE Email='" + Email + "'";
                SqliteDataReader surnameOutput = surname.ExecuteReader();
                while (surnameOutput.Read())
                {
                    Surname = surnameOutput.GetString(0);
                }
            }
        }
        private void SearchIDCard()
        {
            using (SqliteConnection dataBase = new SqliteConnection("Filename=CustomersData.db"))
            {
                dataBase.Open();
                SqliteCommand idCard = new SqliteCommand();
                idCard.Connection = dataBase;
                idCard.CommandText = "SELECT ID_Card from Customers WHERE Email='" + Email + "'";
                SqliteDataReader idCardOutput = idCard.ExecuteReader();
                while (idCardOutput.Read())
                {
                    IDCard = idCardOutput.GetString(0);
                }
            }
        }
        private void SearchAddress()
        {
            using (SqliteConnection dataBase = new SqliteConnection("Filename=CustomersData.db"))
            {
                dataBase.Open();
                SqliteCommand address = new SqliteCommand();
                address.Connection = dataBase;
                address.CommandText = "SELECT Address from Customers WHERE Email='" + Email + "'";
                SqliteDataReader addressOutput = address.ExecuteReader();
                while (addressOutput.Read())
                {
                    Address = addressOutput.GetString(0);
                }
            }
        }

    }
}
