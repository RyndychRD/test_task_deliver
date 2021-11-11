using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace test_task_deliver_RyndychRD.Models
{
    public class Order
    {
        public int id { set; get; }

        [Required(ErrorMessage = "Не указан город отправителя")]
        public string sender_city { set; get; }
        
        [Required(ErrorMessage = "Не указан адрес отправителя")]
        public string sender_address { set; get; }
        
       [Required(ErrorMessage = "Не указан город получателя")]
        public string receiver_city { set; get; }
        
       [Required(ErrorMessage = "Не указан адрес получателя")]
        public string receiver_address { set; get; }
        
        [Required(ErrorMessage = "Не указан вес")]
        [Range(0, int.MaxValue, ErrorMessage = "Введите число больше чем {1}")]
        public int package_weight { set; get; }
        
        [Required(ErrorMessage = "Не указана дата забора груза")]
        public DateTime package_pickupDate { set; get; }

    }
}
