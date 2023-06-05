using System;
using System.Collections.Generic;
using System.Text;

namespace Controller
{
    public class BlockedState : IState
    {
        private Context atm;

        public void SetATM(Context atm)
        {
            this.atm = atm;
        }
        public void EjectCard()
        {
            Console.WriteLine("The ATM is blocked. Take your card");
        }

        public void EnterPin(int pin, Client cl)
        {
            Console.WriteLine("The ATM is blocked");
        }

        public void GetCash(int amount, Client cl)
        {
            Console.WriteLine("The ATM is blocked");
        }

        public void InsertCard()
        {
            Console.WriteLine("The ATM is blocked");
        }
    }
}
