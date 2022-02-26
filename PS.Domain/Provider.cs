using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
   public  class Provider:Concept
    {
        public String Password { get; set; }
        public String ConfirmPassword { get; set; }


        public DateTime DateCreated { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
        public bool IsApproved { get; set; }
        public string Username { get; set; }
        public virtual IList<Product> Products { get; set; }
        public override void GetDetails()
        {
            Console.WriteLine("Email: {0}, DateCreated:{1}", Email, DateCreated);
            foreach (Product p in Products)
            {
                p.GetDetails();
            }

        }
        public static  void SetIsApproved(Provider P)
        {
            if(P.Password == P.ConfirmPassword) P.IsApproved = true;
        }
        public static void setIsApproved(string password, string confirmPassword, bool isapproved)
        {
            if (password == confirmPassword) isapproved = true;
        }
    }

}
