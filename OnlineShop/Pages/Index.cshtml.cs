using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineShop.Repositoris;
using OnlineShop.Entities;
using System.ComponentModel;

namespace OnlineShop.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        DapperRepository dapperRepo = new DapperRepository();

        //Product product = new()
        //{
        //    Name = "iPhone13",
        //    Title = "",
        //    Description = "gvhb",
        //    Price = 30000000,
        //    Color = "white",
        //    CategoryId = 2,
        //};
        //dapperRepo.AddProduct(product);

        //var products = dapperRepo.GetProducts();
        //foreach (var pr in products)
        //{
        //    Console.WriteLine($"Id: {pr.Id} _ Name:{pr.Name} _ Title:{pr.Title} _ Description:{pr.Description} _ Price:{pr.Price} _ Color:{pr.Color} _ CategoryId:{pr.CategoryId}");
        //}
    }
}
