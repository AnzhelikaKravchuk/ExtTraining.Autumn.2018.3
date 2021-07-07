using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace No1.Solution
{
     public class СomplicatedVerifacation : IVerification
     {
          public bool Verify(string password)
          {
               if (password == null)
               {
                    throw new ArgumentException($"{password} is null arg");
               }

               if (password == string.Empty)
               {
                    Console.WriteLine("Email is empty");
                    return false;
               }

               // check if length more than 7 chars 
               if (password.Length <= 7)
               {
                    Console.WriteLine("Password length too short");
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

               if (!password.Any(char.IsUpper))
               {
                    Console.WriteLine("Password hasn't uppercase chars");
                    return false;
               }

               if (!password.Any(char.IsLower))
               {
                    Console.WriteLine("Password hasn't lowercase chars");
                    return false;
               }

               return true;
          }
     }
}