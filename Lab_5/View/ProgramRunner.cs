using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;

namespace View
{
    public class ProgramRunner : IProgramRunner
    {
        private IMenu menu;

        private void SetMenu(Client cl)
        {
            menu = new Menu(cl);
        }

        public void Run()
        {

            Console.WriteLine("Enter Client's PIN");
            int pin = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Client's max amount of cash");
            int amount = int.Parse(Console.ReadLine());

            Client client = new(pin, amount);
            SetMenu(client);

            Dictionary<MenuItem, Action> command = new Dictionary<MenuItem, Action>()
            {
                { MenuItem.InsertCard, menu.InsertCard},
                { MenuItem.EjectCard, menu.EjectCard},
                { MenuItem.EnterPin, menu.EnterPin},
                { MenuItem.GetCash, menu.GetCash},
            };

            string ans = "";
            Console.WriteLine("1. Insert Card\n2. Eject Card\n3. Enter PIN\n4. Get Cash");

            while (!ans.ToLower().Contains("yes"))
            {
                Console.WriteLine("Enter a number of option:");
                int num = int.Parse(Console.ReadLine());
                if (Enum.TryParse((num - 1).ToString(), out MenuItem queryType) && command.ContainsKey(queryType))
                {
                    command[queryType]();
                }
                else
                {
                    Console.WriteLine("Invalid option number.");
                }
                Console.WriteLine("Do you wish to exit?");
                ans = Console.ReadLine();
            }
        }
    }
}
