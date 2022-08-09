using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*#region LINQ  Implememtation ASSIGNMENT_2
public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
    public double Salary { get; set; }
}

public class Tester
{
    public static void Fill(List<Employee> lst)
    {
        #region List of Employee details
        lst.Add(new Employee { FirstName = "Rajib", LastName = "Thakur", City = "Kolkata", Salary = 250001 });
        lst.Add(new Employee { FirstName = "Sachin", LastName = "Dixit", City = "Agra", Salary = 150000 });
        lst.Add(new Employee { FirstName = "Ramkrishna", LastName = "Sarkar", City = "Pune", Salary = 500000 });
        lst.Add(new Employee { FirstName = "Vanhsika", LastName = "Garg", City = "Lucknow", Salary = 30000 });
        lst.Add(new Employee { FirstName = "Rajib", LastName = "Thakur", City = "Sikkim", Salary = 120349 });
        lst.Add(new Employee { FirstName = "Vishnu", LastName = "Sharma", City = "Delhi", Salary = 150500 });
        lst.Add(new Employee { FirstName = "Gaurav", LastName = "Yadav", City = "Kanpur", Salary = 150666 });
        lst.Add(new Employee { FirstName = "Aaditya", LastName = "Sarkar", City = "Mumbai", Salary = 10600 });
        lst.Add(new Employee { FirstName = "Gaurav", LastName = "Roy", City = "Bangalore", Salary = 120030 });
        lst.Add(new Employee { FirstName = "Punit", LastName = "Yadav", City = "Shimla", Salary = 602000 });
        lst.Add(new Employee { FirstName = "Raj", LastName = "Kuthiala", City = "Kolkata", Salary = 300050 });
        lst.Add(new Employee { FirstName = "Aadtiya", LastName = "Kuthiala", City = "Shimla", Salary = 65000 });

        lst.Add(new Employee { FirstName = "Vanshika", LastName = "Garg", City = "Aligarh", Salary = 80000 });
        lst.Add(new Employee { FirstName = "Anshul", LastName = "Garg", City = "Aligarh", Salary = 798000 });
        lst.Add(new Employee { FirstName = "Sakshi", LastName = "Garg", City = "Lucknow", Salary = 70000 });
        lst.Add(new Employee { FirstName = "Shivam", LastName = "Gupta", City = "Kanpur", Salary = 72000 });
        lst.Add(new Employee { FirstName = "Ankit", LastName = "Garg", City = "Delhi", Salary = 73000 });
        lst.Add(new Employee { FirstName = "Ankur", LastName = "Goyal", City = "Banglore", Salary = 600200 });
        lst.Add(new Employee { FirstName = "Kartik", LastName = "Gupta", City = "Delhi", Salary = 650300 });
        lst.Add(new Employee { FirstName = "Yash", LastName = "Gupta", City = "Ghaziabad", Salary = 680500 });
        lst.Add(new Employee { FirstName = "Mayank", LastName = "Garg", City = "Hyderabad", Salary = 906000 });
        lst.Add(new Employee { FirstName = "Vaibhav", LastName = "Gupta", City = "Delhi", Salary = 670008 });

        lst.Add(new Employee { FirstName = "Shyam", LastName = "Thakur", City = "Kolkata", Salary = 2500340 });
        lst.Add(new Employee { FirstName = "Sachin", LastName = "Sharma", City = "Mathura", Salary = 340030 });
        lst.Add(new Employee { FirstName = "Ramkrishna", LastName = "Sarkar", City = "Imphal", Salary = 5003300 });
        lst.Add(new Employee { FirstName = "Vijay", LastName = "Garg", City = "Lucknow", Salary = 300030 });
        lst.Add(new Employee { FirstName = "Shivani", LastName = "Thakur", City = "Sikkim", Salary = 120348 });
        lst.Add(new Employee { FirstName = "Vishnu", LastName = "Kohli", City = "Delhi", Salary = 150006 });
        lst.Add(new Employee { FirstName = "Gaurav", LastName = "Yadav", City = "Kanpur", Salary = 1500034 });
        lst.Add(new Employee { FirstName = "Aaditya", LastName = "Avasthi", City = "Mumbai", Salary = 344667 });
        lst.Add(new Employee { FirstName = "Vikram", LastName = "Roy", City = "Hyderabad", Salary = 120500 });
        lst.Add(new Employee { FirstName = "Punit", LastName = "Yadav", City = "Shimla", Salary = 6000204 });
        lst.Add(new Employee { FirstName = "Raj", LastName = "Kuthialaa", City = "Kolkata", Salary = 300002 });
        lst.Add(new Employee { FirstName = "Aadtiya", LastName = "Kuthiala", City = "Shimlaa", Salary = 652000 });

        lst.Add(new Employee { FirstName = "Vikram", LastName = "Garg", City = "Aligarh", Salary = 80200540 });
        lst.Add(new Employee { FirstName = "Shyam", LastName = "Sharma", City = "Mathura", Salary = 342000 });
        lst.Add(new Employee { FirstName = "Sakshi", LastName = "Garg", City = "Imphal", Salary = 1700300 });
        lst.Add(new Employee { FirstName = "Vijay", LastName = "Gupta", City = "Kanpur", Salary = 72060500 });
        lst.Add(new Employee { FirstName = "Shivam", LastName = "Garg", City = "Delhi", Salary = 7300070 });

        lst.Add(new Employee { FirstName = "Ankura", LastName = "Goyal", City = "Banglore", Salary = 60900 });
        lst.Add(new Employee { FirstName = "Kartik", LastName = "Kohli", City = "Delhi", Salary = 65600 });
        lst.Add(new Employee { FirstName = "Yanshika", LastName = "Gupta", City = "Ghaziabad", Salary = 96000 });
        lst.Add(new Employee { FirstName = "Vikram", LastName = "Garg", City = "Hyderabad", Salary = 90700 });
        lst.Add(new Employee { FirstName = "Vaibhav", LastName = "Gupta", City = "Mumbai", Salary = 6700300 });
        lst.Add(new Employee { FirstName = "Rajib", LastName = "Thakur", City = "Kolkata", Salary = 25000 });
        lst.Add(new Employee { FirstName = "RAjib", LastName = "Thakur", City = "Kolkata", Salary = 2000 });
        lst.Add(new Employee { FirstName = "RAjib", LastName = "Sharma", City = "Kolkata", Salary = 250050 });
        lst.Add(new Employee { FirstName = "Anshul", LastName = "Garg", City = "Aligarh", Salary = 788000 });
        lst.Add(new Employee { FirstName = "Anshul", LastName = "Garg", City = "Aligarh", Salary = 7870300 });
        lst.Add(new Employee { FirstName = "Anshul", LastName = "Garg", City = "Aligarh", Salary = 787060 });
        lst.Add(new Employee { FirstName = "Anshul", LastName = "Garg", City = "Aligarh", Salary = 7870080 });

        #endregion
    }

    public static void Main()
    {

        List<Employee> lstEmployees = new List<Employee>();
        Fill(lstEmployees);

        #region QUERIES

        #region from,where,select,ToList() 

        List<Employee> res = (from i in lstEmployees where i.LastName == "Garg" select i).ToList(); //res here is a list of classes
        foreach (Employee emp in res) //emp will be class and res will be a list
        {
            Console.WriteLine("FirstName=>{0},    LastName=>{1},     City=>{2},     Salary=>{3}", emp.FirstName, emp.LastName, emp.City, emp.Salary);
        }

        #endregion

        Console.WriteLine("(1)--------------------------------------------------------------------------------------");


        #region LAMBDA EXPRESSION (OF ABOVE CODE....WOWWW FACTOR)
        List<Employee> res6 = (lstEmployees.Where(x => x.LastName == "Garg")).ToList<Employee>();
        foreach (Employee emp in res6) //emp will be class and res will be a list
        {

            Console.WriteLine("First Name=>{0},    Last Name=>{1},    City=>{2},    Salary=>{3}", emp.FirstName, emp.LastName, emp.City, emp.Salary);
        }
        #endregion

        Console.WriteLine("(2)--------------------------------------------------------------------------------------");

        #region OrderBy AND OrderByDescending

        List<Employee> res3 = lstEmployees.Where(i => i.Salary > 50000 && i.LastName == "Garg").OrderByDescending(i => i.Salary).ToList();
        // List<Employee> res3=lstEmployees.Where(i=>i.Salary>50000 && i.LastName=="Garg").OrderBy(i=>i.Salary).ToList();
        //			 List<Employee> res3 = (from i in lstEmployees
        //                                where i.Salary > 50000 && i.LastName == "Garg"
        //                              orderby i.FirstName,i.City,i.Salary descending //multiple criteria allowed
        //                            select i).ToList();
        foreach (Employee emp in res3)
        {
            Console.WriteLine("{0}     {1}     {2}", emp.FirstName, emp.LastName, emp.Salary);
        }

        #endregion


        Console.WriteLine("(3)--------------------------------------------------------------------------------------");


        #region Contains(), ThenBy, ThenByDescending

        List<Employee> res5 = lstEmployees.Where(i => i.FirstName.Contains("am")).OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ThenBy(x => x.City).ThenByDescending(x => x.Salary).ToList();
        //List<Employee> res5=(from i in lstEmployees where 

        foreach (Employee emp in res5)
        {

            Console.WriteLine("{0}, {1}, {2}, {3}", emp.FirstName, emp.LastName, emp.City, emp.Salary);
        }

        #endregion

        Console.WriteLine("(4)--------------------------------------------------------------------------------------");

        #region TWO PARAMETERS IN Where method....Where(s,i)....i is index
        //PLAYING WITH INDEXES
        //SELECTING EVEN INDEX ELEMENT
        //Where extension method also have second overload that includes index of current element in the collection
        //Qstn:- Print the firstName of all Employees of the classes present at even indexes of the list
        List<Employee> res7 = lstEmployees.Where((s, i) =>
        {
            if (i % 2 == 0) { return true; }
            else { return false; }
        }).OrderBy(s => s.FirstName).ToList();
        foreach (Employee e in res7)
        {
            Console.WriteLine(e.FirstName);
        }
        Console.WriteLine(res7.Count());

        #endregion

        Console.WriteLine("(5)--------------------------------------------------------------------------------------");

        #region OfType<>()

        var res8 = (lstEmployees.OfType<Employee>().Where(x => x.Salary > 80000).OrderByDescending(x => x.Salary)).ToList();
        foreach (var x in res8)
        {
            Console.WriteLine("{0} ", x.Salary);
        }
        #endregion

        Console.WriteLine("\n(6)--------------------------------------------------------------------------------------");

        #region GroupBy & orderBy

        var groupedCities = lstEmployees.OrderBy(x => x.City).GroupBy(x => x.City);
        foreach (var cityGroup in groupedCities)
        {
            Console.WriteLine("\n\nCity---->{0}", cityGroup.Key);
            foreach (Employee emp in cityGroup)
            {
                Console.WriteLine("{0}  {1}", emp.FirstName, emp.LastName);
            }
        }

        #endregion

        Console.WriteLine("\n(7)--------------------------------------------------------------------------------------");

        #region ToLookup & orderBy //Similar to above GroupBy

        var lookedUpCities = lstEmployees.OrderBy(x => x.City).ToLookup(x => x.City);
        foreach (var cityGroup in lookedUpCities)
        {
            Console.WriteLine("\n\nCity---->{0}", cityGroup.Key);
            foreach (Employee emp in cityGroup)
            {
                Console.WriteLine("{0}  {1}", emp.FirstName, emp.LastName);
            }
        }

        #endregion

        Console.WriteLine("\n(8)--------------------------------------------------------------------------------------");


        #region *****SELECT***** extension method returning a new collection of anonymous type containing the FirstName and Salary property within it

        var res9 = lstEmployees.Select(x => new { Name = "Mr./Mrs." + x.FirstName + " " + x.LastName, City = x.City });

        foreach (var i in res9)
        {
            Console.WriteLine("Name:{0},  City:{1}", i.Name, i.City);
        }

        #endregion

        Console.WriteLine("\n(9)--------------------------------------------------------------------------------------");


        #region All	....Checks if all the elements in a sequence satisfies the specified condition

        bool res10 = lstEmployees.All(x => x.Salary > 80000 && x.Salary < 1000000);
        Console.WriteLine("Do all employees salary lies between 80000 to 1000000 ? ----------->{0}", res10.ToString().ToUpper());

        #endregion

        Console.WriteLine("\n(10)--------------------------------------------------------------------------------------");

        #region Any	...Checks if any of the elements in a sequence satisfies the specified condition

        bool res11 = lstEmployees.Any(x => x.Salary > 80000 && x.Salary < 1000000);
        int res12 = lstEmployees.Where(x => x.Salary > 80000 && x.Salary < 1000000).Count();
        Console.WriteLine("Do any employees salary lies between 80000 to 100000 ? ----------->{0}", res11.ToString().ToUpper());
        Console.WriteLine("How many ? --------->{0}", res12);

        #endregion

        Console.WriteLine("\n(11)--------------------------------------------------------------------------------------");

        #region Average, Count, Max, Sum
        double res13 = lstEmployees.Average(x => x.Salary);
        Console.WriteLine("Average of employees Salary = {0}", res13);

        int res14 = lstEmployees.Count();
        Console.WriteLine("Total Number(Count) of employees = {0}", lstEmployees.Count());

        double res15 = lstEmployees.Max(x => x.Salary);
        Console.WriteLine("Maximum of any employees Salary = {0}", res15);

        double res18 = lstEmployees.Sum(x => x.Salary);
        Console.WriteLine("Sum of all employees Salary = {0}", res18);

        //Sum of all employees salary whose salary is even
        double res16 = lstEmployees.Sum(x =>
        {
            if (x.Salary % 2 == 0)
                return x.Salary;

            return 0;
        });
        Console.WriteLine("Sum of salary of employees of even Salary = {0}", res16);

        //Sum of all employees salary whose salary is odd
        double res17 = lstEmployees.Sum(x =>
        {
            if (x.Salary % 2 == 0)
                return 0;

            return x.Salary;
        });
        Console.WriteLine("Sum of salary of employees of odd Salary = {0}", res17);

        Console.WriteLine("22961584 + 310032 = {0}", 22961584 + 310032);

        //All even index employees salary sum
        var res19 = lstEmployees.Where((s, i) =>
        {
            if (i % 2 == 0) { return true; }
            else { return false; }
        }).Sum(x => x.Salary);
        Console.WriteLine("Salary of employees at even indexes : {0}", res19);

        //All odd index employees salary sum
        var res20 = lstEmployees.Where((s, i) =>
        {
            if (i % 2 != 0) { return true; }
            else { return false; }
        }).Sum(x => x.Salary);
        Console.WriteLine("Salary of employees at odd  indexes : {0}", res20);

        Console.WriteLine("12290272 + 10981344 = {0}", 12290272 + 10981344);
        #endregion

        Console.WriteLine("\n(12)--------------------------------------------------------------------------------------");

        #region ElementAt() and ElementAtOrDefault()
        //ElementAt() Returns the element at a specified index in a collection.
        //ElementAtOrDefault() Returns the element at a specified index in a collection or a default value if the index is out of range.

        Employee res21 = lstEmployees.ElementAt(0);
        Console.WriteLine(res21.FirstName);

        //Employee res22=lstEmployees.ElementAt(110);  //Index was out of range run time error
        //Console.WriteLine(res21.FirstName);

        var res23 = lstEmployees.ElementAtOrDefault(110); // returns default value null
        Console.WriteLine(res23);


        #endregion

        Console.WriteLine("\n(13)--------------------------------------------------------------------------------------");

        #region First() and FirstOrDefault()

        //First()  Returns the first element of a collection, or the first element that satisfies a condition.
        //FirstOrDefault()  Returns the first element of a collection, or the first element that satisfies a condition. Returns a default value if index is out of range.

        Employee res24 = lstEmployees.First();
        Console.WriteLine(res24.FirstName);

        Employee res25 = lstEmployees.FirstOrDefault();
        Console.WriteLine(res25.FirstName);

        //Print details of first employee whose FirstName starts is "Aaditya"
        Employee res26 = lstEmployees.First(x => x.FirstName == "Aaditya");
        Console.WriteLine(res26.FirstName + " " + res26.LastName + " " + res26.City + " " + res26.Salary);

        //Print details of first employee whose FirstName starts is "Raju"
        //Employee res27=lstEmployees.First(x=>x.FirstName=="Raju");      //------->>>Run-time exception : Sequence contains no matching element
        //Console.WriteLine(res27.FirstName+" "+ res27.LastName+" "+res27.City+" "+res27.Salary);

        //Print details of first employee whose FirstName starts is "Raju"
        Employee res28 = lstEmployees.FirstOrDefault(x => x.FirstName == "Raju");      //------->>> NO Run-time exception
                                                                                       //Console.WriteLine(res28.FirstName+" "+ res28.LastName+" "+res28.City+" "+res28.Salary);






        #endregion

        Console.WriteLine("\n(14)--------------------------------------------------------------------------------------");

        #region Distinct()

        //Print DISTINCT city nameS of employees with LastName "Garg"
        Console.WriteLine("Prining DISTINCT city names of employees with LastName \"Garg\"");
        var res29 = lstEmployees.Where(x => x.LastName == "Garg").Select(x => x.City).Distinct();
        foreach (String emp in res29)
        {
            Console.WriteLine(emp);
        }

        //List<Employee> res30 = lstEmployees.Where(x => x.LastName == "Garg" && x.Salary > 50000).Distinct().ToList();
        //foreach (Employee emp in res30)
        //{
        //	Console.Write(emp.FirstName);
        //}

        #endregion


        Console.WriteLine("\n(15)--------------------------------------------------------------------------------------");


        #region Skip() 

        //Skip()--->Skips elements up to a specified position starting from the first element in a sequence.

        //skips first 43 eployees
        List<Employee> res31 = lstEmployees.Skip(43).ToList();
        foreach (Employee emp in res31)
        {
            Console.WriteLine(emp.FirstName);
        }

        #endregion


        Console.WriteLine("\n(16)--------------------------------------------------------------------------------------");


        #region SkipWhile()

        //SkipWhile()--->Skips elements based on a condition until an element does not satisfy the condition.
        //If the first element itself doesn't satisfy the condition, it then skips 0 elements
        //and returns all the elements in the sequence.

        //skips all eployees with salary>25000 till it finds employee with salary<=25000...& then selects the rest employees
        List<Employee> res32 = lstEmployees.SkipWhile(x => x.Salary > 25000).ToList();
        foreach (Employee emp in res32)
        {
            Console.WriteLine(emp.Salary);
        }

        #endregion


        Console.WriteLine("\n(17)--------------------------------------------------------------------------------------");

        #region Take()

        //Take()--->Takes elements up to a specified position starting from the first element in a sequence.
        //Takes first 10 eployees
        List<Employee> res33 = lstEmployees.Take(10).ToList();
        foreach (Employee emp in res33)
        {
            Console.WriteLine(emp.FirstName);
        }

        #endregion

        Console.WriteLine("\n(18)--------------------------------------------------------------------------------------");

        #region TakeWhile()

        //TakeWhile	Returns elements from the first element until an element does not satisfy the condition.
        //If the first element itself doesn't satisfy the condition then returns an empty collection.

        //Takes all employees from first index till condition fails i.e when salary<25000
        List<Employee> res34 = lstEmployees.TakeWhile(x => x.Salary > 25000).ToList();
        foreach (Employee emp in res34)
        {
            Console.WriteLine("{0} {1}", emp.FirstName, emp.Salary);
        }

        #endregion

        Console.WriteLine("\n(19)--------------------------------------------------------------------------------------");


        #region ToDictionary()


        Dictionary<double, string> dict = lstEmployees.ToDictionary(x => x.Salary, x => x.FirstName);
        foreach (KeyValuePair<double, string> kvp in dict)
        {
            Console.WriteLine("Key:{0}   Value:{1}", kvp.Key, kvp.Value);
        }


        #endregion


        Console.WriteLine("\n(20)--------------------------------------------------------------------------------------");


        #region Dictionary using Select,Distinct

        //Create Dictionary where "City" is key which should be unique
        //Each key holds the value which is List of Employees with the same city name as the key
        Dictionary<string, List<Employee>> re35 = lstEmployees.Select(x => new { x.City }).Distinct().ToDictionary(x => x.City, x => lstEmployees.Where(s => s.City == x.City).ToList());
        foreach (var kvp in re35)
        {
            Console.WriteLine("||||||" + kvp.Key + "||||||");
            foreach (Employee emp in kvp.Value)
            {
                Console.WriteLine("{0} {1}", emp.FirstName, emp.City);
            }
            Console.WriteLine();
        }

        #endregion


        Console.WriteLine("\n(21)--------------------------------------------------------------------------------------");


        #region Dictionary using GroupBy

        Dictionary<string, List<Employee>> res36 = lstEmployees.GroupBy(x => x.City).ToDictionary(x => x.Key, x => x.ToList());

        foreach (KeyValuePair<string, List<Employee>> kvp in res36)
        {
            Console.WriteLine("||||||" + kvp.Key + "||||||");
            foreach (Employee emp in kvp.Value)
            {
                Console.WriteLine("{0} {1}", emp.FirstName, emp.City);
            }
            Console.WriteLine();
        }
        #endregion


        Console.WriteLine("\n(22)--------------------------------------------------------------------------------------");

        #region above code using GroupBy only and no Dictionary

        var res37 = lstEmployees.GroupBy(x => x.City);
        foreach (var kvp in res37)
        {
            Console.WriteLine("||||||" + kvp.Key + "||||||");
            foreach (Employee emp in kvp)
            {
                Console.WriteLine("{0} {1}", emp.FirstName, emp.City);
            }
            Console.WriteLine();
        }

        #endregion

        Console.WriteLine("\n(23)--------------------------------------------------------------------------------------");

        #region group, Distinct(), COUNT()

        var res4 = (from i in lstEmployees
                    group i by i.City into cityGroup
                    where cityGroup.Distinct().Count() > 0
                    //orderby cityGroup.Count()
                    select cityGroup);
        Console.WriteLine(res4);

        #endregion

        Console.ReadLine();

        #endregion

    }
}

#endregion*/