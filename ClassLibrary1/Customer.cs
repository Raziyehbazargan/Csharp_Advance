using System;

namespace Amazon
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public void Promote()
        {
            var calculator = new Calculator.RateCalculator();
            var rating = calculator.Calculate(this);
            Console.WriteLine("Promote logic changed.");

        }
        private int CalculateRating()
        {
            return 0;
        }
    }
}
