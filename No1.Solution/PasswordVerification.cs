using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
     public class PasswordVerification : IVerification
     {
          public bool Verify(string password)
          {
               if (password == null)
               {
                    throw new ArgumentException($"{password} is null arg");
               }

               if (password == string.Empty)
               {
                    Console.WriteLine("Password is empty");
                    return false;
               }

               // check if length more than 7 chars 
               if (password.Length <= 7)
               {
                    Console.WriteLine("Password length too short");
                    return false;
               }

               // check if length more than 10 chars for admins
               if (password.Length >= 15)
               {
                    Console.WriteLine("Password length too long");
                    return false;
               }

               // check if password contains at least one alphabetical character 
               if (!password.Any(char.IsLetter))
               {
                    Console.WriteLine("Password hasn't alphanumerical chars");
                    return false;
               }

               // check if password contains at least one digit character 
               if (!password.Any(char.IsNumber))
               {
                    Console.WriteLine("Password hasn't digits");
                    return false;
               }

               return true;
          }
     }
}
