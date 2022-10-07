using System;

namespace Chocolate
{
    class ChocolateBar
    {
        public ChocolateBar(string Name, double WeightInG, bool Melted, int Calories)
        {
            this.Name = Name;
            this.WeightInG = WeightInG;
            this.Melted = Melted;
            this.Calories = Calories;
        }

        /// <summary>
        /// Number of calaories per chocolate bar
        /// </summary>
        public int Calories;

        /// <summary>
        /// Weight in grams per chocolate bar
        /// </summary>
        public double WeightInG;

        /// <summary>
        /// Name of chocolate bar
        /// </summary>
        public string Name;

        /// <summary>
        /// If the chocolate has melted
        /// </summary>
        public bool Melted;

        /// <summary>
        /// Eat the chocolate bar
        /// </summary>
        public void Eat()
        {
            Console.WriteLine($"Yum! You just ate a {Name} which was {Calories} calories!");
            WeightInG = 0;
        }

        /// <summary>
        /// Throw the chocolate bar
        /// </summary>
        public void Throw()
        {
            Console.WriteLine("Ow!");
        }
    }
}