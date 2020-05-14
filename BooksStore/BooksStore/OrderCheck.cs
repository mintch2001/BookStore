using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksStore
{
    class OrderCheck
    {
        private string ISBN;
        private string Email;
        private string Quatity;
        private string TotalPrice;
        private string emailFromPick;
        private string isbnFromPick;

        private int QuatityFromCheck;
        private int TotalPriceFromCheck;
        public OrderCheck(string isbn, string email, string quatity, string totalPrice)
        {
            ISBN = isbn;
            Email = email;
            Quatity = quatity;
            TotalPrice = totalPrice;
        }
        public bool CheckNullOutput
        {
            get { return CheckNull(); }
        }
        public bool DoubleDataEmailCheckOutput
        {
            get { return DoubleDataEmailCheck(); }
        }
        public bool DoubleDataISBNCheckOutput
        {
            get { return DoubleDataISBNCheck(); }
        }
        public bool TotalPriceCheckOutput
        {
            get { return TotalPriceCheck(); }
        }
        public bool QuatityCheckOutput
        {
            get { return QuatityCheck(); }
        }
        private bool CheckNull()
        {
            bool check;
            if(ISBN == "" || Email == "" || Quatity.ToString() == "")
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
        private bool DoubleDataISBNCheck()
        {
            PickISBN();
            bool check;
            if (ISBN != isbnFromPick)
            {
                check = false;
            }
            else
            {
                check = true;
            }
            return check;
        }
        private bool TotalPriceCheck()
        {
            bool check;
            if (int.TryParse(TotalPrice,out TotalPriceFromCheck))
            {
                check = true;
            }
            else
            {
                check = false;
            }
            return check;
        }
        private bool QuatityCheck()
        {
            bool check;
            if (int.TryParse(Quatity, out QuatityFromCheck))
            {
                check = true;
            }
            else
            {
                check = false;
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
        private void PickISBN()
        {
            using (SqliteConnection dataBase = new SqliteConnection("Filename=BooksData.db"))
            {
                dataBase.Open();
                SqliteCommand commandEmail = new SqliteCommand();
                commandEmail.Connection = dataBase;
                commandEmail.CommandText = "SELECT ISBN from BookDataTable WHERE ISBN='" + ISBN + "'";

                SqliteDataReader sqliteDataReader = commandEmail.ExecuteReader();

                while (sqliteDataReader.Read())
                {
                    isbnFromPick = sqliteDataReader.GetString(0);
                }
                dataBase.Close();
            }
        }
    }
}
