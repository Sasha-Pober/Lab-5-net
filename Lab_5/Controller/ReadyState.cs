using System;
using System.Collections.Generic;
using System.Text;

namespace Controller
{
    public class ReadyState : IState
    {
        private Context atm;

        public void SetATM(Context atm)
        {
            this.atm = atm;

        }
        public void InsertCard()
        {
            Console.WriteLine("Card inserted");
            atm.SetState(new PinEntryState());
        }

        public void EjectCard()
        {
            Console.WriteLine("Insert card first");
        }

        public void EnterPin(int pin, Client cl)
        {
            Console.WriteLine("Card isn't inserted");
        }

        public void GetCash(int amount, Client cl)
        {
            Console.WriteLine("Insert Card and enter PIN first");
        }
    }
}
