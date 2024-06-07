using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Encapsulation.Models
{
    internal class Customer
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }


        private int _age;
        public int Age {

            set
            {
                if(value < 18)
                {
                    throw new Exception("18 yasdan asagi giris qadagandir");
                }
                else
                {
                    _age = value;
                }
            }
            get
            {
                return _age;
            }
        }
    }
}
