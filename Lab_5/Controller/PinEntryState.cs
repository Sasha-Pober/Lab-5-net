using System;
using System.Collections.Generic;
using System.Text;

namespace Controller
{
    public class PinEntryState : IState
    {
        private Context atm;

        public void SetATM(Context atm)
        {
            this.atm = atm;
        }
        public void EjectCard()
        {
            Console.WriteLine("Card ejected"); 
            atm.SetState(new ReadyState());
        }

        public void EnterPin(int pin, Client client)
        {
            if(pin.Equals(client.PIN))
            {
                Console.WriteLine("Welcome. Choose next option");
                atm.SetState(new OperationSelectionState());
            }
            else
            {
                Console.WriteLine("Incorrect PIN");
            }
        }

        public void GetCash(int amount, Client cl)
        {
            Console.WriteLine("Enter PIN first");
        }

        public void InsertCard()
        {
            Console.WriteLine("Card has been already inserted");
        }
    }
}
