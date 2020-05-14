using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BooksStore
{
    /// <summary>
    /// Interaction logic for BookRegisterPage.xaml
    /// </summary>
    public partial class BookRegisterPage : Window
    {
        public BookRegisterPage()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            BookRegisterCheck check = new BookRegisterCheck(txtISBN.Text, txtTitle.Text, txtDescription.Text, txtPrice.Text);
            if(check.CheckNullData == false)
            {
                MessageBox.Show("โปรดกรอกข้อมูลให้ครบถ้วน","เเจ้งเตือน");
            }
            else if (check.TitleCheckData == false)
            {
                MessageBox.Show("Title มีตัวอัพษรได้มากที่สุด 100 ตัวอักษร", "เเจ้งเตือน");
            }
            else if(check.DescriptionCheckData == false)
            {
                MessageBox.Show("Description มีตัวอัพษรได้มากที่สุด 500 ตัวอักษร", "เเจ้งเตือน");
            }
            else if (check.PriceCheckIntData == false)
            {
                MessageBox.Show("โปรดตั้งราคาของหนังสือเป็นตัวเลข", "เเจ้งเตือน");
            }
            else if (check.PriceCheckData == false)
            {
                MessageBox.Show("โปรดตั้งราคาของหนังสือ", "เเจ้งเตือน");
            }
            else
            {
                BooksDataRegister booksData = new BooksDataRegister(txtTitle.Text, txtDescription.Text, txtPrice.Text);
                txtISBN.Text = booksData.CreatrNumberData;
                MessageBox.Show("ลงทะเบียนหนังสือสำเร็จ !" + "\n" + "ISBN : " + booksData.CreatrNumberData, "เเจ้งเตือน");
                this.Close();
            }
        }
    }
}
