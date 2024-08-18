﻿using DesignPattern.Facade.DAL;
using DesignPattern.Facade.Facade;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Facade.Controllers
{
    public class OrderController : Controller
    {
        AppDbContext context = new AppDbContext();
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult OrderDetailStart()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OrderDetailStart(int customerId, int productId, int orderId, int productCount, decimal productPrice)
        {
            OrderFacade order = new OrderFacade();
            order.CompleteOrderDetail(customerId, productId, orderId, productCount, productPrice);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult OrderStart()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OrderStart(int customerId)
        {
            OrderFacade order = new OrderFacade();
            order.CompleteOrder(customerId);
            return RedirectToAction("Index");
        }
    }
}
