using System;
using System.Collections.Generic;
using System.Text;

namespace Controller
{
    public class Client : IClient
    {
        private Context context;
        public int PIN { get; }
        public int Restriction { get; }

        public Client(int pin, int restric)
        {
            PIN = pin;
            Restriction = restric;
            this.context = new Context(new ReadyState());
        }

        public void InsertCard()
        {
            context.GetState().InsertCard();
        }

        public void EjectCard()
        {
            context.GetState().EjectCard();
        }

        public void EnterPin(int pin)
        {
            context.GetState().EnterPin(pin, this);
        }

        public void GetCash(int amount)
        {
            context.GetState().GetCash(amount, this);
        }
    }
}
