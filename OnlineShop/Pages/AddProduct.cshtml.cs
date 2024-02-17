using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineShop.Entities;
using OnlineShop.Repositoris;

namespace OnlineShop.Pages;

public class AddProductModel : PageModel
{
    [BindProperty]
    public Product Product { get; set; }

    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        DapperRepository dapperRepo = new DapperRepository();
        dapperRepo.AddProduct(Product);
        return RedirectToPage("ShowListOfProducts");
    }
}