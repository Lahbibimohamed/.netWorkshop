using PS.Domain;
using System;

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
        }
    }
}
