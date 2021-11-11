using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test_task_deliver_RyndychRD.Models;

namespace test_task_deliver_RyndychRD
{
    public class DBInitial
    {
        public static void InitialFill(AppDBContent appDBcontent) {
           
            if (!appDBcontent.orders.Any())
            {
                appDBcontent.orders.AddRange(ordersTest);
            }

            appDBcontent.SaveChanges();
        }
    
        public static IEnumerable<Order> ordersTest
        {
            get {
                var list = new Order[]
                {
                    new Order{
                        package_pickupDate=DateTime.Now,
                        package_weight=0,
                        receiver_address="recAdr1",
                        receiver_city="recCity1",
                        sender_address="sendAdr1",
                        sender_city="sendCity1" },
                    new Order{
                        package_pickupDate=DateTime.Now,
                        package_weight=1,
                        receiver_address="recAdr2",
                        receiver_city="recCity2",
                        sender_address="sendAdr2",
                        sender_city="sendCity2" },
                    new Order{
                        package_pickupDate=DateTime.Now,
                        package_weight=1,
                        receiver_address="recAdr3",
                        receiver_city="recCity3",
                        sender_address="sendAdr3",
                        sender_city="sendCity3" }
                };
                return list;
               }
        }
    }
}
