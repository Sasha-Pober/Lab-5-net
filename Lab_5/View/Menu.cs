using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;

namespace View
{
    public class Menu : IMenu
    {
        private readonly IClient client;

        public Menu(IClient client)
        {
            this.client = client;
        }

        public void InsertCard()
        {
            client.InsertCard();
        }
        public void EjectCard()
        {
            client.EjectCard();
        }
        public void EnterPin()
        {
            Console.WriteLine("Enter your PIN");
            int pin = int.Parse(Console.ReadLine());
            client.EnterPin(pin);
        }
        public void GetCash()
        {
            Console.WriteLine("Enter the amount of money you want to get");
            int amount = int.Parse(Console.ReadLine());
            client.GetCash(amount);
        }
    }
}
