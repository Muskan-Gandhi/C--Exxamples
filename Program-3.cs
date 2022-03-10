using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List in collection 
            var numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            int[] arr = { 10, 20, 30 };
            numbers.AddRange(arr);
            Console.WriteLine("total number in list = " + numbers.Count);
            Console.WriteLine("\nlist element :");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }


            //customer Generic class collection
            
            
              var customer = new List<Customer>()
            {
                new Customer() { CustomerID = 1, FirstName ="james",LastName=""},
                new Customer() { CustomerID = 2, FirstName ="john",LastName=""},
            }; ;
            Console.WriteLine("\ndetail of cutomer : ");
            foreach (Customer c in customer)
            {
                Console.WriteLine(c.CustomerID + " " + c.FirstName);
            }


            //Port Application
            //Use of generic Collection generic datatypes
            int no = 0;
            int ch, p = 0, to, fr;
            Console.WriteLine("Enter a number");
            no = Convert.ToInt32(Console.ReadLine());
            ArrayList al = new ArrayList();
            while (no > 0)
            {
                Console.WriteLine("1. Import \n2. Export");

                ch = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("From :-");
                Console.WriteLine("1. Gujarat \n2.Odisha");
                fr = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("To :-");
                Console.WriteLine("1.Louisiana \n2.Texas");
                to = Convert.ToInt32(Console.ReadLine());
                if (fr == 1 && to == 1)
                {
                    p = 5000;
                }
                else if (fr == 1 && to == 2)
                {
                    p = 10000;
                }
                Console.WriteLine("Price - " + p);

                KeyValue<int, int> too = new KeyValue<int, int>();
                too.key = to;
                too.value = fr;
                Console.WriteLine(too.key + " - " + too.value);
                Console.WriteLine("Price - " + p);

                al.Add(too);
                no--;
            }
            Console.WriteLine("No of records " + al.Count);


            //Use of Dictionary
            int top, frp;
            Console.WriteLine("Enter port no From - ");
            top = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter port no To - ");
            frp = Convert.ToInt32(Console.ReadLine());
            IDictionary<int, string> port = new Dictionary<int, string>();
            port.Add(101, "Louisiana");
            port.Add(102, "Texas");
            port.Add(103, "Gujarat");
            port.Add(104, "Odisha");
            
            foreach (KeyValuePair<int, string> kvp in port)
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
            



            if (frp == 101 && (top == 102 || top == 103 || top == 104))
            {
                p = 5000;
            }
            else if (frp == 102 && (top == 101 || top == 103 || top == 101))
            {
                p = 10000;
            }
            else if (frp == 103 && (top == 101 || top == 102 || top == 104))
            {
                p = 4000;
            }
            else if (frp == 104 && (top == 101 || top == 102 || top == 103))
            {
                p = 8000;
            }
            Console.WriteLine("Price - " +p);







            //3 day cancellation

            /*
            Console.WriteLine("Make changes y/n");
            string change = Console.ReadLine();
            DateTime dt = DateTime.Now;
            Console.WriteLine("\nEnter date");

            int idate = Convert.ToInt32(dt.Day);
            string str7 = Console.ReadLine();
            DateTime dt2 = Convert.ToDateTime(str7);
            int jdate = Convert.ToInt32(dt2.Day);
            var k = jdate - idate;

            if (k <= 3)
            {
                if (change == "y" || change == "y")
                {
                    Console.WriteLine("Enter Port from - ");
                    string source = Console.ReadLine();
                    Console.WriteLine("Enter new Port to - ");
                    string dest = Console.ReadLine();
                    Console.WriteLine("from = " + source + " " + "\nto = " + dest);


                }
            }
            */
            
            




            /*int ntop, nfrp;
            Console.WriteLine("Enter port no");
            ntop = Convert.ToInt32(Console.ReadLine());
            nfrp = Convert.ToInt32(Console.ReadLine());
            DateTime today = DateTime.Today;
            Console.WriteLine("Date - " + today);

            DateTime ct1 = DateTime.Now.AddDays(3);
            Console.WriteLine("Price - " + p);
            DateTime dt = DateTime.Today;
            Console.WriteLine("Enter a date");
            dt = Convert.ToDateTime(Console.ReadLine());
            int result = DateTime.Compare(dt, ct1);
            Console.WriteLine("1.Cancel the appointment with 3 days\n2.Change port");
            dynamic cl = Console.ReadLine();
            switch (cl)
            {
                case 1:
                    if (result < 0)
                    {
                        Console.WriteLine("Not able to cancel");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }

            */

        }
        class KeyValue<Tkey, Tvalue>
        {
            public Tkey key { get; set; }
            public Tvalue value { get; set; }
        }
        public class Customer
        {
            public int CustomerID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }





}
        