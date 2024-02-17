﻿namespace OnlineShop.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public int Price { get; set; }
    public string? Color { get; set; }
    public int CategoryId { get; set; }
}
