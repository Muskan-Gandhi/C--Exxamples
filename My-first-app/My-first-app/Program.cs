using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_first_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int top, frp;
            Console.WriteLine("Enter To port no");
            top = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter from port");
            frp = Convert.ToInt32(Console.ReadLine());
            IList<string> list = new List<string>() { "Louisiana", "Texas", "Gujarat", "Odisha" };
            IDictionary<int, string> ports = new Dictionary<int, string>();
            ports.Add(101, "Louisiana");
            ports.Add(102, "Texas");
            ports.Add(103, "Gujarat");
            ports.Add(104, "Odisha");
            foreach (KeyValuePair<int, string> kvp in ports)
            {
                if (kvp.Key == top)
                {
                    Console.WriteLine("\nPort no -:{0} , Location -:{1}", kvp.Key, kvp.Value);
                }
                if (kvp.Key == frp)
                {
                    Console.WriteLine("Port no -:{0} , Location -:{1}", kvp.Key, kvp.Value);
                }

            }
            int size = 100, no = 0, we = 0, s = 0, c = 0;
            Console.WriteLine("Enter number of containers");
            no = Convert.ToInt32(Console.ReadLine());
            while (no > 0)
            {
                Console.WriteLine("Enter weight of goods");
                we = Convert.ToInt32(Console.ReadLine());
                s = s + we;
                if (s > size)
                {
                    Console.WriteLine("Overloaded cannot add more containers");
                    Console.WriteLine("No of containers - " + c);
                    Environment.Exit(0);
                }

                no--;
                c++;
            }



        }
    }
}
