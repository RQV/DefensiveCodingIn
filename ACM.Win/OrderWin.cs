using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACM.Repository;
using ACM.BL;

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
            var order = new Order();
            //Populate the order instance
            var customer = new Customer();
            //Populate the customer instance
            var allowSplitOrders = true;
            var emailReceipt = true;
            var payment = new Payment();
            //Populate the payment instance
            var customerRepository = new CustomerRepository();
            customerRepository.Add(customer);
            var orderRepository = new OrderRepository();
            orderRepository.Add(order);
            var inventoryRepository = new InventoryRepository();
            inventoryRepository.orderItems(order, allowSplitOrders);
            payment.processPayment(payment);
            if (emailReceipt)
            {
                customer.ValidateEmail();
                customerRepository.Update();
            }
        }
    }
}
