using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagOfHolding
{
    class Program
    {
        static void Main(string[] args)
        {
            BagOfHolding Bag = new BagOfHolding();
            while (true)
            {
                switch (Bag.options())
                {
                    case 1:
                        Bag.list();
                        break;
                    case 2:
                        Bag.add();
                        break;
                    case 3:
                        Bag.list();
                        Bag.remove();
                        break;
                    default:
                        Console.WriteLine("What the hell are you trying to do?!");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
    class BagOfHolding
    {

        private string[] contents = new string[0];




        public int options()
        {
            Console.WriteLine("1. Look in the Bag of Holding  ");
            Console.WriteLine("2. Put an item into the Bag of Holding ");
            Console.WriteLine("3. Remove an item from the Bag of Holding  ");
            return userinput();
        }
        public void list()
        {

            if (contents.Length < 1)
            {
                Console.WriteLine("The bag of holding is empty");
            }
            else
            {
                int cycle = 1;
                foreach (string k in contents)
                {
                    Console.WriteLine("{0}. {1}", cycle, k);
                    cycle++;
                }
            }
            Console.ReadLine();

        }
        public void add()
        {
            Console.WriteLine("What would you like to add?");
            string stuff = Console.ReadLine();
            string[] temp = new string[contents.Length + 1];
            for (int i = 0; i < contents.Length; i++)
            {
                temp[i] = contents[i];
            }
            temp[contents.Length] = stuff;
            contents = temp;
        }
        public void remove()
        {
            if (contents.Length == 0)
            {
                Console.WriteLine("There is nothing to remove...");
                return;
            }
            Console.WriteLine("Which item  would you like to remove?");
            int itemnumber = userinput() - 1;
            string[] temp = new string[contents.Length - 1];
            int j = 0;
            for (int i = 0; i < contents.Length; i++)
            {
                if (i != itemnumber)
                {
                    temp[j] = contents[i];
                    ++j;
                }
            }
            contents = temp;

        }

        public int userinput()
        {
            int number;
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
                return number;
            }
            catch (Exception)
            {
                Console.WriteLine("What the hell are you trying to do?!");
                return 4;
            }
        }

    }
}