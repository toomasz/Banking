using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Banks.Base
{
    public abstract class BankBase
    {
        public abstract string Name
        {
            get;
        }
        public abstract Task<LoginResult> Login(string username, SecureString password);

        public abstract Task<AccountListResult> GetAccounts();
    }
}
