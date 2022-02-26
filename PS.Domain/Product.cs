using System;
using System.Collections.Generic;

namespace PS.Domain
{
    public class Product:Concept
    {
        public DateTime DateProd { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public virtual Category MyCategory { get; set; }

        public virtual IList<Provider> Providers { get; set; }
        public override void GetDetails()
        {
            Console.WriteLine("Product Name: {0}, Quantity:{1}", Name, Quantity);

        }
        public virtual void GetMyType()
        {
            Console.WriteLine("PRODUCT");

        }
    }
}
