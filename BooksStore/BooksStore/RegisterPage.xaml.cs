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
    /// Interaction logic for RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Window
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            StaffCheckRegister check = new StaffCheckRegister(txtEmail.Text,txtPassword0.Password,txtPassword1.Password,txtIDCard.Text,txtAddress1.Text);
            if (check.CheckNullOutput == false)
            {
                MessageBox.Show("โปรดกรอกข้อมูลให้ครบถ้วน");
            }
            else if (check.EmailCheckCountOutput == false)
            {
                MessageBox.Show("Email ควรมีข้อความไม่เกิน 50 ตัวอักษร");
            }
            else if (check.PasswordCheckCountOutput == false)
            {
                MessageBox.Show("Password ต้องมีตัวอักษรตั้งแต่ 5 ถึง 20 ตัว");
            }
            else if (check.PasswordCheckOutput == false)
            {
                MessageBox.Show("รหัสผ่านไม่ตรงกัน");
            }
            else if (check.IDCardCheckCountOutput == false)
            {
                MessageBox.Show("หมายเลขบัตรประชาชนประกอบด้วยหมายเลข 13 หลัก");
            }
            else if (check.AddressCheckCountOutput == false)
            {
                MessageBox.Show("ที่อยู่สามารถกรอกได้ไม่เกิน 300 ตัวอักษร");
            }
            else if (check.CheckDoubleEmail == false)
            {
                MessageBox.Show("Email นี้ถูกใช้งานไปแล้ว");
            }
            else
            {
                StaffRegisterSystem register = new StaffRegisterSystem(txtEmail.Text, txtPassword0.Password, txtIDCard.Text, txtAddress1.Text);
                MessageBox.Show("สมัครสมาชิกเเรียบร้อย");
                this.Close();
            }
        }
    }
}
