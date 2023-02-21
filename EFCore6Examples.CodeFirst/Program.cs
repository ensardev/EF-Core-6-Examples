// See https://aka.ms/new-console-template for more information

using EFCore6Examples.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Initializer.Build();

using (var _context = new AppDbContext())
{
    var products = await _context.Products.ToListAsync();

    products.ForEach(p =>
    {
        Console.WriteLine($"Ürün : {p.Name} - Fiyat : {p.Price} - Stok : {p.Stock}");
    });
}