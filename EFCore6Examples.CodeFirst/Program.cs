// See https://aka.ms/new-console-template for more information

using EFCore6Examples.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Initializer.Build();

using (var _context = new AppDbContext())
{
    #region Add Product
    //var newProduct = new Product
    //{
    //    Name= "Clean Code",
    //    Price = 179,
    //    Stock = 77,
    //    Barcode = "010101"
    //};
    //Console.WriteLine($"First State : {_context.Entry(newProduct).State}");

    //await _context.AddAsync(newProduct);    
    //Console.WriteLine($"Second State : {_context.Entry(newProduct).State}");

    ////We can also use "_context.Entry(newProduct).State = EntityState.Added; of "await _context.AddAsync(newProduct); command."

    //await _context.SaveChangesAsync();
    //Console.WriteLine($"Last State : {_context.Entry(newProduct).State}");
    #endregion

    #region Update Product
    //var product = await _context.Products.FirstOrDefaultAsync();
    //Console.WriteLine($"First State : {_context.Entry(product).State}");

    //product.Stock = 88;
    //Console.WriteLine($"Second State : {_context.Entry(product).State}");

    //await _context.SaveChangesAsync();
    //Console.WriteLine($"Last State : {_context.Entry(product).State}");

    ////If this data isn't tracked by EFCore we must use the "Update" method.
    ////Like this : "_context.Update(new Product() { Id = 3, Name = "Dava", Price = 99, Stock = 111 });"
    #endregion

    #region Delete Product
    //var product = await _context.Products.FirstOrDefaultAsync();
    //Console.WriteLine($"First State : {_context.Entry(product).State}");

    //_context.Remove(product);
    //Console.WriteLine($"Second State : {_context.Entry(product).State}");

    //await _context.SaveChangesAsync();
    //Console.WriteLine($"Last State : {_context.Entry(product).State}");
    #endregion

    #region List Products
    ////var products = await _context.Products.ToListAsync();

    ////If we only want to list and do not want to perform an update or deletion on a listed data, it is more efficient to use AsNoTracking().
    //var products = await _context.Products.AsNoTracking().ToListAsync();


    //products.ForEach(p =>
    //{
    //    var state = _context.Entry(p).State;

    //    Console.WriteLine($"Ürün : {p.Name} - Fiyat : {p.Price} - Stok : {p.Stock} - State : {state}");
    //});
    #endregion

    #region ChangeTracker For Products
    //_context.Products.Add(new Product { Name = "Şifrepunk", Price = 77, Stock = 121, Barcode = "822368112451" });
    //_context.Products.Add(new Product { Name = "Tırışkadan İşler", Price = 65, Stock = 32, Barcode = "12451213254" });
    //_context.Products.Add(new Product { Name = "Biz", Price = 44, Stock = 21, Barcode = "368132423432" });
    ////These records are now on Tracker. They didn't save to DB and they are in the status "Added."
    //_context.SaveChanges();


    //Add CreatedDate to all tracked records when the record status is "Added". 
    //_context.ChangeTracker.Entries().ToList().ForEach(e =>
    //{
    //    if(e.Entity is Product p)
    //    {
    //        if(e.State == EntityState.Added)
    //            p.CreatedDate = DateTime.Now;
    //    }
    //});


    //var products = await _context.Products.AsNoTracking().ToListAsync();

    //products.ForEach(p =>
    //{
    //    var state = _context.Entry(p).State;

    //    Console.WriteLine($"Ürün : {p.Name} - Fiyat : {p.Price} - Stok : {p.Stock} - State : {state}");
    //});
    #endregion

    #region One-to-Many Add Data Example

    //var category = new Category() { Name = "Kitap" };
    //var product = new Product() { Name = "Dava", Price = 22, Stock = 21, Barcode = "01237688723", Category = category };

    //category.Products.Add(new Product() { Name = "Biz", Price = 64, Stock = 9, Barcode = "978345465", Category = category });

    //_context.Products.Add(product);
    //_context.SaveChanges();


    var category = _context.Categories.Find(1);

    category.Products.Add(new Product() { Name = "1984", Price = 45, Stock = 14, Barcode = "94652451523" });

    _context.SaveChanges();

    #endregion

}