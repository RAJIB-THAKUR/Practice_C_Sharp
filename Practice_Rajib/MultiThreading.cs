using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using System.Threading.Tasks; //NEED TO IMPORT



/*#region MultiThreading
class MultiThreading
{
    public static void Main()
    {
        // Get the thread currently
        // executing this method.
        Thread currThread = Thread.CurrentThread;
        Console.WriteLine("Curently executing thread is: {0}", currThread);

        //You can set some name to this currently executing thread
        currThread.Name = "My Main Method thread";
        Console.WriteLine("Curently executing thread is: {0}", Thread.CurrentThread.Name);
        //OR
        Console.WriteLine("Curently executing thread is: {0}", currThread.Name);
    }
}

#endregion*/





/*#region SingleThreaded
class SingleThreaded
{
    static void Main(string[] args)
    {
        Method1();
        Console.WriteLine("-----------------------");
        Method2();
        Console.WriteLine("-----------------------");
        Method3();
        Console.WriteLine("-----------------------");
        Console.Read();
    }
    static void Method1()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Method1 :" + i);
        }
    }

    static void Method2()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Method2 :" + i);
            if (i == 3)
            {
                Console.WriteLine("Main thread Sleeping");
                //Sleep for 4 seconds
                Thread.Sleep(4000);   //The whole code execution freezes for this time as this process is under single threading
                Console.WriteLine("Main thread Woke up");
            }     
        }
    }
    static void Method3()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Method3 :" + i);
        }
    }
}

#endregion*/





/*#region MultiThreaded

class MultiThreaded
{
    static void Main(string[] args)
    {
        Console.WriteLine("Main Thread Started");

        //Creating Threads
        Thread t1 = new Thread(Method1)
        {
            Name = "Thread-1"
        };
        Thread t2 = new Thread(Method2)
        {
            Name = "Thread-2"
        };
        Thread t3 = new Thread(Method3)
        {
            Name = "Thread-3"
        };

        //Executing the methods
        t1.Start();
        t2.Start();
        t3.Start();
        Console.WriteLine("Main Thread Ended");
        Console.Read();
    }

    static void Method1()
    {
        Console.WriteLine("Method1 Started using " + Thread.CurrentThread.Name);
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Method1 :" + i);
        }
        Console.WriteLine("Method1 Ended using " + Thread.CurrentThread.Name);
    }


    static void Method2()
    {
        Console.WriteLine("Method2 Started using " + Thread.CurrentThread.Name);
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Method2 :" + i);
            if (i == 3)
            {
                Console.WriteLine("Performing the Database Operation Started");
                //Sleep for 5 seconds
                Thread.Sleep(5000);
                Console.WriteLine("Performing the Database Operation Completed");
            }
        }
        Console.WriteLine("Method2 Ended using " + Thread.CurrentThread.Name);
    }

    static void Method3()
    {
        Console.WriteLine("Method3 Started using " + Thread.CurrentThread.Name);
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Method3 :" + i);
        }
        Console.WriteLine("Method3 Ended using " + Thread.CurrentThread.Name);
    }
}

#endregion*/




/*#region without JOIN
class Program
{
    public static void Main()
    {
        //Creating the WorkerThread with the help of Thread class.    
        Thread ThreadObject1 = new Thread(WorkerThread);
        ThreadObject1.Start(); //Starting the Thread    
        //ThreadObject1.Join(); //Using Join to block the current Thread    
        Console.WriteLine("1. MainThread Started");
        for (int i = 0; i <= 3; i++)
        {
            Console.WriteLine("-> MainThread Executing");
            Thread.Sleep(3000); //Here 5000 is 5000 Milli Seconds means 5 Seconds    
        }
        // We are calling the Name of Current running Thread using CurrentThread    
        Thread Th = Thread.CurrentThread;
        Th.Name = "Main Thread";
        Console.WriteLine("\nGetting the Name of Currently running Thread");
        //Name Property is used to get the name of the current Thread    
        Console.WriteLine( "Current Thread Name is: {0}", Th.Name);
        //Priority Property is used to display the Priority of current Thread    
        Console.WriteLine("Current Thread Priority is: {0}", Th.Priority);
    }
    static void WorkerThread()
    {
        Console.WriteLine("2. WorkerThread Started");
        for (int i = 0; i <= 3; i++)
        {
            Console.WriteLine("-> WorkerThread Executing");
            Console.WriteLine("Child Thread Paused");
            //Sleep method is used to pause the Thread for a specific period    
            Thread.Sleep(3000);
            Console.WriteLine("Child Thread Resumed");
        }
    }
}
#endregion*/


/*#region JOIN
//In the thread, synchronization join is a blocking mechanism that helps in pausing the calling thread.
//This continues until the thread execution has finished on which the join is called.
class Program
{
    public static void Main()
    {
        //Creating the WorkerThread with the help of Thread class.    
        Thread ThreadObject1 = new Thread(WorkerThread);
        ThreadObject1.Start(); //Starting the Thread

        ThreadObject1.Join(); //Using Join to block the current Thread

        Console.WriteLine("1. MainThread Started");
        for (int i = 0; i <= 3; i++)
        {
            Console.WriteLine("-> MainThread Executing");
            Thread.Sleep(1000);   
        }
        // We are calling the Name of Current running Thread using CurrentThread    
        Thread Th = Thread.CurrentThread;
        Th.Name = "Main Thread";
        Console.WriteLine("\nGetting the Name of Currently running Thread");
        //Name Property is used to get the name of the current Thread    
        Console.WriteLine("Current Thread Name is: {0}", Th.Name);
        //Priority Property is used to display the Priority of current Thread    
        Console.WriteLine("Current Thread Priority is: {0}", Th.Priority);
    }
    static void WorkerThread()
    {
        Console.WriteLine("2. WorkerThread Started");
        for (int i = 0; i <= 3; i++)
        {
            Console.WriteLine("-> WorkerThread Executing");
            Console.WriteLine("Child Thread Paused");
            //Sleep method is used to pause the Thread for a specific period    
            Thread.Sleep(1000);
            Console.WriteLine("Child Thread Resumed");
        }
    }
}

#endregion*/



/*#region Join and Withput join another example
namespace Threading

{
    public class clsThreading
    {
        public static void area(int a, int b)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Area of Rectangle is {0}", a * b);
                a += 1;
                b += 1;
                Thread.Sleep(1000);
                Console.WriteLine("Value of a and b are {0} and {1}", a, b);
            }
        }
        public static void Main()
        {
            int x, y;
            Console.WriteLine("Enter two values:");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            Thread Th1 = new Thread(() => area(x, y));
            Th1.Start();
            //Th1.Join();
            Console.WriteLine("Another Thread-----");
            Console.WriteLine("Average of Two values is {0}", (int)Math.Round((double)(x + y) / 2), 0);
            Thread.Sleep(3000);
            Thread Th2 = Thread.CurrentThread;

            Th2.Name = "Average";
            Console.WriteLine("Name of current Running Thread is {0}", Th2.Name);
            Console.WriteLine("Priority is {0}", Th2.Priority);
            //Th2.Join();

        }
    }
}
#endregion*/



/*#region LOCK
//The lock helps in Locking the current Thread so that no other thread can interrupt
//the execution. Unlocking happens after the execution finishes.
class classA
{
    public void Display()
    {
        lock(this) 
        {
            Console.WriteLine("Inside Display FUnction");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Printing:{i}");
                Thread.Sleep(1000);
            }
        }
    }
    static void Main()
    {
        classA a = new classA();
        
        Thread t1 = new Thread(a.Display);
        Thread t2 = new Thread(a.Display);
        //Calling one thread after the other ....
        //Thread t2 executes after t1 execution is completed because of lock keyword in Display()
        
        t1.Start();  //Starting Thread1  
        t2.Start();  //Starting Thread2  

    }
}
#endregion*/



/*#region WITHOUT LOCK(above code)
class classA
{
    public void Display()
    {
        //lock (this)
        {
            Console.WriteLine("Inside Display FUnction");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Printing:{i}");
                Thread.Sleep(1000);
            }
        }
    }
    static void Main()
    {
        classA a = new classA();

        Thread t1 = new Thread(a.Display);
        Thread t2 = new Thread(a.Display);
        //Calling one thread after the other ....
        //Thread t2 executes after t1 execution is completed because of lock keyword in Display()

        t1.Start();  //Starting Thread1  
        t2.Start();  //Starting Thread2  

    }
}

#endregion*/


/*#region SyncDelegateReview
namespace SyncDelegateReview
{
    public delegate int BinaryOp(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Synch Delegate Review *****");

            // Print out the ID of the executing thread.
            Console.WriteLine("Main() invoked on thread {0}.",
            Thread.CurrentThread.ManagedThreadId);

            // Invoke Add() in a synchronous manner.
            BinaryOp b = new BinaryOp(Add);
            // Could also write b.Invoke(10, 10);
            int answer = b(10, 10);
            // These lines will not execute until
            // the Add() method has completed.
            Console.WriteLine("Doing more work in Main()!");
            Console.WriteLine("10 + 10 is {0}.", answer);
            Console.ReadLine();
        }
        static int Add(int x, int y)
        {
            // Print out the ID of the executing thread.
            Console.WriteLine("Add() invoked on thread {0}.",
            Thread.CurrentThread.ManagedThreadId);
            // Pause to simulate a lengthy operation.
            Thread.Sleep(5000);
            return x + y;
        }
    }

}
#endregion*/



/*#region Invoking a Method Asynchronously
namespace ASyncDelegateReview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Async Delegate Invocation *****");
            // Print out the ID of the executing thread.
            Console.WriteLine("Main() invoked on thread {0}.",
            Thread.CurrentThread.ManagedThreadId);
            // Invoke Add() on a secondary thread.
            BinaryOp b = new BinaryOp(Add);
            IAsyncResult iftAR = b.BeginInvoke(10, 10, null, null);
            // Do other work on primary thread...
            Console.WriteLine("Doing more work in Main()!");
            // Obtain the result of the Add()
            // method when ready.
            int answer = b.EndInvoke(iftAR);
            Console.WriteLine("10 + 10 is {0}.", answer);
            Console.ReadLine();
        }
    }
}
#endregion*/