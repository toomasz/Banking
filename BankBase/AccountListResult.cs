using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banks.Base.Model;

namespace Banks.Base
{
    public class AccountListResult :ResultBase
    {
        public List<Account> Accounts { get; set; }
    }
}
