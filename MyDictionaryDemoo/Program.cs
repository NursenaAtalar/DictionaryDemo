using System;

namespace MyDictionaryDemoo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string>myDictionary = new MyDictionary<int, string>();

            myDictionary.Add(1, "Course");
            myDictionary.Add(2, "Teacher");
            myDictionary.Add(3, "Price");

            myDictionary.ListAll();
        }
    }
}
