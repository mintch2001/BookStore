using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksStore
{
    class SearchDataCustomersCheck
    {
        private string Email;
        private string emailFromPick;
        public SearchDataCustomersCheck(string email)
        {
            Email = email;
        }
        public bool CheckNull
        {
            get { return EmailCheckNull(); }
        }
        public bool CheckDoubleEmail
        {
            get { return DoubleDataEmailCheck(); }
        }
        private bool EmailCheckNull()
        {
            bool check;
            if(Email == "")
            {
                check = false;
            }
            else
            {
                check = true;
            }
            return check;
        }
        private bool DoubleDataEmailCheck()
        {
            PickEmail();
            bool check;
            if (Email != emailFromPick)
            {
                check = false;
            }
            else
            {
                check = true;
            }
            return check;
        }
        private void PickEmail()
        {
            using (SqliteConnection dataBase = new SqliteConnection("Filename=CustomersData.db"))
            {
                dataBase.Open();
                SqliteCommand commandEmail = new SqliteCommand();
                commandEmail.Connection = dataBase;
                commandEmail.CommandText = "SELECT Email from Customers WHERE Email='" + Email + "'";

                SqliteDataReader sqliteDataReader = commandEmail.ExecuteReader();

                while (sqliteDataReader.Read())
                {
                    emailFromPick = sqliteDataReader.GetString(0);
                }
                dataBase.Close();
            }

        }
    }
}
