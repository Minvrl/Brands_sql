
using System.Text.RegularExpressions;
using System;
using Brands_proj.DAL;
using Brands_proj.Models;

//insert
void AddBrand()
{
    BrandsDBContext context = new BrandsDBContext();

    var newBrand = new Brand
    {
        Name = "Miata",
        FoundedAt = new DateTime(1920,03,02)
    };

    context.Brands.Add(newBrand);
    context.SaveChanges();
}

// get all

List<Brand> GetBrands()
{
    BrandsDBContext context = new BrandsDBContext();

    return context.Brands.ToList();
}


//update

void UpdateBrandName()
{
    BrandsDBContext context = new BrandsDBContext();

    var brand = context.Brands.First();

    brand.Name = "Mazda";

    context.SaveChanges();
}



//delete

void DeleteBrand()
{
    BrandsDBContext context = new BrandsDBContext();

    var group = context.Brands.First();

    context.Brands.Remove(group);
    context.SaveChanges();
}