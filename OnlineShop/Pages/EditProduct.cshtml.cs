using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineShop.Entities;
using OnlineShop.Repositoris;

namespace OnlineShop.Pages;

public class EditProductModel : PageModel
{
    DapperRepository dapperRepo = new DapperRepository();

    [BindProperty]
    public List<Product> Products { get; set; }

    [BindProperty]
    public Product SelecedProduct { get; set; }


    public void OnGet(int id)
    {
        DapperRepository dapperRepo = new DapperRepository();
        Products = dapperRepo.GetProducts();
        SelecedProduct = Products.FirstOrDefault(p => p.Id == id);
    }

    public IActionResult OnPost()
    {
        DapperRepository dapperRepo = new DapperRepository();

        dapperRepo.UpdateProduct(SelecedProduct);

        return RedirectToPage("ShowListOfProducts");
    }
}