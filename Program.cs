using System;

namespace Amazon
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Type int,short,long,bool,byte,float,decimal,datateime,enum
            //Reference string,class ,array

            int exper = 10, passoutYesr = 2000;
            if(exper<=5 && passoutYesr>=2016)
            {
                Console.WriteLine("Fresher job");
            }
            else if(exper==6)
            {
                Console.WriteLine("Manager job");
            }

            switch(exper)
            {
                case 5: Console.WriteLine("Fresher");
                    break;
                case 6: Console.WriteLine("Manager");
                    break;
            }
            
            int a = 10, b = 5,c=90;
            switch(a>b && a>c)
            {
                case true: Console.WriteLine("max"+a);
                    break;
                case false: Console.WriteLine("Max"+b);
                    break;
            }
            float s = 9.4f;
            switch(s)
            {
                case 6.4f: Console.WriteLine("One");
                    break;
                case 9.4f: Console.WriteLine("two");
                    break;

            }

            char r = Convert.ToChar(Console.ReadLine());
            switch(r)
            {
                case 'a': 
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'A':
                    Console.WriteLine("Vowel");
                    break;

            }
            Console.WriteLine("1-Laptop 2-Mobile");
            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1: Console.WriteLine("****Laptop*****");
                          Console.WriteLine("1-Dell 2-Lenova 3-Samsung");
                          int ch= int.Parse(Console.ReadLine());
                          switch(ch)
                          {
                            case 1: Console.WriteLine("Dell Laptop");
                            break;
                          }
                    break;
            }
        }
    }

    class EE
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter amt");
            int amt = int.Parse(Console.ReadLine());
            int n2000 = amt / 2000;
            amt = amt % 2000;
            int n500 = amt / 500;
            amt = amt % 500;
            int n200 = amt / 200;
            amt = amt % 200;
            int n100 = amt / 100;
            amt = amt % 100;


            Console.WriteLine("2000 notes="+n2000);



        }
    }
}
