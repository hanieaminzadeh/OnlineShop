using Dapper;
using Microsoft.Data.SqlClient;
using OnlineShop.Entities;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using System.Drawing;

namespace OnlineShop.Repositoris;

public class DapperRepository
{
    public List<Product> GetProducts()
    {
        string connectionString = @"Data Source=HANIE\SQLEXPRESS;Initial Catalog=OnlineShop;Integrated Security=True;Trust Server Certificate=True";
        using var cn = new SqlConnection(connectionString);
        var sql = $"Select * from dbo.Product";
        var cmd = new CommandDefinition(sql);
        var result = cn.Query<Product>(cmd);
        return result.ToList();
    }
    public void AddProduct(Product product)
    {
        string connectionString = @"Data Source=HANIE\SQLEXPRESS;Initial Catalog=OnlineShop;Integrated Security=True;Trust Server Certificate=True";

        string sql = "INSERT dbo.Product(Name, Title, Description, Price, Color, CategoryId)VALUES(@Name, @Title, @Description, @Price, @Color, @CategoryId)";
        using var cn = new SqlConnection(connectionString);
        var command = new CommandDefinition(sql, product);
        cn.Execute(command);
    }
    public void DeleteProduct(Product product)
    {
        string connectionString = @"Data Source=HANIE\SQLEXPRESS;Initial Catalog=OnlineShop;Integrated Security=True;Trust Server Certificate=True";

        string sql = "DELETE FROM dbo.Product WHERE Id = @Id";
        using var cn = new SqlConnection(connectionString);
        var command = new CommandDefinition(sql, new { Id = product.Id });
        cn.Execute(command);
    }
    public void UpdateProduct(Product product)
    {
        string connectionString = @"Data Source=HANIE\SQLEXPRESS;Initial Catalog=OnlineShop;Integrated Security=True;Trust Server Certificate=True";

        string sql = "UPDATE dbo.Product SET Name = @Name, Title = @Title, Description = @Description, Price = @Price, Color = @Color, CategoryId = @CategoryId WHERE Id = @Id";

        using var cn = new SqlConnection(connectionString);
        //var command = new CommandDefinition(sql, new { Id = product.Id, Name = product.Name, Title = product.Title, Description = product.Description, Price = product.Price, Color = product.Color, CategoryId = product.CategoryId});
        var command = new CommandDefinition(sql, product);
        cn.Execute(command);
    }
    public Product GetProduct()
    {
        string connectionString = @"Data Source=HANIE\SQLEXPRESS;Initial Catalog=OnlineShop;Integrated Security=True;Trust Server Certificate=True";
        using var cn = new SqlConnection(connectionString);
        var sql = $"Select TOP 1 * from dbo.Product";
        var cmd = new CommandDefinition(sql);
        var result = cn.QueryFirstOrDefault<Product>(cmd);
        return result;
    }

}
//public void DeleteProductById(int productId)
//{
//    string connectionString = @"Data Source=HANIE\SQLEXPRESS;Initial Catalog=OnlineShop;Integrated Security=True;Trust Server Certificate=True";

//    string sql = "DELETE FROM dbo.Product WHERE Id = @Id";

//    using var cn = new SqlConnection(connectionString);
//    var command = new CommandDefinition(sql, new { ProductId = productId });
//    cn.Execute(command);
//}