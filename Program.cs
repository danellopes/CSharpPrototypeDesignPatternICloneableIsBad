static class Program
{
    public class Person : ICloneable
    {
        public string[] Names;
        public Address Address;

        public Person(string[] names, Address address)
        {
            if (names == null)
            {
                throw new ArgumentNullException(paramName: nameof(names));
            }
            if (address == null)
            {
                throw new ArgumentNullException(paramName: nameof(address));
            }

            Names = names;
            Address = address;
        }

        public override string ToString()
        {
            return $"Names: {string.Join(" ", Names)}, Address: {Address}";
        }

        public object Clone()
        {
            // ICloneable doesn't make deep copies of arrays.
            return new Person(Names, (Address)Address.Clone());
        }
    }

    public class Address : ICloneable
    {
        public string StreetName;
        public int HouseNumber;

        public Address(string streetName, int houseNumber)
        {
            if (streetName == null)
            {
                throw new ArgumentNullException(paramName: nameof(streetName));
            }
            StreetName = streetName;
            HouseNumber = houseNumber;
        }

        public override string ToString()
        {
            return $"StreetName: {StreetName}, HouseNumber: {HouseNumber}";
        }

        public object Clone()
        {
            return new Address(StreetName, HouseNumber);
        }
    }

    static void Main(string[] args)
    {
        var john = new Person(new[] { "John", "Smith" }, new Address("London Road", 123));
        var jane = (Person)john.Clone();
        jane.Address.HouseNumber = 321;
        System.Console.WriteLine(john);
        System.Console.WriteLine(jane);
    }
}