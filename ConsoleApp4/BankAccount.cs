using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class BankAccount
    {

        public string NameBank;
        public string NumAccount;
        public string BranchBank;
        private int Blans;

      public BankAccount(string nameBank, string numAccount, string branchBank)
      {
               NameBank = nameBank;
               NumAccount = numAccount;
               BranchBank = branchBank;
      }
      public int Attraction(int sumAttraction)
      {
            Blans -= sumAttraction;
            return Blans;
      }

      public int Diposit(int sumDiposit)
       {
            Blans += sumDiposit;
            return Blans;
       }
      public void Transfar(BankAccount f, int sum)
      {
            Attraction(f.Diposit(sum));
      }

    }
}
