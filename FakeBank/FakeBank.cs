using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banks.Base;
using Banks.Base.Model;

namespace Banks.Fake
{
    public class FakeBank :BankBase
    {
        public override string Name
        {
            get { return "Fake bank"; }
        }

        public override async Task<LoginResult> Login(string username, System.Security.SecureString password)
        {
            await Task.Delay(2000);
            if (username == "0066")
                return new LoginResult { IsSuccess = true };
            else
                return new LoginResult { IsSuccess = false, ErrorMessage = "Invalid Username/Password" };
        }

        public override async Task<AccountListResult> GetAccounts()
        {
            await Task.Delay(200);
            return new AccountListResult()
            {
                IsSuccess = true,
                Accounts = 
                { 
                    new Account { AccountNumber = "11 2222 4444 5555 6666 2222 1111", Name = "Account 1", Balance = 3431.23m},
                    new Account { AccountNumber = "22 1111 1111 8888 1111 2222 1111", Name = "Account 2", Balance = -431.23m}
                }
            };
        }
    }
}
