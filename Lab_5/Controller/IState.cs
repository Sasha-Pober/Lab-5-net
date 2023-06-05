using System;
using System.Collections.Generic;
using System.Text;

namespace Controller
{
    public interface IState
    {
        void SetATM(Context atm);
        void InsertCard();
        void EjectCard();
        void EnterPin(int pin, Client cl);
        void GetCash(int amount, Client cl);
    }
}
