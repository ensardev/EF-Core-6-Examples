using EFCore6Examples.DatabaseFirst.DAL;
using Microsoft.EntityFrameworkCore;

DbContextInitializer.Build();

using (var _context = new AppDbContext())
{
    var products = await _context.Products.ToListAsync();

    products.ForEach(p =>
    {
        Console.WriteLine(p.Name + " - - - Fiyat : " + p.Price + " - - - Stok : " + p.Stock);
    });
}