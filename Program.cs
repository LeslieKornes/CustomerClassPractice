namespace CustomerClassPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(543, "Nino");

            //this is an object initializer-quickly initializes an object w/o the need to call one of its ctors
            var customer2 = new Customer        
            {
                Name = "Andrew",
                Id = 1007
            };
        }
    }
}
