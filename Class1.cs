using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Person
    {
        private string pin;
        private double balance;
        private string con_pin;
        public string Pin { get { return pin; } set { pin = value; } }
        public double Balance { get { return balance; } set { balance = value; } }
        public string Con_Pin { get { return con_pin; } set { con_pin = value; } }

    }
}
