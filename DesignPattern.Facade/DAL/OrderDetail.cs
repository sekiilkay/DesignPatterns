﻿namespace DesignPattern.Facade.DAL
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int ProductCount { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal ProductTotalPrice { get; set; }
        public int? ProductId { get; set; }
        public Product Product { get; set; }
        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int? OrderId { get; set; }
        public Order Order { get; set; }
    }
}
