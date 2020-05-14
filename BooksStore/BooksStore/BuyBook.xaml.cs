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
    /// Interaction logic for BuyBook.xaml
    /// </summary>
    public partial class BuyBook : Window
    {
        public BuyBook()
        {
            InitializeComponent();
        }

        private void CheckButton_Click(object sender, RoutedEventArgs e)
        {
            OrderCheck orderCheck = new OrderCheck(txtISBN.Text, txtEmailCustomer.Text, txtQuatity.Text, txtTotalPrice.Text);
            if(orderCheck.CheckNullOutput == false)
            {
                MessageBox.Show("โปรดกรอกข้อมูลให้ครบถ้วน", "เเจ้งเตือน");
            }
            else if (orderCheck.DoubleDataEmailCheckOutput == false)
            {
                MessageBox.Show("ไม่ Email ลูกค้า", "เเจ้งเตือน");
            }
            else if (orderCheck.DoubleDataISBNCheckOutput == false)
            {
                MessageBox.Show("ไม่พบ ISBN ในระบบ", "เเจ้งเตือน");
            }
            else if (orderCheck.QuatityCheckOutput == false)
            {
                MessageBox.Show("โปรดกรอกจำนวนเป็นตัวเลข", "เเจ้งเตือน");
            }
            else
            {
                PickPriceOfBooks priceOfBooks = new PickPriceOfBooks(txtISBN.Text, txtQuatity.Text);
                txtTotalPrice.Text = priceOfBooks.CalculatePriceOutput.ToString();            
                BuyButton.IsEnabled = true;            
            }
        }

        private void BuyButton_Click(object sender, RoutedEventArgs e)
        {
            OrderCheck orderCheck = new OrderCheck(txtISBN.Text, txtEmailCustomer.Text, txtQuatity.Text, txtTotalPrice.Text);
            if (orderCheck.CheckNullOutput == false || orderCheck.DoubleDataEmailCheckOutput == false || orderCheck.DoubleDataISBNCheckOutput == false || orderCheck.QuatityCheckOutput == false)
            {
                MessageBox.Show("มีข้อมูลบางอย่างไม่ถูกต้อง", "เเจ้งเตือน");
                BuyButton.IsEnabled = false;              
            }    
            else
            {
                OrderBook orderBook = new OrderBook(txtISBN.Text, txtEmailCustomer.Text, txtQuatity.Text, txtTotalPrice.Text);
                MessageBox.Show("การสั่งซื้อสำเร็จ !");
                this.Close();
            }            
        }
    }
}
