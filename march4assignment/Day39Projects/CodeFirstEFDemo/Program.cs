using CodeFirstEFDemo;
using CodeFirstEFDemo.Data;
using CodeFirstEFDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;


// create category 

//var electronics = new Category { Name = "Electronics" };

//context.Categories.Add(electronics);
//await context.SaveChangesAsync();

//context.Products.AddRange(
//    new Product { Name = "laptop", Price = 999.78M, category =electronics },
//     new Product { Name = "Mouse", Price = 678.78M, category = electronics }
//);

//await context.SaveChangesAsync();

// update command 
//var laptop = await context.Products.FirstAsync(p => p.Name == "laptop");
//laptop.Price = 7899.67M;
//await context.SaveChangesAsync();

//// delete command 
//context.Products.Remove(laptop);
//context.SaveChangesAsync();

//Querrng author with courses 

//var authors = await context.Authors.Include(x => x.Courses).ToListAsync();
//// one to many 
//foreach(var author in authors)
//{
//    Console.WriteLine($"Author: {author.Name}");
//    foreach(var course in author.Courses)
//    {
//        Console.WriteLine($"--{course.Title}--{course.Description}--{course.level}");
//    }
//}
var  context = new AppDbContext();

//var newProduct = new Product
//{ Name = "smartphone", Price = 6888.56M, CategoryId = 3 };
IProductRepository obj = new ProductRepository(context);
//await obj.AddAsync(newProduct);

//var toupdate = await obj.GetByIdAsync(newProduct.Id);
//if(toupdate!=null)
//{
//    toupdate.Price = 777.67M;
//    toupdate.Name = "normalphone";
//   await  obj.UpdateAsync(toupdate);
//    Console.WriteLine($"Updated : {toupdate.Name}--{toupdate.Price}");
//}

//var producttofetch = await obj.GetByIdAsync(7);

//if (producttofetch != null)
//{
//    producttofetch.Price = 555.67M;
//    producttofetch.Name = "normalphone2";
//    await obj.UpdateAsync(producttofetch);
//    Console.WriteLine($"Updated : {producttofetch.Name}--{producttofetch.Price}");
//}

//await obj.DeleteAsync(7);
IProductRepository obj2 = new ProductRepository2(context);
//var newProd = new Product { Name = "Tablet", Price = 233.45M,
//    CategoryId = 3 };
//await obj2.AddAsync(newProd);

var toupdate = await obj2.GetByIdAsync(8);
if (toupdate != null)
{
    toupdate.Price = 888.7M;
    toupdate.Name = "IPhone";
}
await obj2.UpdateAsync(toupdate);


//await obj2.DeleteAsync(9);


