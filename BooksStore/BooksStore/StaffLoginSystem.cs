using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksStore
{
    class StaffLoginSystem
    {
        private string Email;
        private string Password;
        private string EmailFromPick;
        private string PasswordFromPick;
        
        public StaffLoginSystem(string email,string password)
        {
            Email = email;
            Password = password;
            StackPick();
        }
        public bool CheckNullkOutout
        {
            get { return CheckNull(); }
        }
        public bool EmailCheckOutput
        {
            get { return EmailCheck(); }
        }
        public bool PasswordCheckOutput
        {
            get { return PasswordCheck(); }
        }      
        private bool CheckNull()
        {
            bool check;
            if (Email == "" || Password == "")
            {
                check = false;
            }
            else
            {
                check = true;
            }
            return check;
        }
        private bool EmailCheck()
        {
            bool check;
            if (Email != EmailFromPick)
            {
                check = false;
            }
            else
            {
                check = true;
            }
            return check;
        }
        private bool PasswordCheck()
        {
            bool check;
            if (Email == EmailFromPick && Password != PasswordFromPick)
            {
                check = false;
            }
            else
            {
                check = true;
            }
            return check;
        }
        private void StackPick()
        {
            PickEmail();
            PickPassword();
        }
        private void PickEmail()
        {
            using (SqliteConnection dataBase = new SqliteConnection("Filename=StaffsData.db"))
            {
                dataBase.Open();
                SqliteCommand command = new SqliteCommand();
                command.Connection = dataBase;
                command.CommandText = "SELECT Email from StaffTable WHERE Email='" + Email +"'";
                SqliteDataReader dataReader = command.ExecuteReader();
                while(dataReader.Read())
                {
                    EmailFromPick = dataReader.GetString(0);
                }    
            }
        }
        private void PickPassword()
        {
            using(SqliteConnection dataBase = new SqliteConnection("Filename=StaffsData.db"))
            {
                dataBase.Open();
                SqliteCommand command = new SqliteCommand();
                command.Connection = dataBase;
                command.CommandText = "SELECT Password from StaffTable WHERE Email='" + Email + "'";
                SqliteDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    PasswordFromPick = dataReader.GetString(0);
                }
                dataBase.Close();
            }
        }
    }
}
