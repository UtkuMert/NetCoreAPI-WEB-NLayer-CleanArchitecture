﻿namespace App.Repositories.Products
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!; //null olmayacagini belirttik
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
