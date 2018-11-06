
using System;

namespace BankAccount.Models.Entities
{
    public class Account
    {
        public int ID{get;set;}
        public int _numAccount{get; private set;}
        private String _holderName{get;set;}
        private double _deposit{get;set;}

        public Account(int numAccount, String holderName)
        {

            this._numAccount = numAccount;
            this._holderName = holderName;
        }

        public Account(int numAccount, String holderName, double deposit)
        {
            this._numAccount = numAccount;
            this._holderName = holderName;
            this._deposit = deposit;
        }

        public void AddNumAccount(int numAccount)
        {
            if(numAccount == 0){
                this._numAccount = numAccount;
            }
        }
    }
}