using System;
using System.Collections.Generic;
using System.Text;

namespace Controller
{
    public class OperationSelectionState : IState
    {
        private Context atm;

        public void SetATM(Context atm)
        {
            this.atm = atm;
        }
        public void EjectCard()
        {
            Console.WriteLine("Card Ejected");
            atm.SetState(new ReadyState());
        }

        public void EnterPin(int pin, Client cl)
        {
            Console.WriteLine("PIN has been already written");
        }

        public void GetCash(int amount, Client cl)
        {
            if (atm.money == 0)
            {
                Console.WriteLine("The ATM is out of cash");
                atm.SetState(new BlockedState());
            }
            else
            {
                if (amount < cl.Restriction && atm.money - amount >= 0)
                {
                    Console.WriteLine($"Giving you {amount}");
                    atm.ChangeMoney(amount);
                }
                else
                {
                    Console.WriteLine("Cannot give money because of bank restriction. Try other amount");
                }
            }
           
        }

        public void InsertCard()
        {
            Console.WriteLine("Card has been already inserted");
        }
    }
}
