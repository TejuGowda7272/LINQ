namespace ProductLinqDemo
{
    internal class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime ManufactureDate { get; set; }

        public void Display()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Price: {Price}, MfgDate: {ManufactureDate.ToShortDateString()}");
        }
    }
}
