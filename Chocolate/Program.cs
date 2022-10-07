using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolate
{
    class Program
    {
        static void Main(string[] args)
        {
            ChocolateBar boost = new ChocolateBar("boost",31.5,false,163);

            ChocolateBar rolo = new ChocolateBar("rolo",41.6,false,200);

            boost.Eat();
            rolo.Eat();

            Console.ReadLine();
        }
    }
}
