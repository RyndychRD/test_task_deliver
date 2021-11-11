using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using test_task_deliver_RyndychRD.Interfaces;
using test_task_deliver_RyndychRD.Models;
using test_task_deliver_RyndychRD.ViewModel;

namespace test_task_deliver_RyndychRD.Controllers
{
    public class HomeController : Controller
    {

        private readonly IOrder _allOrders;

        public HomeController(IOrder IOrder)
        {
            _allOrders = IOrder;
       
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ShowOrders()
        {
            ShowOrdersViewModel obj=new ShowOrdersViewModel();
            obj.allOrders = _allOrders.getAllOrders;
            return View(obj);
        }



        [HttpPost]
        public IActionResult Index(Order order)
        {
            if (ModelState.IsValid)
            {
                _allOrders.addOrder(order);
                return RedirectToAction("ShowOrders");
            }
            ViewBag.error = "Возникли ошибки при добавлении записи в базу данных. Проверьте правильность заполнения полей";
            return View();
        }


       
    }
}
