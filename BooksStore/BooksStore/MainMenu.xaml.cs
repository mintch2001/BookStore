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
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ManageCustomersInformation_Click(object sender, RoutedEventArgs e)
        {
            CustomerChoiceForStaff choiceForStaff = new CustomerChoiceForStaff();
            choiceForStaff.Show();
        }

        private void ManageBooksInformation_Click(object sender, RoutedEventArgs e)
        {
            BookChoiceForStaffPage bookChoice = new BookChoiceForStaffPage();
            bookChoice.Show();
        }

        private void BuysBook_Click(object sender, RoutedEventArgs e)
        {
            BuyBook buyBook = new BuyBook();
            buyBook.Show();
        }
    }
}
