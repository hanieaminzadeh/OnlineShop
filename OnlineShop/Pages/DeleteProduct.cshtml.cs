using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineShop.Entities;
using OnlineShop.Repositoris;
using System.Net.Http.Headers;

namespace OnlineShop.Pages;

public class DeleteProductModel : PageModel
{
    [BindProperty]
    public List<Product> Products { get; set; }
    
    public Product SelecedProduct { get; set; }



    public void OnGet()
    {
        DapperRepository dapperRepo = new DapperRepository();
        Products = dapperRepo.GetProducts();
    }


    
    public IActionResult OnPostGetId(int id)
    {
        DapperRepository dapperRepo = new DapperRepository();
        Products = dapperRepo.GetProducts();
        SelecedProduct = Products.FirstOrDefault(p => p.Id == id);
        if (SelecedProduct != null)
        {
            dapperRepo.DeleteProduct(SelecedProduct);
        }
        return RedirectToPage("ShowListOfProducts");
    }
}
