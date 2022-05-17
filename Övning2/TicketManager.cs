using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning2
{
    internal class TicketManager
    {
        private const int youth = 20;
        private const int pensioner = 64;
        private uint inputValue;


        public void PriceInformation()
        {
            uint age = Myconsole.NumberInput();
            if (age > 0 && age < youth)
            {
                Myconsole.PrintInfo($"Ungdomspris 80 Kr");
            }
            else if (age > pensioner)
            {
                Myconsole.PrintInfo($"Pensionärspris 90 Kr");
            }
            else if (age >= youth && age <= pensioner)
            {
                Myconsole.PrintInfo($"Standardpris 120 Kr");
            }
            else
            {
                Myconsole.GetMeny();
            }

        }

        public uint PriceInput(string text)
        {
            uint ageInNumber;
            do
            {
                //Console.WriteLine("text");
                string answer = Console.ReadLine();
                if (uint.TryParse(answer, out ageInNumber))
                {
                    SetInput(ageInNumber);
                    return ageInNumber;
                }
                Myconsole.PrintInfo($"{text}");
            } while (true);
        }

        public void SetInput(uint i)
        {
            inputValue = i;
        }

        public uint GetInput()
        {
            return inputValue;
        }

        public void CalcultePrice()
        {
            int totalPrice = 0;
            List<Person> persons = new List<Person>();
            Myconsole.PrintInfo($"Hur många pensionärer?");
            PriceInput($"Hur många pensionärer?");
            persons.Add(new Person(GetInput(), 90, "Pensionär"));
            Myconsole.PrintInfo($"Hur många Standard?");
            PriceInput($"Hur många pensionärer?");
            persons.Add(new Person(GetInput(), 120, "Standard"));
            Myconsole.PrintInfo($"Hur många Ungdom?");
            PriceInput($"Hur många pensionärer?");
            persons.Add(new Person(GetInput(), 80, "Ungdom"));
            foreach (Person personInfo in persons)
            {
                Myconsole.PrintInfo($"{ personInfo.GetStatus()} {personInfo.GetTotalPrice()}" +
                    $"({personInfo.GetCount()}*{personInfo.GetPrice()})");
                totalPrice += personInfo.GetTotalPrice();
            }
            Myconsole.PrintInfo($"Summa: {totalPrice}");
        }
    }
}


