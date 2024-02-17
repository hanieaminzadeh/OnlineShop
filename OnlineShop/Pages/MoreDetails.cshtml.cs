using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineShop.Entities;
using OnlineShop.Repositoris;


namespace OnlineShop.Pages;

public class MoreDetailsModel : PageModel
{
    [BindProperty]
    public Product Product { get; set; }

    public void OnGet()
    {
        DapperRepository dapperRepo = new DapperRepository();
        Product = dapperRepo.GetProduct();
    }
}
