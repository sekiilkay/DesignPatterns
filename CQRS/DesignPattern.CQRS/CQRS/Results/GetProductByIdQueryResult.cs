﻿namespace DesignPattern.CQRS.CQRS.Results
{
    public class GetProductByIdQueryResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
    }
}
