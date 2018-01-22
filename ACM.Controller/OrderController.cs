using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM.Repository;
using Core.Common;
using ACM.BL;

namespace ACM.Controller
{
    public class OrderController
    {
        private CustomerRepository customerRepository { get; set; }
        private OrderRepository orderRepository { get; set; }
        private InventoryRepository inventoryRepository { get; set; }
        private EmailLibrary emailLibrary;
        public OrderController()
        {
            customerRepository = new CustomerRepository();
            orderRepository = new OrderRepository();
            inventoryRepository = new InventoryRepository();
            emailLibrary = new EmailLibrary();
        }
        public void PlaceOrder(Order order, Customer customer, 
                               Payment payment, bool allowSplitOrders, bool emailReceipt)
        {
            customerRepository.Add(customer);
            orderRepository.Add(order);
            inventoryRepository.orderItems(order, allowSplitOrders);
            payment.processPayment(payment);
            if (emailReceipt)
            {
               var result = customer.ValidateEmail();
                if (result.Success)
                {
                    customerRepository.Update();
                    emailLibrary.SendEmail(customer.Email, "Here is your receipt");
                }
            }
        }
    }
}
