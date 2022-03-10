using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint gi = 100u;
            float f = 10.2f;
            double d = 1256556.5d;
            long ln = 65665656L;
            ulong ul = 2454ul;
            decimal c = 10.4m;

            Console.WriteLine("------Datatypes------\nuint - " + gi + "\nfloat - " + f + "\ndouble - " + d + "\nlong - " + ln + "\nulong - " + ul + "\ndecimal" + c);

            // default values
            //int im = default(int); //output=0;
            //float df = default(float);

            //int ip = 1234;
            //float isaf = ip;
            //string s = "message";


            char[] ch = { 'a', 'b', 'c' };
            string s2 = new string(ch);
            foreach (char ca in ch)
            {
                Console.WriteLine(ca);
            }
            Console.WriteLine(s2);
            string s3 = @"test@gmail.com";
            Console.WriteLine(s3);

            string s4 = "hi \n" + "hello\n" + "value";
            Console.WriteLine(s4);
            string s5 = @"hi hello value";
            Console.WriteLine(s5);

            string firstname = "John";
            string lastname = "smith";
            string fullname = $"Dr. {firstname} {lastname}";
            Console.WriteLine(fullname);


            //-1. Odd & Even

            Console.WriteLine("Enter a number");
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }


            //-2. String concatination

            string str1, str2;
            Console.WriteLine("Enter your Name");
            string name = Console.ReadLine();
            int z = name.Length;
            //int myArray = name.Split("", 3);
            if (name.Length > 5)
            {
                str1 = name.Substring(0, (int)(z / 2));
                str2 = name.Substring((int)(z / 2));
                Console.WriteLine("String 1 : " + str1 + "\nString 2 : " + str2);
            }


            //-3. factorial of a number
            int fact = 1;
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);

            // practice
            Console.WriteLine("Enter a number");
            int num2;
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Entered number is even");
            }
            else
            {
                Console.WriteLine("Entered number is Odd");
            }

            //datetime

            DateTime dt = new DateTime();
            Console.WriteLine(dt);

            DateTime dt2 = new DateTime(2022, 07, 03, 5, 10, 50, DateTimeKind.Utc);
            Console.WriteLine(dt2);

            Console.WriteLine(DateTime.MinValue.Ticks);
            Console.WriteLine(DateTime.MaxValue.Ticks);
            

            DateTime today = DateTime.Today;
            Console.WriteLine(today);

            DateTime currentDateTimeUTC = DateTime.UtcNow;
            Console.WriteLine(currentDateTimeUTC);

            //$ is ued for string interpolation

            var st = "4/4/1977";
            Console.WriteLine(st);


            //Task 1:-8/03/2022
            //Calculate Age
            Console.WriteLine("Enter Your date of birth");
            var dob = Console.ReadLine();

            var da2 = Convert.ChangeType(dob, typeof(DateTime));
            Console.WriteLine(da2);
            int age = 0;
            age = DateTime.Now.Subtract((DateTime)da2).Days;
            age = age / 365;
            Console.WriteLine("Your Age - " + age);

            DateTime dt1 = new DateTime();
            Console.WriteLine("Enter Your date of birth");

            dt1 = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(dt1);


            //struct Person
            Person person = new Person("James", "Bond");
            Console.WriteLine(person.firstname);
            Console.WriteLine(person.lastname);

            Person person1 = Person.GetDaetail();

            //Struct Name
            name nm = new name();
            Console.WriteLine(nm.pname);
            

            //String Builder

            StringBuilder sb = new StringBuilder("Good Morning ");

            for (int i = 0; i < sb.Length; i++)
            {
                Console.Write(sb[i]);

            }
            sb.Append("James");
            Console.WriteLine(sb);
            sb.Insert(5, "hello");
            Console.WriteLine(sb);
            sb.Remove(2, 4);
            Console.WriteLine(sb);
            sb.Replace("Morning", "Right");
            Console.WriteLine(sb);


            //Task 2:-"String Builder" 8/03/2022

            String name2;
            Console.WriteLine("Enter full name");
            String ss = Console.ReadLine();
            StringBuilder sb2 = new StringBuilder(ss);
            Console.WriteLine(sb2);
            Console.WriteLine("Do you want to append ( yes / no )");
            String check;
            check = Console.ReadLine();
            
            
            if (check == "yes")
            {
                Console.WriteLine("\nEnter a name");
                name2 = Console.ReadLine();
                sb2.Append(name2);
                Console.WriteLine("New string - "+sb2);
            }
            else
            {
                Console.WriteLine(sb2);
            }

            int a = 10;
            Console.WriteLine(a.GetType());

            Nullable<int> x = null;
            Console.WriteLine(x.Value);

            //int? a=null;
            //int no = 10;

        }
        //Struct 1
        struct Person
        {
            public string firstname;
            public string lastname;
            public Person(String FirstName, String LastName)
            {
                this.firstname = FirstName;
                this.lastname = LastName;
            }

            public static Person GetDaetail()
            {
                return new Person();
            }
        }


        //Struct 2
        struct name
        {
            public String pname;

            public name(String pname)
            {
                this.pname = pname;
            }
            public static name setname()
            {
                StringBuilder nm = new StringBuilder("hello");
                return new name();

            }


        }
    }
    }
