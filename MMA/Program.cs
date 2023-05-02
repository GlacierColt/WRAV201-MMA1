using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Program();
        }

        int num = 99;

        public Program()
        {
            Pet p1 = new Pet("Hi");
            Pet p2 = new Cat("World", 17);
            Pet p3 = p1;
            int q = num;
            p1.DSS("UUU");
            p2.DSS("RRR");
            p1.Display();
            p2.Display();
            doInt(p1.i1);
            doString(p2.s1);
            p1.Display();
            p2.Display();
           // ((Cat)p1).Display(); //error line
            ((Cat)p2).Display();
            doPInt(p2);
            doPString(p1);
            p1.Display();
            p2.Display();
            p3.Display();
            Pet pclone = p1.Clone();
            bool hellloo = p1.Equals(p2);
        }
        public void doInt(int x)
        {
            x = num;
            Console.WriteLine(x);
        }
        public void doString(String s)
        {
            s = "ABC";
            Console.WriteLine(s); //Line A
        }
        public void doPInt(Pet p)
        {
            p.i1 = 77;
        }
        public void doPString(Pet p)
        {
            p.s1 = "XYZ";
        }



    }

    class Pet
    {
        public String s1;
        public int i1 = 0;
        public Pet(String s3)
        {
            s1 = s3;
        }
        public virtual void DSS(String s2)
        {
            s1 = s1 + s2;
            i1++;
        }
        public void Display()
        {
            Console.WriteLine(s1 + " " + i1);
        }

        public Pet Clone()
        {
            Pet pclone = new Pet(s1);
            return pclone;
        }

        public override bool Equals(Object obj)
        {
            Pet temp = (Pet)obj;    
            if (temp.s1 == s1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Cat : Pet
    {
        public Cat(String s4, int i2) : base(s4)
        {
            i1 = i2;
        }
        public override void DSS(string s2)
        {
            s1 = s2;
        }
        public new void Display()
        {
            Console.WriteLine("C" + s1 + " " + i1);
        }


    }
}
