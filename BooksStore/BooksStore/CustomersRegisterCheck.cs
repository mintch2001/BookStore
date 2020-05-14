using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksStore
{
    class CustomersRegisterCheck
    {
        private string Email;
        private string Name;
        private string Surname;
        private string IDCard;
        private string Address;
        private string emailFromPick;

     
        public CustomersRegisterCheck (string email,string name,string surname,string idcard,string address)
        {
            Email = email;
            Name = name;
            Surname = surname;
            IDCard = idcard;
            Address = address;
        }
        public bool CheckNullOutput
        {
            get { return CheckNull(); }
        }
        public bool EmailCheckCountOutput
        {
            get { return EmailCheckCount(); }
        }
        public bool NameCheckCountOutput
        {
            get { return NameCheckCount(); }
        }
        public bool SurnameCheckCountOutput
        {
            get { return SurnameCheckCount(); }
        }
        public bool IDCardCheckCountOutput
        {
            get { return IDCardCheckCount(); }
        }
        public bool AddressCheckCountOutput
        {
            get { return AddressCheckCount(); }
        }
        public bool CheckDoubleEmail
        {
            get { return DoubleDataEmailCheck(); }
        }
        private bool CheckNull()
        {
            bool check;
            if (Email == "" || Name == "" || Surname == "" ||IDCard == "" || Address == "")
            {
                check = false;
            }
            else
            {
                check = true;
            }
            return check;
        }
        private bool EmailCheckCount()
        {
            bool check;
            if (Email.Length > 50)
            {
                check = false;
            }
            else
            {
                check = true;
            }
            return check;
        }
        private bool NameCheckCount()
        {
            bool check;
            if (Name.Length > 30)
            {
                check = false;
            }
            else
            {
                check = true;
            }
            return check;
        }
        private bool SurnameCheckCount()
        {
            bool check;
            if (Surname.Length > 30)
            {
                check = false;
            }
            else
            {
                check = true;
            }
            return check;
        }
        private bool IDCardCheckCount()
        {
            bool check;
            if (IDCard.Length < 12 || IDCard.Length > 14)
            {
                check = false;
            }
            else
            {
                check = true;
            }
            return check;
        }
        private bool AddressCheckCount()
        {
            bool check;
            if (Address.Length > 301)
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
            if (Email == emailFromPick)
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
