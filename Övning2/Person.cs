using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning2
{
    internal class Person
    {
        private uint count;
        private int price;
        private int totprice;
        private string status;

        private List<Person> personlist = new List<Person>();

        public Person()
        {

        }
        public Person(uint count, int price, string status)
        {
            this.count = count;
            this.price = price;
            this.status = status;
            SetTotalPrice((int)count * price);
        }

        public void AddPerson(Person ps)
        {
            personlist.Add(ps);
        }

        public uint GetCount()
        {
            return this.count;
        }

        public int GetPrice()
        {
            return this.price;
        }


        public void SetStatus(String str)
        {
            this.status = str;
        }

        public string GetStatus()
        {
            return this.status;
        }

        public void SetTotalPrice(int i)
        {
            totprice += i;
        }

        public int GetTotalPrice()
        {
            return totprice;
        }      

    }
}


