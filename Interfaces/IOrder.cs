using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test_task_deliver_RyndychRD.Models;

namespace test_task_deliver_RyndychRD.Interfaces
{
    public interface IOrder
    {
        IEnumerable<Order> getAllOrders { get; }

        void addOrder(Order order);
    }
}
