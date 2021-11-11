using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test_task_deliver_RyndychRD.Interfaces;
using test_task_deliver_RyndychRD.Models;

namespace test_task_deliver_RyndychRD.Repository
{
    public class RepositoryOrder : IOrder
    {

        private readonly AppDBContent appDBContent;

        public RepositoryOrder(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Order> getAllOrders => appDBContent.orders;

        public void addOrder(Order order)
        {
            appDBContent.Add(order);
            appDBContent.SaveChanges();

        }
    }
}
