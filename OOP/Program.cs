using System;

namespace OOP
{

    #region Prerequisites
    /*
        - Data Types
        - C# Statements
            - Conditional 
                - if
                - switch
            - Loops
                - for
                - while
                - do while
        - Methods (functions)
        - Arrays

        C# topics:
            - Program Structure
                Learn the key organizational concepts in the C# language: programs, namespaces, types, members, and assemblies.

            - Types and Variables
                Learn about value types, reference types, and variables in the C# language.

            - Expressions
                Expressions are constructed from operands and operators. Expressions produce a value.

            - Statements
                You use statements to express the actions of a program.

            - Classes and objects
                Classes are the most fundamental of C#'s types. Objects are instances of a class. Classes are built using members, which are also covered in this topic.

            - Structs
                Structs are data structures that, unlike classes, are value types.

            - Arrays
                An array is a data structure that contains a number of variables that are accessed through computed indices.

            - Interfaces
                An interface defines a contract that can be implemented by classes and structs. An interface can contain methods, properties, events, and indexers. An interface does not provide implementations of the members it defines—it merely specifies the members that must be supplied by classes or structs that implement the interface.

            - Enums
                An enum type is a distinct value type with a set of named constants.

            - Delegates
                A delegate type represents references to methods with a particular parameter list and return type. Delegates make it possible to treat methods as entities that can be assigned to variables and passed as parameters. Delegates are similar to the concept of function pointers found in some other languages, but unlike function pointers, delegates are object-oriented and type-safe.

            - Attributes
                Attributes enable programs to specify additional declarative information about types, members, and other entities.

    */
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Employee emp1 = new Employee();
            emp1.SetName("Nasr");
            emp1.SetDegree(-2);
            emp1.SetSalary(10);
            emp1.OverTime();
            emp1.EmpInfo();

            RefExample.SwapExample();
            OutExample.OutUsage();

            int x= 1, y = 3, z= 4;
            Console.WriteLine("x={0} y={1} z={2}", x, y, z);

            Type widgetType = typeof(Widget);

            //Gets every HelpAttribute defined for the Widget type
            object[] widgetClassAttributes = widgetType.GetCustomAttributes(typeof(HelpAttribute), false);

            if (widgetClassAttributes.Length > 0)
            {
                HelpAttribute attr = (HelpAttribute)widgetClassAttributes[0];
                Console.WriteLine($"Widget class help URL : {attr.Url} - Related topic : {attr.Topic}");
            }

            System.Reflection.MethodInfo displayMethod = widgetType.GetMethod(nameof(Widget.Display));

            //Gets every HelpAttribute defined for the Widget.Display method
            object[] displayMethodAttributes = displayMethod.GetCustomAttributes(typeof(HelpAttribute), false);

            if (displayMethodAttributes.Length > 0)
            {
                HelpAttribute attr = (HelpAttribute)displayMethodAttributes[0];
                Console.WriteLine($"Display method help URL : {attr.Url} - Related topic : {attr.Topic}");
            }
            

            Console.ReadKey();
        }
    }

    class RefExample
    {
        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        public static void SwapExample()
        {
            int i = 1, j = 2;
            Swap(ref i, ref j);
            Console.WriteLine($"{i} {j}");    // Outputs "2 1"
        }
    }

    class OutExample
    {
        static void Divide(int x, int y, out int result, out int remainder)
        {
            result = x / y;
            remainder = x % y;
        }
        public static void OutUsage()
        {
            Divide(10, 3, out int res, out int rem);
            Console.WriteLine("{0} {1}", res, rem);	// Outputs "3 1"
        }
    }

    public class HelpAttribute : Attribute
    {
        string url;
        string topic;
        public HelpAttribute(string url)
        {
            this.url = url;
        }

        public string Url => url;

        public string Topic
        {
            get { return topic; }
            set { topic = value; }
        }
    }

    [Help("https://docs.microsoft.com/dotnet/csharp/tour-of-csharp/attributes")]
    public class Widget
    {
        [Help("https://docs.microsoft.com/dotnet/csharp/tour-of-csharp/attributes",
        Topic = "Display")]
        public void Display(string text) { }
    }
}
