//using System;

//class AssignQ03
//{
//    // Generic method CompareItems with a constraint that T must implement IComparable<T>
//    public static bool CompareItems<T>(T item1, T item2) where T : IComparable<T>
//    {
//        // Use CompareTo method from IComparable interface to compare the two items
//        return item1.CompareTo(item2) == 0;
//    }

//    static void Main(string[] args)
//    {
//        // Test CompareItems with integers
//        int a = 5, b = 5;
//        Console.WriteLine($"Are the integers {a} and {b} equal? {CompareItems(a, b)}");

//        // Test CompareItems with strings
//        string str1 = "hello", str2 = "hello";
//        Console.WriteLine($"Are the strings '{str1}' and '{str2}' equal? {CompareItems(str1, str2)}");

//        // Test CompareItems with floating point numbers
//        float f1 = 10.5f, f2 = 10.5f;
//        Console.WriteLine($"Are the floats {f1} and {f2} equal? {CompareItems(f1, f2)}");

//        // Test CompareItems with unequal values
//        int x = 10, y = 20;
//        Console.WriteLine($"Are the integers {x} and {y} equal? {CompareItems(x, y)}");
//        Console.ReadLine();
//    }

//}
