﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    public enum AccountType { 
        Admin,
        Member,
        Golden,
        Diamond
    }

    public class Account
    {
        private int id;
        private string username;
        private string password;
        private AccountType accType;
        private BankAccount[] bankAccounts;

        private static int numOfAcc;
        private static readonly int MAX_BANK_ACCOUNT = 10;

        public Account(){

            this.id = ++numOfAcc;
            this.username = "-";
            this.password = "-";
            this.accType = AccountType.Member;
            this.bankAccounts = new BankAccount[MAX_BANK_ACCOUNT];
        }
        public Account(String username, String password): this() {

            Username = username;
            Password = password;
        }

        public int Id { get { return this.id; } }

        public String Username {
            get { return this.username; }
            set { 
                if(true)
                    username = value;
            }
        }

        public String Password
        {
            get { return this.password; }
            set
            {
                if (true)
                    password = value;
            }
        }

        public AccountType AccType
        {
            get { return accType; }
        }

        public void cancelCreate() {
            numOfAcc--;
        }


        public void updateAccountType() {
            double sum = 0;
            foreach (BankAccount bankAcc in bankAccounts) {
                sum += bankAcc.Balance;
            }
        }

    }
}
