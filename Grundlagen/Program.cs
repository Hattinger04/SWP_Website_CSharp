// using == import in Java
using System;
using Grundlagen.Models; 
using System.IO; 

// namespace == Package in Java
namespace Grundlagen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Erstes Programm");
            Person p = new Person();

            // Datentypen und Variablen 

            int value;
            double value2; // float
            decimal salary; // immer für Währungsbeträge verwenden!

            String name;
            char choice;
            bool isMale;
            DateTime birthdate;

            // Konstanten
            const double PI = 3.1415;

            // Ausgabe
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Baba");
            Console.WriteLine("PI = {0,20:f4}, {1}", Math.PI, "Georg");

            // Eingabe 
            Console.Write("Ihr Name: ");
            name = Console.ReadLine();
            
            Console.WriteLine("Name: " + name);

            Console.Write("Sind sie männlich [True/False]: ");
            isMale = Convert.ToBoolean(Console.ReadLine());

            // Auswahlanweisungen

            Console.Write("Bitte Ganzzahl angeben: ");
            value = Convert.ToInt32(Console.ReadLine());
            bool x = value > 0 ? true : false;

       
            string result;
            int input;

            Console.WriteLine("Ganzzahl");
            input = Convert.ToInt32(Console.ReadLine());
            result = input >= 0 ? "positiv" : "negativ"; 


            // Schleifen: 
            // for, while, do while, foreach

            for(int j=1; j < 100; j = j+10)
            {
                Console.WriteLine(j); 
            }

            int i = 100; 
            while(i >= 0)
            {
                Console.WriteLine(i);
                i = i - 10; 
            }

            int age;
            
            do
            {
                Console.Write("Alter: ");
                age = Convert.ToInt32(Console.ReadLine()); 
            } while (!(age >= 10 && age <= 100));

            PrintPersonData();

            // Instanzen / Objekte von Person erzeugen
            Person p1 = new Person();
            Person p2 = new Person(100, "Matteo", "Höllrigl", 2090.90m, Department.WI, new DateTime(2004, 2, 25));

            Lehrer l1 = new Lehrer(1, "Simon", "Kuttner", 6);
            Console.WriteLine(l1.ToString());

            // string file = "C://Users//s8gre//Documents//Simon//HTL//4BHWII//SWP//Algorithmen"; 
            // string content = ReadFile(file); 
            // Console.WriteLine(content); 

            IRepository rep = new RepositoryDB();
            rep.Open();
            rep.Insert(p);
            rep.Close(); 

            Console.WriteLine("Unser PI = " + StaticClass.PI);
            Console.WriteLine("String = " + StaticClass.Do());

            NormalClassWithStaticMembers.Value = "300";
            Console.WriteLine(NormalClassWithStaticMembers.Value);
            Console.WriteLine("30$ + 25$ = " + NormalClassWithStaticMembers.Add(30, 25));

            NormalClassWithStaticMembers c1 = new NormalClassWithStaticMembers();
            c1.Text = "Bla";
            Console.WriteLine("Text = " + c1.Text);
            Console.WriteLine("Calculate + " + c1.Calculate());
        }

        // eine Methode sollte nur eine einzige Ausgabe ausführen
        public static void PrintPersonData() { 
            
            Console.WriteLine("Johannes");
            Console.WriteLine("4.8.2004");
            Console.WriteLine("Mayrhofen");
        }

        public static void PrintPersonData(Person p)
        {
            Console.WriteLine("Name: " + p.Name);
            Console.WriteLine("ID: " + p.PersonId);
            Console.WriteLine("Geburtsdatum: " + p.Birthdate.ToLongDateString());
        }
        public static void ReadFile(string pathAndFilename)
        {
            try
            {
                File.ReadAllText(pathAndFilename);

            }
            catch (UnauthorizedAccessException)
            {

            }
        }
    }
}