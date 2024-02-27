using Brands_proj.DAL;
using Brands_proj.Models;

AddBrand();

var r = GetAllBrands();

Console.WriteLine("===== Brands =====");
foreach (var item in r)
{
    Console.WriteLine(item);
}


//Create brand
void AddBrand()
{
    BrandsDbContext context = new BrandsDbContext();

    var newBrand = new Brand
    {
        Name = "Porsche",
        FoundedAt = new DateTime(1931, 04, 25)
    };

    context.Brands.Add(newBrand);
    context.SaveChanges();
}


//Get brands

List<Brand> GetAllBrands()
{
    BrandsDbContext context = new BrandsDbContext();

    return context.Brands.ToList();
}


//Update

void UpdateBrandName()
{
    BrandsDbContext context = new BrandsDbContext();

    var brand = context.Brands.First();

    brand.Name = "Miata";

    context.SaveChanges();
}

//Delete

void DeleteBrand()
{
    BrandsDbContext context = new BrandsDbContext();

    var brand = context.Brands.First();

    context.Brands.Remove(brand);
    context.SaveChanges();

}
