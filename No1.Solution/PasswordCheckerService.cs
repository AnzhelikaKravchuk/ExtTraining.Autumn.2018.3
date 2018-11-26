using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
     public class PasswordCheckerService
     {
          private IRepository repository;

          /// <summary>
          /// Check input data using verification method in interface variable and input kind of storage.
          /// </summary>
          /// <param name="inputData">
          /// Input password.
          /// </param>
          /// <param name="verification">
          /// Type of checking.
          /// </param>
          /// <param name="storage">
          /// Type of storage.
          /// </param>
          /// <returns>
          /// True if password is correct.
          /// </returns>
          public bool VerifyInputData(string inputData, IVerification verification, IRepository storage)
          {
               if (verification == null || storage == null)
               {
                    throw new ArgumentNullException();
               }

               if (!verification.Verify(inputData))
               {
                    return false;
               }

               repository = storage;
               repository.Create(inputData);
               return true;
          }
     }
}
