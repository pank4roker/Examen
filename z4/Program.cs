using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z4
{
    class Address
    {
        private string index;
        private string country;
        private string city;
        private string street;
        private int house;
        private int apartament;
        public Address() { }

        public Address(string index, string country, string city, string street, int house, int apartament)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            House = house;
            Apartament = apartament;
        }

        public string Index { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int House { get; set; }
        public int Apartament { get; set; }

        public void Show()
        {
            Console.WriteLine($"{Index}; {Country}; {City}; {street}; {House}; {Apartament}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address("123fd","Moscow","<gfg","gdg",123,76);
            address.Show();
            Console.ReadKey();
        }
    }
}
