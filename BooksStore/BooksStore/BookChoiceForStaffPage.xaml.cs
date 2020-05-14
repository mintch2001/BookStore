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
    /// Interaction logic for BookChoiceForStaffPage.xaml
    /// </summary>
    public partial class BookChoiceForStaffPage : Window
    {
        public BookChoiceForStaffPage()
        {
            InitializeComponent();
        }

        private void RegisterDataBook_Click(object sender, RoutedEventArgs e)
        {
            BookRegisterPage bookRegister = new BookRegisterPage();
            bookRegister.Show();
            this.Close();
        }

        private void EditDataBook_Click(object sender, RoutedEventArgs e)
        {
            

           
            BookEditPage bookEditPage = new BookEditPage();
            bookEditPage.Show();

            BookDataShow dataShow = new BookDataShow();
            string dataAll = "";
            foreach (string data in dataShow.ReturnData)
            {
                dataAll = dataAll + "\n" + data;
            }

            MessageBox.Show("ISBN in system : " + dataAll);

            this.Close();
        }

        private void DataBook_Click(object sender, RoutedEventArgs e)
        {
            BookDataShow dataShow = new BookDataShow();
            string dataAll = "";
            foreach (string data in dataShow.ReturnData)
            {
                dataAll = dataAll + "\n" + data;
            }
            
            MessageBox.Show("ISBN in system : " + dataAll);
        }
    }
}
