using System;
using System.Collections.Generic;
using System.Text;

namespace Controller
{
    public interface IClient
    {
        void InsertCard();
        void EjectCard();
        void EnterPin(int pin);
        void GetCash(int amount);
    }
}
