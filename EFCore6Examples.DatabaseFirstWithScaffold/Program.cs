// See https://aka.ms/new-console-template for more information

using EFCore6Examples.DatabaseFirstWithScaffold.Models;
using Microsoft.EntityFrameworkCore;

using (var _context = new EfcoreDatabaseFirstContext())
{
    var products = await _context.Products.ToListAsync();

    products.ForEach(p =>
    {
        Console.WriteLine($"Ürün : {p.Name} - Fiyat : {p.Price} - Stok : {p.Stock}");
    });
}