using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
   
    #region Propertiess 
    class Account
    {
        public int AccountNumber  { get; set; }
        public String AccountNmae { get; set; }
        public decimal Balance { get; private set; }
        public String  AccountType { get; set; }
        public DateTime CreatedDate { get; set; }
        public string EmailAddress { get; set; }

       #endregion

        #region Method
        
        public void Deposite(decimal amount)
        {   
            Balance += amount;
        }
        public decimal Withdraw(decimal amount)
        {
            Balance -= amount;
        return Balnac;
        }
        #endregion

