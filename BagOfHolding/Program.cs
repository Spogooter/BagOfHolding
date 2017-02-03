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
                Console.Clear();
                switch (Bag.options())
                {
                    case 1:
                        Bag.contents();
                        break;
                    case 2:
                        Bag.add();
                        break;
                    case 3:
                        Bag.contents();
                        Bag.remove();
                        break;
                    default:
                        Console.WriteLine("What the hell are you trying to do?!");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
    class BagOfHolding
    {

        private string[] contentsarray = new string[0];



// Skriver menuen 
        public void menu()
        {
            Console.WriteLine("1. Look in the Bag of Holding  ");
            Console.WriteLine("2. Put an item into the Bag of Holding ");
            Console.WriteLine("3. Remove an item from the Bag of Holding  ");
        }
//Kalder menufunktion og returnerer et brugerindtastet heltal
        public int options()
        {
            menu();
            return userinput();
        }
        public void contents()
        {

            if (contentsarray.Length < 1)
            {
                Console.WriteLine("The bag of holding is empty");
                return;
            }
            else
            {
                int cycle = 1;
                foreach (string k in contentsarray)
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
            string[] temp = new string[contentsarray.Length + 1];
            for (int i = 0; i < contentsarray.Length; i++)
            {
                temp[i] = contentsarray[i];
            }
            temp[contentsarray.Length] = stuff;
            contentsarray = temp;
        }
        public void remove()
        {
            if (contentsarray.Length == 0)
            {
                Console.WriteLine("There is nothing to remove...");
                return;
            }
            Console.WriteLine("Which item  would you like to remove?");
            int itemnumber = userinput() - 1;
            if (itemnumber > contentsarray.Length - 1)
            {
                Console.WriteLine("There is nothing there...");
                return;
            }
            string[] temp = new string[contentsarray.Length - 1];
            int j = 0;
            for (int i = 0; i < contentsarray.Length; i++)
            {
                if (i != itemnumber)
                {
                    temp[j] = contentsarray[i];
                    ++j;
                }
            }
            contentsarray = temp;

        }
//forsøger at konvertere brugerens input til int
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
                return 4;
            }
        }

    }
}