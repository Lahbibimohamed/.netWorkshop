using PS.Domain;
using System;
using System.Collections.Generic;

namespace PS.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Provider P1 = new Provider()
            {
                Password="12345",
                ConfirmPassword="12345"
            };
            //   Provider.setIsApproved(P1.Password, P1.ConfirmPassword, P1.IsApproved);
            // System.Console.WriteLine(P1.Password);
            //System.Console.WriteLine(P1.ConfirmPassword);
            //System.Console.WriteLine(P1.IsApproved);
            // La variable isApproved ne change pas quand on utilise la fonction passage par valeur

            Provider.SetIsApproved(P1);
            System.Console.WriteLine(P1.Password);
            System.Console.WriteLine(P1.ConfirmPassword);
            System.Console.WriteLine(P1.IsApproved);
            // La variable isApproved devient true quand on utilise la fonction passage par reference 
            //Category cat1, cat2, cat3;
            Category cat1 = new Category() { Name = "CAT1" };
            Category cat2 = new Category() { Name = "CAT2" };
            Category cat3 = new Category() { Name = "CAT3" };

            Provider prov1, prov2, prov3, prov4, prov5;
            prov1 = new Provider() { Username = "PROV1" };
            prov2 = new Provider() { Username = "PROV2" };
            prov3 = new Provider() { Username = "PROV3" };
            prov4 = new Provider() { Username = "PROV4" };
            prov5 = new Provider() { Username = "PROV5" };

            Product prod1, prod2, prod3, prod4, prod5, prod6;
            prod1 = new Product() { Name = "PROD1" };
            prod2 = new Product() { Name = "PROD2" };
            prod3 = new Product() { Name = "PROD3" };
            prod4 = new Product() { Name = "PROD4" };
            prod5 = new Product() { Name = "PROD5" };
            prod6 = new Product() { Name = "PROD6" };

            prod1.MyCategory = cat1;
            prod2.MyCategory = cat1;
            prod3.MyCategory = cat3;
            prod5.MyCategory = cat2;
            prod6.MyCategory = cat3;

            cat1.Products = new List<Product>() { prod1, prod2 };
            cat2.Products = new List<Product>() { prod5 };
            cat3.Products = new List<Product>() { prod3, prod6 };

            prod1.Providers = new List<Provider>() { prov1, prov2, prov3 };
            prod2.Providers = new List<Provider>() { prov1 };
            prod3.Providers = new List<Provider>() { prov1 };
            prod4.Providers = new List<Provider>() { prov3, prov4, prov5 };
            prod5.Providers = new List<Provider>() { prov2 };
            prod6.Providers = new List<Provider>() { prov4, prov5 };

            prov1.Products = new List<Product>() { prod1, prod2, prod3 };
            prov2.Products = new List<Product>() { prod1, prod5 };
            prov3.Products = new List<Product>() { prod1, prod4 };
            prov4.Products = new List<Product>() { prod4, prod6 };
            prov5.Products = new List<Product>() { prod4, prod6 };

            prov1.GetDetails();
            System.Console.ReadKey();
        }
    }
}
