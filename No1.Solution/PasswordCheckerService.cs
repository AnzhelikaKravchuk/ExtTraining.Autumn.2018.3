using System;
using No1.Solution;
using System.Linq;
using System.Collections.Generic;

namespace No1.Solution
{
    public class PasswordCheckerService
    {
        private readonly ISqlRepository repository;
        private readonly IChecker checker;
        private List<CheckerResult> checkerResult = new List<CheckerResult>();

        public PasswordCheckerService(ISqlRepository repository, IChecker checker )
        {
            this.repository = repository;
            this.checker = checker;
        }

        public void CheckPassword(string password)
        {
            checkerResult.Add(checker.VerifyPassword(password));            
        }

        // логику с индексами нужно детальнее продумывать. Наверно лучше добавить id запроса к CheckerResult
        public bool ToRepository(int index)
        {
            CheckerResult returnResult = checkerResult[index];            
            checkerResult.RemoveAt(index);
            repository.Create(returnResult.Password);
            return true;
        }

       




    }
}
