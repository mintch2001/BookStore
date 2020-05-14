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
    /// Interaction logic for CustomersEditPage.xaml
    /// </summary>
    public partial class CustomersEditPage : Window
    {
        public CustomersEditPage()
        {
            InitializeComponent();
        }        
        private void SearchDataButton_Click(object sender, RoutedEventArgs e)
        {

            SearchDataCustomersCheck dataCustomersCheck = new SearchDataCustomersCheck(txtEmail.Text);
            if(dataCustomersCheck.CheckNull == false)
            {
                MessageBox.Show("โปรดกรอกข้อมูลที่ช่อง Email");
            }
            else if (dataCustomersCheck.CheckDoubleEmail == false)
            {
                MessageBox.Show("ไม่พบอีกเมลนี้ในระบบ");
            }
            else
            {
                txtEmail.IsEnabled = false;
                txtName.IsEnabled = true;
                txtSurname.IsEnabled = true;
                txtIDCard.IsEnabled = true;
                txtAddress.IsEnabled = true;
                SearchDataCustomers searchData = new SearchDataCustomers(txtEmail.Text);
                txtName.Text = searchData.NameOutput;
                txtSurname.Text = searchData.SurnameOutput;
                txtIDCard.Text = searchData.IDCardOutput;
                txtAddress.Text = searchData.AddressOutput;
            }         
        }
        private void SaveButton_Click_1(object sender, RoutedEventArgs e)
        {
            CustomersRegisterCheck registerCheck = new CustomersRegisterCheck(txtEmail.Text, txtName.Text, txtSurname.Text, txtIDCard.Text, txtAddress.Text);
            if (registerCheck.CheckNullOutput == false)
            {
                MessageBox.Show("โปรดกรอกข้อมูลให้ครบถ้วน");
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
                SaveCustomersData save = new SaveCustomersData(txtEmail.Text, txtName.Text, txtSurname.Text, txtIDCard.Text, txtAddress.Text);
                MessageBox.Show("บันทึกข้อมูลเรียบร้อย");
                this.Close();
            }
        }
    }
}
