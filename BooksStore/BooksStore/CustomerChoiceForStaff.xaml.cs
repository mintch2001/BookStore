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
    /// Interaction logic for CustomerChoiceForStaff.xaml
    /// </summary>
    public partial class CustomerChoiceForStaff : Window
    {
        public CustomerChoiceForStaff()
        {
            InitializeComponent();
        }

        private void RegisterDataCustomers_Click(object sender, RoutedEventArgs e)
        {
            CustomersRegisterPage customersRegister = new CustomersRegisterPage();
            customersRegister.Show();
            this.Close();
        }

        private void d_Click(object sender, RoutedEventArgs e)
        {
            CustomersEditPage editPage = new CustomersEditPage();
            editPage.Show();
            this.Close();
        }
    }
}
