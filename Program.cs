using System.Net.Mail;
using System.Collections.Generic;
using System.Collections;

namespace GenericDemo300724
{ interface Iinter123<T>
    {
        public void method1(T t1);
        public T sum(T a1,T b1);
    }
    class classxyz<T,Q>
    {
        public void method2(T a, Q b)
        {
            Console.WriteLine("a= " + a + " b=" + b);
            Console.WriteLine("a type =" + a.GetType());
            Console.WriteLine("b type =" + b.GetType());
        }
        public void show(int x)//Non Generic
        {
            Console.WriteLine(x++);
        }
        public void genMethod123(T a)//Generic method
        {
            Console.WriteLine("a ="+a+" data type="+a.GetType());
        }
    }
    class abcd
    {
        
        //Generic Method with multiple generic parameters
        public void method2<T,Q>(T a, Q b)
        {
            Console.WriteLine("a= "+a+" b="+b);
            Console.WriteLine("a type ="+a.GetType());
            Console.WriteLine("b type =" + b.GetType());
        }
        public void sum<T>(T x,T y)
        {
            dynamic x1 = x;
            dynamic y1 = y;
           T z;
            z = x1 + y1;
            Console.WriteLine(z+" type of z= "+z.GetType()+" z length="+z.ToString().Length);
        }
        //Generic Method Writting
        public void GenMethod<T>(T x)//1 parameter
        {
            Console.WriteLine("x= "+x+" data type of x="+x.GetType());
        }
    }
    class myClass
    {
        public void myMethod(int x)
        {
            Console.WriteLine("x="+x);
        }
        public void myMethod(string st)
        {
            Console.WriteLine("st=" + st);
        }
        public void myMethod(double st)
        {
            Console.WriteLine("st=" + st);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region generic method ,class interface demo
            //myClass obj=new myClass();
            //   obj.myMethod(100);

            //   obj.myMethod("pune");
            //   //

            //   obj.myMethod(3.15);

            //abcd obj1 = new abcd();
            ////obj1.avg();
            //obj1.sum(1, 2);
            //obj1.ToString();

            //obj1.GenMethod(100);

            //obj1.GenMethod("pune");
            //float fp = 3.14f;
            //obj1.GenMethod(3.14f);

            //obj1.sum(100, 200);
            //obj1.sum("GTH", "Pune");

            //obj1.method2(3.14, "pune");
            //obj1.method2(100, 3.1456);
            //obj1.method2("pune", "Nashik");
            //obj1.method2<double, int>(9.58,400);

            //---------------------------

            ////Generic class use

            //classxyz<float,double> objxyz = new classxyz<float,double>();
            //objxyz.show(100);
            //objxyz.genMethod123(1.12f);
            //objxyz.method2(6.6f, 7.8);

            //classxyz<string,string> objpqr=new classxyz<string,string>();
            //objpqr.genMethod123("3.14");
            //objpqr.method2("GTH", "Pune");
            #endregion

            List<int> l1 = new List<int>();
            l1.Add(100);
           // l1.Add("pune"); //error only int allowed


            ArrayList arl1 = new ArrayList();
            arl1.Add(100);
            arl1.Add("pune");

            int x =(int) arl1[0];

            int y = l1[0];

            List<abcd> l2 = new List<abcd>();
           


        }
    }
}
