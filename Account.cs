using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
 
    class Account
    {
        public int AccountNumber  { get; set; }
        public String AccountNmae { get; set; }
        public decimal Balance { get; set; }
        public String  AccountType { get; set; }
        public DateTime CreatedDate { get; set; }
        public string EmailAddress { get; set; }


    }
}
