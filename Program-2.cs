using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public interface Vehicle
    {
        void car();
    }
    public class Driver : Vehicle
    {
        public void car()
        {
            Console.WriteLine("car");
        }
    }
    internal class Program
    {
        //Loan Application
        struct Customer
        {
            public String Name;
            public int Age;
            public int totamt;


            public Customer(string Name, int Age)
            {
                this.Name = Name;
                this.Age = Age;
                this.totamt = 10000;
            }
        }


        enum months
        {
            january,
            february,
            march,
            april
        }

        //interface
        public interface age
        {
            int age();
        }
        

        public class customer : age
        {

            public int age()
            {
                String name;
                DateTime dob;
                Console.WriteLine("Enter name and DOB");
                name = Console.ReadLine();
                dob = Convert.ToDateTime(Console.ReadLine());
                int age = 0;
                age = DateTime.Now.Subtract(dob).Days;
                age = age / 365;
                return age;
            }

            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter name and age");
            String Name;
            int Age;
            int interest = 0;

            //int totamt=10000;
            Name = Console.ReadLine();
            Age = Convert.ToInt32(Console.ReadLine());

            Customer customer = new Customer(Name, Age);

            switch (customer.Age)
            { 
                case int i when i > 0 && i < 25: interest = (customer.totamt * 20) / 100; break;
                case int i when i > 25 && i < 45: interest = (customer.totamt * 35) / 100; break;
                case int i when i > 45: interest = (customer.totamt * 50) / 100; break;
                default: Console.WriteLine("Incorrect Value Entered"); break;
            }
            //totamt = totamt + interest;
            customer.totamt = customer.totamt + interest;

            Console.WriteLine("---------Customer Details----------- \nCustomer Name :- " + customer.Name);
            Console.WriteLine("Interest - " + interest);
            Console.WriteLine("Customer Age :- " + customer.Age);
            Console.WriteLine("Total Amount :- " + customer.totamt);

            customer ct1 = new customer();
            int age;
            //double total = 5000;
            age = ct1.age();
            Console.WriteLine("Age - " + age);


            Console.WriteLine(months.january);
            int p = (int)months.february;
            Console.WriteLine(p);


            //dynamic
            dynamic dy1 = 1;
            dynamic dy2 = "james";
            Console.WriteLine(dy1.GetType());
            Console.WriteLine(dy2.GetType());


            Driver v = new Driver();
            v.car();

            

            String[] username = { "Sam", "Ram", "Meena", "James", "John" };
            int[] userage = { 10, 20, 5, 15, 25 };

            for (int z = 0; z < username.Length; z++)
            {

                for (int j = 0; j < userage.Length; ++j)

                {
                    if (z == j)
                        Console.WriteLine(username[z] + " " + userage[j]);

                }
            }
            Array.ForEach(userage, x => Console.WriteLine(x));
            Console.WriteLine(userage.Max());
            Console.WriteLine(Array.BinarySearch(userage, 20));



            //Array
            int[] num = new int[5] ;
            int i;
            Console.WriteLine("Enter a number");
            i = Convert.ToInt32(Console.ReadLine());
            int[] newarr = new int[i - num.Length];
            
                
                for (int x = 0; x < num.Length; x++)
                {
                    Console.WriteLine("Enter a number");
                    num[x] = Convert.ToInt32(Console.ReadLine());
                }

            if (i > num.Length)
            {

                for (int x = 0; x < newarr.Length; x++)
                {
                    Console.WriteLine("Enter a number");
                    newarr[x] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Array 1 -");
            for (int x = 0; x < num.Length; x++)
            {
                Console.WriteLine(num[x]+"");
            }
            Console.WriteLine("Array 2 -");
            for (int x = 0; x < newarr.Length; x++)
            {
                Console.WriteLine(newarr[x] + "");
            }


            ArrayList al= new ArrayList();
            al.Add("20");
            al.Add(55);
            al.Add(10);
            al.Add(20);
            al.Add(30);
            Console.WriteLine(al);
            //al.Remove(55);
            //al.RemoveAt(1);
            //al.RemoveRange(1, 3);
            al.AddRange(num);
            al.AddRange(newarr);
            Console.WriteLine(al.Count);
            Console.WriteLine(al.Contains(10));
        }

    }
    }

