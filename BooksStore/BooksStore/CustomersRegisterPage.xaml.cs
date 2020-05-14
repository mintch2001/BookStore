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
    /// Interaction logic for CustomersRegisterPage.xaml
    /// </summary>
    public partial class CustomersRegisterPage : Window
    {
        public CustomersRegisterPage()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            CustomersRegisterCheck registerCheck = new CustomersRegisterCheck(txtEmail.Text, txtName.Text, txtSurname.Text, txtIDCard.Text, txtAddress.Text);
            if (registerCheck.CheckNullOutput == false)
            {
                MessageBox.Show("โปรดกรอกข้อมูลให้ครบถ้วน");
            }
            else if (registerCheck.CheckDoubleEmail == false)
            {
                MessageBox.Show("Email นี้ถูกใช้งานไปแล้ว");
            }
            else if (registerCheck.EmailCheckCountOutput == false)
            {
                MessageBox.Show("Email ควรมีตัวอักษรไม่เกิน 50 ตัวอักษร");
            }
            else if (registerCheck.NameCheckCountOutput == false)
            {
                MessageBox.Show("ชื่อควรมีตัวอักษรไม่เกิน 30 ตัว");
            }
            else if (registerCheck.SurnameCheckCountOutput == false)
            {
                MessageBox.Show("นามสกุลควรมีตัวอักษรไม่เกิน 30 ตัว");
            }
            else if (registerCheck.IDCardCheckCountOutput == false)
            {
                MessageBox.Show("หมายเลขบัตรประชาชนประกอบด้วยหมายเลข 13 หลัก");
            }
            else if (registerCheck.AddressCheckCountOutput == false)
            {
                MessageBox.Show("ที่อยู่สามารถกรอกได้ไม่เกิน 300 ตัวอักษร");
            }
            else
            {
                CustomersRegisterSystem customersRegister = new CustomersRegisterSystem(txtEmail.Text, txtName.Text, txtSurname.Text, txtIDCard.Text, txtAddress.Text);
                MessageBox.Show("ทำการลงทะเบียนเรียบร้อย");
                this.Close();
            }
        }
    }
}
