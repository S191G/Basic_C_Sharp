/*--------------ADD 2 numbers
using System;
namespace Second
{
    class Program
    {
        public static void Main(string[]args)
        {
            int a,b,r;
            Console.Write("Enter any two numbers:");
            a =Convert.ToInt32(Console.ReadLine());
            b =Convert.ToInt32(Console.ReadLine());
            r = a+b;
            Console.Write("Sum of the two numbers:"+r);
        }
    }
}
*/
/*---------------------IF statement-------------------*/
/*using System;
namespace Second
{
class Program{
          public static void Main(string[]args)
          {
            int PIN = 9456;
            Console.WriteLine("SAI KRISHNA");
            if(PIN==3456){
                Console.Write("he is from mumbai");
            }
            Console.WriteLine("9392704043");
          }
}
}*/
/*------------------------if-else------------------->
using System;
namespace Second
{
    class Program{
        public static void Main(string[]args)
        {
            int age = 45;
            if (age>=21){
                Console.WriteLine("Eligible to go to new year party");

            }
            else{
                Console.WriteLine("Eligible to go to family party ");
            }
        }
    }
}
*/

/*----------------------------if-else-if--------------->
using System;
namespace Second
{
    class Program{
        public static void Main(string[]args)
        {
            int marks=67;
            if(marks<35){
                Console.WriteLine("Failed in Test");
            }
            else if(marks==35){
                Console.WriteLine("Just got passed in Test");
            }
            else{
                Console.WriteLine("Passed in test & Good student");
            }
        }
    }
}
*/

/*--------------Switch----------------->
using System;
namespace First
{
    class Program{
        public static void Main(string[]args)
        {
            int ch;
            Console.WriteLine("Enter your choice! ");
            ch=Convert.ToInt32(Console.ReadLine());
            switch(ch){
                       case 1:Console.Write("Akhilesh");break;
                       case 2:Console.Write("Anshul");break;
                       default: Console.Write("Not Valid");break;
            }
        }
    }
}
*/

/*---------while-loop----------------->
using System;
namespace Sai
{
    class Program{
        public static void Main(string[]args)
        {
            int i=1;
            while(i<=7)
            {
                Console.Write(i+" ");
                i++;
            }
        }
    }
}
*/
/*---------------Do-while--------------->
using System;
namespace Sai
{
    class Program
    {
        public static void Main(string[]args)
        {
         int i=1;
         do
         {
            Console.Write(i+" ");
            ++i;
         } 
         while(i<70);
        }
    }
}
*/
/*--------------------For-loop------------>
using System;
namespace Sai
{
    class Program
    {
        public static void Main(string[]args)
        {
            for(int i=1; i<=500; i++)
            {
              Console.Write(i+" ");
            }
        }
    }
}
*/
/*----------------------for-Each-------------->
using System;
namespace Sai
{
    class Program{
        public static void Main(string[]args)
        {
          int[] a={1,2,3,4,5,6,7};
          foreach(int i in a)
          {
            Console.WriteLine(i);
          } 
        }
    }
}
*/
/*----------------------break------------------>
using System;
namespace Sai
{
    class Program{
        public static void Main(string[]args)
        {
            for(int i=1; i<=10;++i)
            {
                Console.Write(i+" ");
                if(i==5)
                {
                   break; 
                }
            }
        }
    }
}
*/
/*---------------------continue----------------->
using System;
namespace Sai
{
    class Program{
        public static void Main(string[]args)
        {
            for(int i=1; i<=10;++i)
            {
                if(i==6 || i==8)
                {
                   continue; 
                }
                 Console.Write(i+" ");
            }
        }
    }
}
*/
/*--------------------------goto---------------->
using System;
namespace Sai
{
    class Program{
        static void Main(string[]args)
        {
            int i = 1;
            go:
            if(i<=100)
            {
                Console.Write(i+" ");
                i++;
                goto go;
            }
        }
    }
}
*/
/*----------------------Arrays-------------->
using System;
namespace Sai
{
    class Program
    {
       public static void Main(string[]args)
        {
            int [] a = {1,2,3,4,5};
            foreach(int i in a )
            {
                Console.Write(" "+i);
            }
        }
    }
}
--------------------------------------------------------------------------
using System;
using System.Globalization;
namespace Sai
{
    class Program{
        static void Main(string[]args)
        {
            int[,] a = new int[2,2];
            Console.Write("enter the elements:");
            for (int i=0;i<2;++i)
            {
                for (int j=0;j<2;j++)
                {
                    a[i,j]=Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Matrix array elements:");
            for(int i=0;i<2;i++)
            {
               for (int j=0;j<2;j++)
               {
                Console.Write(a[i,j]+" ");
               }
               Console.WriteLine();  
            } 
        }
   }
}
*/
/*--------------String---------------->
using System;
namespace Sai
{
    class Program{
        public static void Main(string[]args)
        {
            string str = "KRISHNA", stre="sai";
            Console.Write(str);
            Console.Write(" "+str[3]);
            Console.Write(" "+str.Length+" ");
            Console.Write(str.Equals(stre));
            Console.Write("  "+stre+ " "+str);
            Console.Write(" "+str.ToLower());
            Console.Write(" "+stre.ToUpper());
        } 
    }
}
*/
/*------------------C#-Patterns--------------->
for (int r=1;r<=5;r++)
{
  for(int c=1;c<=r;c++)
  {
    Console.Write("* ");
  }
  Console.WriteLine();
}
*/
/*
for (int i=1;i<=5;i++)
{
    for (int j=5;j>=i;j--)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}
*/
/*
for (int i=1;i<=5;i++)
{
    for (int j=1;j<=5;j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}
*/
 