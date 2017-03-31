using System.Collections.Generic;

namespace CustomerClassPractice
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; }

        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(int id)     //this inherits the parameterless ctors list instantiation
           : this()
        {
            this.Id = id;
        }

        public Customer(int id, string name)    //this inherits from the (id) ctor, thereby inheriting the instantiated list as well
            :this(id)                             
        {
            this.Name = name;
        }
                                                //NOT GOOD CODING PRACTICE THOUGH
       
    }
}
