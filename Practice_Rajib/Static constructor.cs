namespace Static_constructor
{
    internal class Intern
    {
        public int Id;
        public string Name;
        public static string Company;
        public Intern(int id,String name)
        {
            this.Id = id;
            this.Name = name;
        }
        static Intern()
        {
            Company = "SIEMENS ENERGY";
        }

        public void Print()
        {
            Console.WriteLine("InternID :- {0}",Id );
            Console.WriteLine("Name     :- {0}", Name);
            Console.WriteLine("Company  :- {0}", Company);
            Console.WriteLine("\n");
        }

    }
}
