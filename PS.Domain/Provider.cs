using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
   public  class Provider:Concept
    {
        String password;
        public String Password
        {
            get { return password; }
            set
            {
                if (value.Length >= 5 && value.Length <= 20)
                    password = value;
                else Console.WriteLine("la taille du password doit etre entre 5 et 20");
            }
        }
        string confirmPassword;
        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set
            {
                if (Password == value)
                    confirmPassword = value;
                else Console.WriteLine("les mots de passe ne sont pas identiques");
            }
        }

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
        public static void SetIsApproved(Provider P)
        {
            if(P.Password == P.ConfirmPassword) P.IsApproved = true;
        }
        public static void setIsApproved(string password, string confirmPassword, bool isapproved)
        {
            if (password == confirmPassword) isapproved = true;
        }
        public bool Login(String nom, String password)
        {
            if (password == Password && nom == Username) return true;
            else return false;
        }
        public bool Login(String nom, String password,String email)
        {
            if (password == Password && nom == Username && email==Email) return true;
            else return false;
        }
        public  bool Loginn(String nom, String password, String email=null)
        {
            if (email == null)
            {
                if (password == Password && nom == Username) return true;
                else return false;
            }
            else
            {
                if (password == Password && nom == Username && email == Email) return true;
                else return false;
            }
        }
    }

}
