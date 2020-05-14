using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BooksStore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            RegisterPage registerPage = new RegisterPage();
            registerPage.Show();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            StaffLoginSystem login = new StaffLoginSystem(txtEmail.Text,txtPassword.Password);
            if (login.CheckNullkOutout == false)
            {
                MessageBox.Show("โปรดกรอกข้อมูลให้ครบถ้วน");
            }
            else if (login.EmailCheckOutput == false)
            {
                MessageBox.Show("ไม่พบ User นี้ในระบบ");
            }
            else if (login.PasswordCheckOutput == false)
            {
                MessageBox.Show("รหัสผ่านไม่ถูกต้อง โปรดรองใหม่อีกครั้ง");
            }
            else if (login.EmailCheckOutput == true && login.PasswordCheckOutput == true)
            {
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                this.Close();
            }
        }

        private void ClearLogin_Click(object sender, RoutedEventArgs e)
        {
            using (SqliteConnection dataBase = new SqliteConnection("Filename=StaffsData.db"))
            {
                dataBase.Open();
                SqliteCommand command = new SqliteCommand("DELETE FROM StaffTable", dataBase);
                command.ExecuteReader();
                dataBase.Close();
            }
            MessageBox.Show("Clear staff data complete !","เเจ้งเตือน");
        }

        private void ClearCustomer_Click(object sender, RoutedEventArgs e)
        {
            using (SqliteConnection dataBase = new SqliteConnection("Filename=CustomersData.db"))
            {
                dataBase.Open();
                SqliteCommand command = new SqliteCommand("DELETE FROM Customers", dataBase);
                command.ExecuteReader();
                dataBase.Close();
            }
            MessageBox.Show("Clear customers data complete !", "เเจ้งเตือน");
        }

        private void ClearBook_Click(object sender, RoutedEventArgs e)
        {
            using (SqliteConnection dataBase = new SqliteConnection("Filename=BooksData.db"))
            {
                dataBase.Open();
                SqliteCommand command = new SqliteCommand("DELETE FROM BookDataTable", dataBase);
                command.ExecuteReader();
                dataBase.Close();
            }
            MessageBox.Show("Clear books data complete !", "เเจ้งเตือน");
        }
    }
}
