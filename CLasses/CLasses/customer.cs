using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLasses
{
    class Customer
    {
        public int Id;
        public string Name;

        public Customer()
        {
        }


        public Customer(int id)
        {
            this.Id = Id;
            
        }
        public Customer(int cid, string name)
        {
            this.Name = name;
            this.Id = cid;
        }
    }
}
