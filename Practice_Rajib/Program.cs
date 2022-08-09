using System;
using Space1;
using Static_constructor;
using System.Collections;
using System.Linq;
//using Event_practice;



/*#region INHERITANCE CONCEPT
class Shape
    {
        protected float width, height;
        public void setHeightWidth(float h,float w)
        {
            height = h;
            width = w;
        }
    }

class Rectangle:Shape
    {
        public float area()
        {
            return width * height;
        }
    }

class Tester
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();

            Console.WriteLine("INPUT HEIGHT:- ");
            String s1 =Console.ReadLine();
            float i= float.Parse(s1);

            Console.WriteLine("INPUT WIDTH:- ");
            String s2 = Console.ReadLine();
            float j = float.Parse(s2);

            r.setHeightWidth(i, j);
            //int a=r.area();
            Console.WriteLine("Area of reactanle with width {0} & height {1} is {2}", i, j, r.area());
        }
    }

#endregion*/




/*#region METHOD OVERIDING ( POLYMORPHISM )
namespace OVERRIDING_CONCEPT
{
    public class OVERRIDING_CONCEPT_1
    {
        public virtual void PRINT()
        {
            Console.WriteLine("hello...");
        }
    }

    public class OVERRIDING_CONCEPT_2 : OVERRIDING_CONCEPT_1
    {
        public override void PRINT()
        {
            Console.WriteLine("welcome...");
        }
    }

    public class Tester
    {
        public static void Main()
        {
            OVERRIDING_CONCEPT_2 oc2 = new OVERRIDING_CONCEPT_2();
            oc2.PRINT();
        }
    }
}
#endregion*/




/*#region PROTECTED ACCESS MODIFIER CONCEPT IMPLEMENTATION

namespace protected_modifier
{
    public class A
    {
        public int a;
        protected int b;


    }

    public class B : A   //protected member b acccessible in this scope only (only only and only) using B object (only only and only)
    {
        void printDetails()
        {
            Console.WriteLine("Printing....B");

            A obj1 = new A();
            obj1.a = 65;
            //obj1.b = 89;    //Even the object of base class A is not able to acccess its own protected members if it tries to do it inside some other class

            B obj2 = new B();
            obj2.a = 3;
            obj2.b = 352;   //Derived class B object can acccess protected members of base class A in its own class only...

        }
    }
    public class C : B
    {
        void xyz()
        {
            C obj3 = new C();
            obj3.b = 77;  //protected b of base class A is accesible in the derived class C of derived class B of bse class A using object of C
        }
    }


    public class D   //protected member b not at all acccessible in this scope no matter which type of object we use to access it
    {
        public void printDetails()
        {
            Console.WriteLine("Printing....C");
            A obj1 = new A();
            obj1.a = 34;
            //obj1.b = 75;   //Even the object of base class A is not able to acccess its own protected members if it tries to do it inside some other class

            B obj2 = new B();
            obj2.a = 3;
            //obj2.b = 2;
        }
    }
    public class TesterClass
    {
        public static void Main()
        {
            A obj1 = new A();
            obj1.a = 12;
            //obj1.b = 45;  //Even the object of base class A is not able to acccess its own protected members if it tries to do it inside some other class

            B obj2 = new B();
            obj2.a = 3;
            //obj2.b = 352;  //B can not access protected member of base class A in some other class 
        }
    }

}

#endregion*/



/*#region CAllByRefernce 
class Practice_CBR
{
    
    static void Main()
    {
        Console.WriteLine("Enter your Integer-1 :- ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your Integer-2 :- ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Value-1 Before Function Call {0}", num1);
        Console.WriteLine("Value-1 Before Function Call {0}", num2);

        CallByRef c = new CallByRef();

        //Calling function by reference
        c.Cube(ref num1,ref num2);
        Console.WriteLine("Value After Function Call {0}", num1);
        Console.WriteLine("Value After Function Call {0}", num2);



    }
}
#endregion*/




/*#region Out Parameter(useful to return multiple values from function)
class out_parameter
{
    public static void Main()
    {
        Console.WriteLine("Enter your Integer-1 :- ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your Integer-2 :- ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Value-1 Before Function Call {0}", num1);
        Console.WriteLine("Value-1 Before Function Call {0}", num2);
    }
}
#endregion*/



/*#region Static_Constructor
class TestStaticConstructor
{
    public static void Main()
    {
        Intern s1 = new Intern(01, "Rajib");
        Intern s2 = new Intern(02, "Ram");
        Intern s3 = new Intern(03, "Sachin");
        Intern s4 = new Intern(04, "Vanshika");

        s1.Print();
        s2.Print();
        s3.Print();
        s4.Print();
    }
}
#endregion*/




/*#region Taking Input from user for intern details in array of user defined class data type......STATIC CONSTRUCTOR CONCEPT
class TestStaticConstructor_inputFromUser
{
    public static void Main()
    {
        Console.WriteLine("How many Interns details you want to fill");
        long n=Convert.ToInt64(Console.ReadLine());
        Intern[] arr =new Intern[n];
        for (int i=0;i<n;i++)
        {
            Console.Write("Enter the ID no. of intern-{0} :- ",i+1);
            int id=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the name   of intern-{0} :- ",i+1);
            String str=Console.ReadLine();
            Console.WriteLine("\n");

            arr[i] = new Intern(id,str);

        }
        for(int i=0;i<arr.Length;i++)
        {
            arr[i].Print();
        }
    }
}
#endregion*/




/*#region JaggedArrays
class JaggedARRRAYS
{
    public static void Main()
    {
        //Declaring Jagged arrray of size 2
        int[][] ja = new int[2][];

        //Declaring the size of member arrays of the jagged arrays 
        ja[0] = new int[6];
        ja[1] = new int[4];

        //Initialising Jagged arrray elements which are arrays of size 6 & 4 respectively 
        ja[0] = new int[] { 1, 2, 3, 4, 5, 6 };
        ja[1] = new int[] { 7, 8, 9, 10 };

        //Printing the values of jaggged arrays 
        foreach (int[] i in ja)
        {
            foreach (int j in i)
            {
                Console.Write("{0} ", j);
            }
            Console.WriteLine();
        }
    }
}
#endregion*/



/*#region INTERFACE CONCEPT
interface area
{
    void printArea()
    {

    }
}

public class rectangle:area
{
    public int length;
    public int breadth;
    public rectangle(int l,int b)
    {
        this.length = l;
        this.breadth = b;   
    }


    public void printArea()
    {
        Console.WriteLine("Area of your rectangle is {0}", length * breadth);
    }
}

public class circle : area
{
    public int radius;
    public void printArea()
    {
        Console.WriteLine("Area of your circle is {0}", radius * 3.14);
    }
}
public class mainClass
{
    public static void Main(string[] args)
    {
        rectangle r = new rectangle(3, 4);
        r.printArea();

        circle c =new circle();
        c.radius = 4;
        c.printArea();
    }
}
#endregion
*/



/*#region static concept...(Static variable, static classs,static methods)
static class sample
{
    static int i = 7;
    static int j = 33;
    public static void printF()
    {
        Console.WriteLine("hello sir....");
    }

    public static void Main()
    {
        Console.WriteLine(i);
        i = 3456;
        Console.WriteLine(i);
        printF();
    }
    
   
}
#endregion*/




/*#region List-1

//List<string> l = new List<string>();
//l.Add("Rajib");
//l.Add("RamKrishna");
//l.Add("Vanshika");
//l.Add("Sachin");

//Accessing elements of list using index through for loop
//for (int i = 0; i < l.Count; i++)
//{
//    Console.WriteLine(l[i]);
//}



//Accessing elements of list using foreach loop
//foreach (String ele in l)
//{
//    Console.WriteLine(ele);
//}



//Accessing elements of list using the ForEach() method
//l.ForEach(x=>Console.WriteLine(x));
//OR
//l.ForEach(Console.WriteLine);



//CALLING A FUNCTION WITH EACH ELEMENT  OF LIST AS PARAMETER...LIST ELEMENTS ACCESSED USING ForEach method()
//l.ForEach(Func);
//void Func(string y)
//{
//    y = y + " Welcome...";
//    Console.WriteLine(y);
//}



//l.ForEach(delegate (string ele)   //Acccessing using the ForEach method
//{
//    ele = ele + " Welcome....";  //Modifying the list element
//    Console.WriteLine(ele);
//});



//Accessing  AND printing elements of list using the string.Join() method in one line
//Console.WriteLine(string.Join(",", l));

#endregion*/






/*#region List-2


// Collection of string
string[] animals = { "Cow", "Camel", "Elephant" };

// Create a List and add a collection
List<string> animalsList = new List<string>(animals);

//List<string> animalsList = new List<string>();
//animalsList.AddRange(animals);
foreach (string a in animalsList)
    Console.WriteLine(a);


#endregion*/






/*#region Dictionary

//Create Dictionary
//Dictionary<int,string> dict = new Dictionary<int,string>();
var dict = new Dictionary<int, string>();

//Adding elements to the dictionary
dict.Add(1, "Rajib");
dict.Add(3, "Ramkrishna");
dict.Add(9, "Vanshika");
dict.Add(0, "Sachin");
//dict.Add(0, "Rajesh");    //ERROR (the key already exists)



//Printing individual elements using key
Console.WriteLine(dict[9]);
//console.writeline(dict[12]);            //ERROR (key dont exist)    



//Accesing indivdiual dictionary key and value using foreach loop
foreach (KeyValuePair<int, string> kvp in dict)
{
    Console.WriteLine("Key-{0}  =>  Value-{1}", kvp.Key, kvp.Value);
}

//foreach (var kvp in dict)
//{    Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
//     Console.WriteLine("Key-{0}  =>  Value-{1}", kvp.Key, kvp.Value);
//}


//ContainsKey() to check for an unknown key
if (dict.ContainsKey(3))
{
    Console.WriteLine(dict[3]);
}

//ContainsValue() to check for an unknown value
if (dict.ContainsValue("Rajib"))
{
    Console.WriteLine(dict[1]);
}

//use TryGetValue() to get a value of unknown key
string ans;
if (dict.TryGetValue(0, out ans))
{
    Console.WriteLine(ans);
}
#endregion*/




/*#region try catch statements
class mainClass
{
    public static void Main()
    {


        //DivideByZeroException
        try
        {
            int a = 9;
            int b = 0;
            int x = a / b;
        }
        //catch (DivideByZeroException ex)
        //          OR
        catch (Exception ex1)
        {
            //Console.WriteLine(ex1);
            //        OR
            Console.WriteLine("Your exception ---->{0} ", ex1.Message);
        }




        //IndexOutOfRangeException
        try
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine(arr.Length);
            Console.WriteLine(arr[9]);
        }
        //MULTIPLE CATCH BLOCKS....they are examined in order...so if any block gets executed, then the remaining below blocks don't get executed
        catch (DivideByZeroException ex2)
        {
            Console.WriteLine(ex2);
        }
        catch (InvalidCastException ex3)
        {
            Console.WriteLine(ex3.Message);
        }
        catch (IndexOutOfRangeException ex2)
        {
            Console.WriteLine("Last exception caught-->{0} ", ex2.Message);
        }
        catch (Exception ex2)
        {
            Console.WriteLine("Last exception caught-->{0} ", ex2.Message);
        }
        //The finally keyword is used as a block to execute a given set of statements, whether an exception is thrown or not thrown.
        finally
        {
            Console.WriteLine("Finally block has been succesfully executed");
        }
    }
}
#endregion*/





/*#region DateTime


DateTime dt = new DateTime();
Console.WriteLine(dt.ToString());

//Present(NOW) Date & Time
dt = DateTime.Now;
Console.WriteLine(dt.ToString());

//Creating DateTime obj and settting its value using constructor(Year, Month, Day)
DateTime dt2 = new DateTime(2001, 11, 07);
Console.WriteLine(dt2.ToString());

//setting both date and time by paassing them as  a parameter to the DateTime constructor
DateTime dt3 = new DateTime(2020, 12, 22, 04, 30, 59);
Console.WriteLine(dt3.ToString());

//DateTime - without time (but the time will be by default set to 12AM)
DateTime dt4 = new DateTime(1885, 09, 11, 23, 45, 29);
DateTime OnlyDate = dt4.Date;
Console.WriteLine(OnlyDate.ToString());

//DateTime - without time(ONLY DATE APPEARS)
DateTime dt5 = new DateTime(1700, 02, 28, 17, 55, 03);
Console.WriteLine(dt5.ToShortDateString());

//ONLY DATE written in word form
DateTime dt6 = new DateTime(1700, 02, 28, 17, 55, 03);
Console.WriteLine(dt5.ToLongDateString());
Console.WriteLine(DateTime.Now.ToLongDateString());





#endregion*/




/*#region NOT ALLOWED TO access members by CREATing INSTANCE OF CLASS DIRECTLY IN THE MAIN BODY OF ANY CLASS
//Indirectly using method it can be done
public class a
{
    public int num { get; set; }
    public int im = 9;
}
public class b:a
{
    a obj = new a(); 
   // obj.im=10;   //NOT ALLOWED TO access members by CREATing INSTANCE OF CLASS DIRECTLY IN THE MAIN BODY OF ANY CLASS

    public void justMethod()
    {
        a obj = new a();
        obj.im=10;  //INSIDE METHOD IT CAN BE DONE
    }
}
#endregion*/




/*#region INDEXERS (parameter type of indexer = int)


class Employee
{
    int Eno;
    string Ename, Job;
    double Salary;

    public Employee(int Eno, string Ename, String Job, double Salary)
    {
        this.Eno = Eno;
        this.Ename = Ename;
        this.Job = Job;
        this.Salary = Salary;
    }
    public object this[int index]      // <modifier> <type> this[<parameter list>]
    {
        get
        {
            if (index == 0)
            {
                return Eno;
            }
            else if (index == 1)
            {
                return Ename;
            }
            else if (index == 2)
            {
                return Job;
            }
            else if (index == 3)
            {
                return Salary;
            }
            else
            {
                return null;
            }
        }
        set
        {
            if (index == 0)
            {
                Eno = (int)value; //value is of type object...so we need to convert it to the required data type
            }
            else if (index == 1)
            {
                Ename = (string)value; //UNBOXING
            }
            else if (index == 2)
            {
                Job = (string)value;
            }
            else if (index == 3)
            {
                Salary = (double)(int)value;
            }
        }

    }
}
class TestClass
{
    public static void Main()
    {
        Employee e = new Employee(01, "Roshan Sharma", "Software Engineer", 57000.00);
        Console.WriteLine("Eno: " + e[0]);
        Console.WriteLine("Ename: " + e[1]);
        Console.WriteLine("Job: " + e[2]);
        Console.WriteLine("Salary: " + e[3]);
        Console.WriteLine();

        Console.WriteLine("|||||||AFTER PROMOTION|||||||\n");

        e[1] = "Dr. Roshan Sharma";
        e[2] = "HR Head";
        e[3] = 1800000;
        Console.WriteLine("Eno: " + e[0]);
        Console.WriteLine("Ename: " + e[1]);
        Console.WriteLine("Job: " + e[2]);
        Console.WriteLine("Salary: " + e[3]);


    }
}

#endregion*/



/*#region INDEXERS (parameter type of indexer = string)


class Employee
{
    int Eno;
    string Ename, Job;
    double Salary;

    public Employee(int Eno, string Ename, String Job, double Salary)
    {
        this.Eno = Eno;
        this.Ename = Ename;
        this.Job = Job;
        this.Salary = Salary;
    }
    public object this[String place]
    {
        get
        {
            if (place.ToLower() =="eno")
            {
                return Eno;
            }
            else if (place.ToLower() == "ename")
            {
                return Ename;
            }
            else if (place.ToLower() == "job")
            {
                return Job;
            }
            else if (place.ToLower() == "salary")
            {
                return Salary;
            }
            else
            {
                return null;
            }
        }
        set
        {
            if (place.ToLower() == "eno")
            {
                Eno = (int)value; //value is of type object...so we need to convert it to the required data type
            }
            else if (place.ToLower() == "ename")
            {
                Ename = (string)value;
            }
            else if (place.ToLower() == "job")
            {
                Job = (string)value;
            }
            else if (place.ToLower() == "salary")
            {
                Salary = (double)value;
            }
        }

    }
}
class TestClass
{
    public static void Main()
    {
        Employee e = new Employee(01, "Roshan Sharma", "Software Engineer", 57000.00);
        Console.WriteLine("Eno: " + e["eno"]);
        Console.WriteLine("Ename: " + e["eNAME"]);
        Console.WriteLine("Job: " + e["job"]);
        Console.WriteLine("Salary: " + e["sALary"]);
        Console.WriteLine();

        Console.WriteLine("AFTER PROMOTION");

        e["ename"] = "Dr. Roshan Sharma";
        e["job"] = "HR Head";
        e["salary"] = 1800000.00;
        Console.WriteLine("Eno: " + e["eno"]);
        Console.WriteLine("Ename: " + e["eNAME"]);
        Console.WriteLine("Job: " + e["job"]);
        Console.WriteLine("Salary: " + e["sALary"]);

        Console.WriteLine();


    }
}

#endregion*/




/*#region INDEXERS (used for playing with array present inside the class
class classA
{
    public static int n;
    int[] arr = new int[n];
    public int this[int index]
    {
        get
        {
            return arr[index];
        }
        set
        {
            arr[index] = value;
        }
    }
}
class classB
{
    public static void Main()
    {
        Console.WriteLine("WHAT IS THE SIzE OF THE ARRAY ?");
        int size=Convert.ToInt32(Console.ReadLine());
        classA.n = size;

        classA A1 = new classA();
        for(int i = 0; i < size; i++)
        {
            Console.Write("Enter element at index-{0} : ",i);
            A1[i]=Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\n|||||Printing your array elelments|||||");
        for (int i = 0; i < size; i++)
        {
            //Console.Write("Element at index-{0} : {1}\n",i, A1[i]);
            Console.Write("{0} ",A1[i]);
        }

    }
}
#endregion*/




/*#region DELEGATES

namespace SpaceDelegate
{

    //Definig a Delegate
    public delegate void AddDelegate(int x, int y);
    public delegate string PrintDelegate(String str);

    class Program
    {

        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static string Print(String str)
        {
            return str;
        }
    }
    class Tester
    {
        public static void Main()
        {
            Program pr = new Program();

            //HOW WE USE TO CALL METHODS TILL NOW
            //pr.Add(5, 7);
            //Console.WriteLine("Hello... " + Program.Print("Rajib"));

            //Creating Instance of Delegate and calling the method using it
            AddDelegate ad = new AddDelegate(pr.Add); // OR //AddDelegate ad = pr.Add;

            ad(5, 7);
            //OR
            ad.Invoke(5, 7);

            PrintDelegate pd = new PrintDelegate(Program.Print);
            Console.WriteLine("Hello... " + pd("Rajib"));
            //OR
            Console.WriteLine("Hello... " + pd.Invoke("Rajib"));

        }
    }
}

#endregion*/




/*#region MULTICAST DELEAGTES (methods return void type)

class MulticastDelegates
{
    public delegate void DelegatePrint(String name);
    public void printHello(String name1)
    {
        Console.WriteLine("Hello.."+name1);
    }
    public void printBye(String name2)
    {
        Console.WriteLine("Bye Bye.." + name2);
        Console.WriteLine();
    }
    public static void Main()
    {
        MulticastDelegates md=new MulticastDelegates();

        //Normal calling of method using class instance
        md.printHello("Rajib");
        md.printBye("Rajib");

        DelegatePrint dp = new DelegatePrint(md.printHello); //OR //DelegatePrint dp =md.printHello; 
        
        dp("SachinRam");
        Console.WriteLine();    

        //Multicasting (dp will now be referring to two methods dp--->printHelo & printBye)
        dp=dp + new DelegatePrint(md.printBye);// OR // dp = dp + md.printBye;
        dp("Vanshika");
    }
}

#endregion*/




/*#region MULTICASTDELEGATEs where methods returns value
class MulticastDelegates2
{
    public delegate double DelegateAddMul(double x, double y);
    public double Add(double a, double b)
    {
        Console.WriteLine("Add function Successfully called");
        return a + b;
    }
    public double Mul(double a, double b)
    {
        Console.WriteLine("Mul function Successfully called");
        return a * b;
    }
    public static void Main()
    {
        MulticastDelegates2 md2 = new MulticastDelegates2();

        DelegateAddMul dam = new DelegateAddMul(md2.Add);
        dam += md2.Mul;  //OR
                         //dam += new DelegateAddMul(md2.Mul);
        double res = dam(5.0, 6.0); //dam is returning two double values from functions Add and Mul
                                    //but only value returned by Mul is stored in the res and Mul was
                                    //referenced at the end
        Console.WriteLine(res);
        Console.WriteLine();
    }
}
#endregion*/




/*#region EVENTS

namespace EventDemo
{
    class EmployeeSeparator
    {
        //DELEGATE
        public delegate void EmployeeSeparatedEventHandler();
        //EVENT
        public event EmployeeSeparatedEventHandler EmployeeSeparated;
        public void Separate()
        {
            //SOME CODE

            //EmployeeSeparated?.Invoke();
            //OR
            if(EmployeeSeparated != null)
            {
                EmployeeSeparated();  //Publishing an event
            }
        }
    }
    class Program
    {
        static void  Main(string [] args)
        {
            EmployeeSeparator employeeSeparator=new EmployeeSeparator();
            employeeSeparator.Separate();
            Console.ReadKey();  
        }
    }
}

#endregion*/




/*#region ANONYMOUS METHODS

//namespace Calling_Method_Using_Delegate
//{
//    class classDelegate
//    {
//        public delegate String DelegateWish(String name);
//        public static string Wishing(string str)
//        {
//            return "Hello " + str;
//        }
//        public static void Main(String[] args)
//        {
//            DelegateWish obj = new DelegateWish(Wishing);

//            String res = obj.Invoke("RAJIB");  //OR //String res = dw("RAJIB");
//            Console.WriteLine(res);
//            Console.WriteLine();
//        }
//    }
//}





//namespace Calling_Anonymous_Method_Using_Delegate
//{
//    public delegate String DelegateWish(String name);
//    class AnonymousMethod
//    {
//        public static void Main(String[] args)
//        {
//            DelegateWish obj = delegate (String name)      //Anonymous method using delegate
//              {
//                  return "Hello " + name;
//              };

//            String res = obj("RAJIB");   //OR //String res = obj.Invoke("RAJIB");
//            Console.WriteLine(res);
//            Console.WriteLine();
//        }
//    }
//}






//Passing Anonymous method to another method which accepts delegate as a parameter
namespace passing_AnoymousMethod_as_Parameter
{
    public delegate void Show(string x);

    class Raj
    {
        public static void identity(Show obj, string color)
        {
            color = "Black &" + color;
            obj(color);
        }
        public static void Main()
        {
            //Anonymous method passed to another method identity as one of the parameter
            identity(delegate (String color)
                     { Console.WriteLine("The color is {0}", color); }  , "White");
        }
    }
}


#endregion*/




/*#region ArrayList
namespace ArrayListApplication
{
    class ArrayListClass
    {
        public static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            //al.Add(8);
            int i = al.Add(8);      //Add function returns index at which element was added..so you may
                                    //utilise it

            Console.WriteLine("Your element is inserted at index {0} ", i);

            Console.WriteLine("Current count: {0}", al.Count);
            Console.WriteLine("Current capacity: {0}", al.Capacity);


            //Console.WriteLine("\nElements inserted at indexes {0}, {1}, {2}, {3}, {4} ",  al.Add(78),
            //                                                                        al.Add(33),
            //                                                                        al.Add(56),
            //                                                                        al.Add(12),
            //                                                                        al.Add(23));

            Console.WriteLine("\nElements inserted at indexes {0}, {1}  ",
                                                           al.Add(78), al.Add(47));


            Console.WriteLine("Current count: {0}", al.Count);
            Console.WriteLine("Current capacity: {0}", al.Capacity);




            //Clear() Removes all elements from the ArrayList.
            //al.Clear();  
            //Console.WriteLine("\nYour ArrayList After Clear: ");
            //foreach (object x in al)
            //{
            //    Console.Write(x + " ");
            //}


            //Contains(object item) Determines whether an element is in the ArrayList.
            bool a = al.Contains(8);
            Console.WriteLine("\n\nYour ArrayList  contains 8 ? =====> {0}", a.ToString().ToUpper());

            Console.WriteLine("\n\nElements inserted at indexes {0}, {1}, {2}, {3} ",
                                                          al.Add(78), al.Add(783), al.Add(437), al.Add(718));
            Console.WriteLine("Current count: {0}", al.Count);
            Console.WriteLine("Current capacity: {0}\n", al.Capacity);

            al.Sort(); //SORTING
            Console.WriteLine("\nYour ArrayList After Sortting: ");
            foreach (object x in al)
            {
                Console.Write(x + " ");
            }

            //GetRange(int index, int count) returns an ArrayList which represents a subset of the elements in the source ArrayList.
            ArrayList al2 = al.GetRange(0, 1);
            Console.WriteLine("\n\nElements in al2 are: ");
            foreach (object x in al2)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("\nCurrent count in al2: {0}", al2.Count);
            Console.WriteLine("Current capacity in al2: {0}", al2.Capacity);

        }
    }
}

#endregion*/




/*namespace CollectionApplication
{

    class Program
    {

        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();

            Console.WriteLine("Adding some numbers:");
            al.Add(45);
            al.Add(78);
            al.Add(33);
            al.Add(56);
            al.Add(12);
            al.Add(23);
            al.Add(9);

            Console.WriteLine("Capacity: {0} ", al.Capacity);
            Console.WriteLine("Count: {0}", al.Count);

            Console.Write("Content: ");
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.Write("Sorted Content: ");
            al.Sort();
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
*/





/*#region List_Method  Implememtation ASSIGNMENT-1

class ListImplementation
{
    static void Main()
    {
        string[] strA = { "Anuj", "Ankush", "Ram", "Raj", "Sam", "Dan", "Viru" };
        List<string> ListA = new List<string>(strA);

        string[] strB = { "Ram", "Raj", "Sam", "Raju", "Prity", "Sania", "Yash" };
        List<string> ListB = new List<string>(strB);

        //C=A-B
        List<string> ListC = new List<string>();
        ListC = ListA.Except(ListB).ToList();

        //D=(A-B)+(B-A)
        List<string> ListD = new List<string>();
        ListD = (ListA.Except(ListB)).Concat(ListB.Except(ListA)).ToList();

        //E=Common elelments of A & B 
        List<string> ListE = new List<string>();
        ListE = ListA.Intersect(ListB).ToList();

        Console.Write("List A elements  :===>");
        foreach (String s in ListA)
        {
            Console.Write(s + " ");
        }

        Console.Write("\n\nList B elements  :===>");
        foreach (String s in ListB)
        {
            Console.Write(s + " ");
        }

        Console.Write("\n\nAll Elelments present in A which are not present in B i.e (List C= List A-List B)\nList C elements :===>");
        foreach (String s in ListC)
        {
            Console.Write(s + " ");
        }

        Console.Write("\n\nUnique elelments of A & B i.e List D=(List A-List B) + (List B-List A)\nList D elements  :===>");
        foreach (String s in ListD)
        {
            Console.Write(s + " ");
        }

        Console.Write("\n\nCommon elelments of A & B\nList E elements  :===>");
        foreach (String s in ListE)
        {
            Console.Write(s + " ");
        }
    }

}

#endregion*/



