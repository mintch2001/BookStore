using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksStore
{
    class BookRegisterCheck
    {
        private string ISBN;
        private string Title;
        private string Description;
        private string Price;
        private int PricrFromCheckInt;
        public BookRegisterCheck (string isbn,string title,string description,string price)
        {
            ISBN = isbn;
            Title = title;
            Description = description;
            Price = price;
        }
        public bool CheckNullData
        {
            get { return CheckNull(); }
        }
        public bool TitleCheckData
        {
            get { return TitleCheck(); }
        }
        public bool DescriptionCheckData
        {
            get { return DescriptionCheck(); }
        }
        public bool PriceCheckIntData
        {
            get { return PriceCheckInt(); }
        }
        public bool PriceCheckData
        {
            get { return PriceCheck(); }
        }
        private bool CheckNull()
        {
            bool check;
            if (Title == "" || Description == "" || Price.ToString() == "")
            {
                check = false;
            }
            else
            {
                check = true;
            }
            return check;
        }
        private bool TitleCheck()
        {
            bool check;
            if (Title.Length > 100)
            {
                check = false;
            }
            else
            {
                check = true;
            }
            return check;
        }
        private bool DescriptionCheck()
        {
            bool check;
            if (Description.Length > 500)
            {
                check = false;
            }
            else
            {
                check = true;
            }
            return check;
        }
        private bool PriceCheckInt()
        {
            bool check;
            if (int.TryParse(Price,out PricrFromCheckInt)) //ตรวจสอบว่าค่าที่รับมาใช่ int หรือไม่
            {
                check = true;
            }
            else
            {
                check = false;
            }
            return check;
        }
        private bool PriceCheck()
        {
            bool check;
            if (PricrFromCheckInt <= 0)
            {
                check = false;
            }
            else
            {
                check = true;
            }
            return check;
        }     
    }
}
