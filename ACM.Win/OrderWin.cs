using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACM.BL;
using ACM.Controller;
namespace ACM.Win
{
    public partial class OrderWin : Form
    {
        public OrderWin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlaceOrder();
        }

        private void PlaceOrder()
        {
            var order = new Order();
            //Populate the order instance
            var customer = new Customer();
            //Populate the customer instance
            var payment = new Payment();
            //Populate the payment instance
            var orderController = new OrderController();
            orderController.PlaceOrder(order, customer, payment, 
                                        allowSplitOrders:true, emailReceipt:true);
        }
    }
}
