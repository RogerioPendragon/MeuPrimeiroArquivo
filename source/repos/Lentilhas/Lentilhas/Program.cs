using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Lentilhas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade desejada de lentilhas: ");
            decimal qte = Convert.ToDecimal(Console.ReadLine());
            decimal preco = Convert.ToDecimal(1.50);
            double total = Convert.ToDouble((qte * preco));
            Console.WriteLine("Quantidade adquirida de lentilha foi de: " + qte + " é o preco total foi de: " + total,CultureInfo.InvariantCulture);
            Console.ReadLine();
        }
    }
}
