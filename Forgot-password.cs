using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary
            IDictionary<int, string> dnum = new Dictionary<int, string>();
            dnum.Add(1, "A");
            dnum.Add(2, "B");
            dnum.Add(3, "C");
            dnum.Add(4, "D");
            foreach (KeyValuePair<int, string> kvp in dnum)
            {
                Console.WriteLine("key:{0},value:{1}", kvp.Key, kvp.Value);
            }


            //Console Application to add user and change password
            dynamic ch, ct;
            string firstname, lastname, q1,q2,f1;
            Console.WriteLine("Admin");
            
                    Console.WriteLine("---------Enter user details--------");
                    Console.WriteLine("------ Enter details ------");
                    Console.Write("FirstName - ");
                    firstname = Console.ReadLine();
                    Console.Write("Address - ");
                    lastname = Console.ReadLine();
                    Console.Write("Contact - ");
                    ct = Console.ReadLine();
                    var login = new List<login>()
                    {
                        new login(){ FirstName =firstname,LastName=lastname,Contact=ct}

                    };
            
                    Console.WriteLine("Secret Questions - ");
                    Console.WriteLine("Enter your school name");
                    q1 = Console.ReadLine();
                    Console.WriteLine("Enter you age");
                    q2 = Console.ReadLine();
                    dynamic pass = firstname.Substring(0, 3);

                    foreach (login i in login)
                    {
                        Console.WriteLine("firstname = " + i.FirstName);
                        Console.WriteLine("lastname = " + i.LastName);
                        Console.WriteLine("phone number = " + i.Contact);
                    }

                    IDictionary<dynamic, dynamic> user = new Dictionary<dynamic, dynamic>();
                    Console.WriteLine(pass);
                    IDictionary<dynamic, dynamic> question = new Dictionary<dynamic, dynamic>();
                    
                    Console.WriteLine("---Change password---");
                    Console.Write("Enter old password - ");
                    dynamic oldpass = Console.ReadLine();
                    dynamic newpass = 0;
                    if (pass == oldpass)
                    {
                        Console.WriteLine("-------Success------------");
                        Console.Write("Enter new password - ");
                        newpass = Console.ReadLine();
                    }
                    Random rnd = new Random();
                    int num = rnd.Next();

                    user.Add(num, newpass);

                    foreach (KeyValuePair<dynamic, dynamic> kvp in user)
                    {
                        if (kvp.Key == num)
                        {
                            Console.WriteLine("\nUser Id -:{0} , Password -:{1}", kvp.Key, kvp.Value);
                        }

                    }
                    question.Add(num, q1);
                    question.Add(num, q2);
                    Console.WriteLine("1.Forgot Password\n2.Exit");
                    ch = Convert.ToInt32(Console.ReadLine());
            string changepass;
                    if (ch == 1)
                    {
                //forget password
                Console.WriteLine("Enter your age : ");
                f1 = Console.ReadLine();
                foreach (KeyValuePair<dynamic, dynamic> kvp in question)
                {
                    if (kvp.Key == num && kvp.Value == f1)
                    {
                        Console.WriteLine("\nUser Id -:{0} , Password -:{1}", kvp.Key, kvp.Value);
                        Console.WriteLine("Enter new password");
                        changepass= Console.ReadLine();
                        user.Add(num, newpass);
                        break;
                    }

                }
            }
        }
        public class login
        {
            
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Contact { get; set; }
        }

    }
        }
