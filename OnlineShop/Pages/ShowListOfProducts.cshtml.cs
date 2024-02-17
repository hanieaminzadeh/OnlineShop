using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using OnlineShop.Entities;
using OnlineShop.Repositoris;

namespace OnlineShop.Pages;

public class ShowListOfProductsModel : PageModel
{

    [BindProperty]
    public List<Product> Products { get; set; }

    public void OnGet()
    {
        DapperRepository dapperRepo = new DapperRepository();
        Products = dapperRepo.GetProducts();
    }
}
