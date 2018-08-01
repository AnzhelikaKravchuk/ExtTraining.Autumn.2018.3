using System;
using System.Collections.Generic;

namespace No1
{
    public class IdentityResult
    {
        public IdentityResult(bool isSuccess, IEnumerable<string> messages)
        {
            this.IsSuccess = isSuccess;
            this.Messages = messages ?? throw new ArgumentNullException($"{nameof(messages)} is null");
        }

        public bool IsSuccess { get; }

        public IEnumerable<string> Messages { get; }
    }
}
