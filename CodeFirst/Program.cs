// See https://aka.ms/new-console-template for more information
using CodeFirst.Models;

Console.WriteLine("Hello, World!");

using (ShopContext db = new ShopContext())
{

    //db.Categories.Add(new Category() { Name = "Food" });

    db.Products.Add(new Product() { Name="chockolate",Price=10,Desc="",CategoryId=3 });
    db.SaveChanges();
}
