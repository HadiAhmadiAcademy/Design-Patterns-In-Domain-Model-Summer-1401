namespace StrategySample
{
    public class Customer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Customer(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}