using System.Net.Mail;
using System.Collections.Generic;
using System.Collections;
using System.Drawing;

namespace GenericDemo300724
{
    class abcd1 : IComparer,IComparer<student>
    {
        public int Compare(object? x, object? y)
        {
            return Compare((student)x, (student)y);
        }

        public int Compare(student? x, student? y)
        {
            return string.Compare(x.name, y.name);
        }
    }
    class teacher
    {
        public string name { get; set; }
    }
    class sortByName : IComparer<student>
    {
       
        public int Compare(student? x, student? y)
        {
            //return string.Compare(x.name, y.name)*-1;

            if (string.Compare(x.name,y.name)>0)
            {
                return 1;
            }
            else if (string.Compare(x.name, y.name) < 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
    class student : IEquatable<student>,IComparable<student>
    {
        #region
        //private int _roll;
        //public int roll
        //{
        //    set { _roll = value; }
        //    get { return roll; }
        //}
        //private string name;

        //public string Name
        //{
        //    set { name = value; }
        //    get { return name; }
        //}
        #endregion
        public int roll { get; set; }
        public string  name { get; set; }
        public int totalMarks { get; set; }

        public int CompareTo(student? obj)
        {
            if (this.roll>obj.roll)
            {
                return 1;
            }
            else if (this.roll< obj.roll)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public bool Equals(student? other)
        {
            if (roll==other.roll )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void showStudent()
        {
            //Console.WriteLine("Roll="+roll+"\t Name="+name);
            Console.WriteLine($"Roll= {roll}\tName= {name}\tTotal Marks= {totalMarks} ");
        }

    }
    
    interface Iinter123<T>
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

            #region
            // List<int> l1 = new List<int>();
            // l1.Add(100);
            //// l1.Add("pune"); //error only int allowed


            // ArrayList arl1 = new ArrayList(); //non generic
            // arl1.Add(100); // 100 converted into object  boxing
            // arl1.Add("pune");// string pune converted into object  //boxing done

            // int x =(int) arl1[0];// unboxing convert object type to int type

            // int y = l1[0];

            // List<abcd> l2 = new List<abcd>();  //generic

            // List<int> L3 = new List<int>();//generic L3


            // L3.Add(100);

            // List<AA> L4 = new List<AA>();

            // AA objA = new AA();
            // BB objB = new BB();

            // L4.Add(objA);//valid

            #endregion

            #region
            //List<int> l6 = new List<int>();
            //l6.Add(11);
            //l6.Add(22);

            //l6.Sort();

            // Console.WriteLine("11 ==>"+ l6.Contains(11));//true

            //object initialisation
            //student s1 = new student() { roll = 1 ,name="rajesh",totalMarks=874};//1000

            //student s2 = new student() { roll = 2, name = "dinesh", totalMarks = 675 };
            //student s3 = new student() { roll = 4, name = "darshan", totalMarks = 999 };
            //student s4 = new student() { roll = 5, name = "vinod", totalMarks = 233 };
            //student s5 = new student() { roll = 3, name = "mahesh", totalMarks = 453 };

            //List<student> stdList = new List<student>();

            //stdList.Add(s1);
            //stdList.Add(s2);
            //stdList.Add(s3);//s3==> roll  41
            //stdList.Add(s4);
            //stdList.Add(s5);

            //Console.WriteLine("All Student Information");

            //foreach (student item in stdList)
            //{
            //    item.showStudent();
            //}

            //  student s6=new student() { roll = 41, name = "darshan", totalMarks = 999 };

            //  Console.WriteLine("s3 add="+s3.GetHashCode());
            //  Console.WriteLine("s6 add=" + s6.GetHashCode());

            //  s3.roll = 41;
            //  // s6.showStudent();

            //  stdList.Sort();
            ////  Console.WriteLine(stdList.Contains(s3));


            //  Console.WriteLine("All Student Information************************");

            //  foreach (student item in stdList)
            //  {
            //      item.showStudent();
            //  }
            //  sortByName sbn = new sortByName();
            //  stdList.Sort(sbn);


            //  Console.WriteLine("All Student Information************************");

            //  foreach (student item in stdList)
            //  {
            //      item.showStudent();
            //  }
            //  stdList.Reverse();
            //  Console.WriteLine("All Student Information************************");

            //  foreach (student item in stdList)
            //  {
            //      item.showStudent();
            //  }
            //  student st999 = new student() { roll = 3, name = "mahesh", totalMarks = 453 }; ;
            //  Console.WriteLine("index of student=" +stdList.BinarySearch(st999));

            // abcd1 abobj = new abcd1();
            // sortByName sbnTeacher = new sortByName();

            //// stdList.Sort(abobj);
            // ArrayList arl = new ArrayList();
            // arl.Add(s1);
            // arl.Add(s2);
            // arl.Sort(abobj);

            // Console.WriteLine("All Student Information************************");

            // foreach (student item in stdList)
            // {
            //     item.showStudent();
            // }
            #endregion

            Dictionary<int, string> d1 = new Dictionary<int, string>();
            //Dictionary<int, student> d2 = new Dictionary<int, student>();

            //List<student> stdlistMCA = new List<student>();

            //List<student> stdlistEngg = new List<student>();
            //List<student> stdlistBCA = new List<student>();
            //Dictionary<string, List<student>> d4 = new Dictionary<int, List<student>>();
            //d4.Add("MCA", stdlistMCA);
            //d4.Add("Engg", stdlistEngg);
            //d4.Add("BCA", stdlistBCA);

            d1.Add(3, "Threee");
            d1.Add(1, "one");
            d1.Add(5, "five");
            d1.Add(2, "Two");

            foreach (var item in d1)
            {
                Console.WriteLine(item.Key+"\t"+item.Value);
            }

            Console.WriteLine("------------------");
            SortedDictionary<string, int> sd1 = new SortedDictionary<string,int>();
            sd1.Add("Threee",3);
            sd1.Add("one",1);
            sd1.Add("five",5);
            sd1.Add("Two",2);

            foreach (var item in sd1)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }
        }
    }
}
