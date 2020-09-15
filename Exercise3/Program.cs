using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise3
{
    class Program
    {
        
        static void Main(string[] args) {
            List<string> palabras = new List<string>() { "Text", "Computer", "Automation", "Visual Studio", "Auto Parts", " " };
            List<int> numeros = new List<int>() { 1, 1, 2, 3, 4, 4, 5, 6, 7, 8, 10 };
            List<string> palabras2 = new List<string>() { "hola", "adios" };

            Console.WriteLine("Hello World!");

            //Father Functionality
            Father papah = new Father();
            Console.WriteLine(papah.CompareStrings("Papa","Mama"));
            Console.WriteLine(papah.CompareStrings("Papada", "Mama"));
            
            Console.WriteLine(papah.CompareLists(palabras, palabras));
            Console.WriteLine(papah.CompareLists(palabras, palabras2));

            //Son Functionality
            Son hijo = new Son();
            hijo.PrintIfEqualString("Mama", "Papa");
            hijo.PrintIfEqualString("Mama2", "Papa");

            hijo.PrintHelloInterface();

            hijo.PrintListByParameter(palabras, 1);
            hijo.PrintListByParameter(palabras, 2);
            
            hijo.PrintFilteredList(palabras);

            hijo.PrintFilteredNumberList(numeros);
        }
    }
    class Father
    {
        //Method that compares if the lenght of 2 strings are the same
        public bool CompareStrings(string s1, string s2) {
            if (s1.Length == s2.Length)
                return true;
            else
                return false;
        }
        //Method that compares if the size of 2 lists are the same
        public bool CompareLists(List<string> l1, List<string> l2) {
            if (l1.Count == l2.Count)
                return true;
            else
                return false;
        }
    }

    class Son : Father, Family
    {
        //Use functionality from(A) in a new method from(B).
        public void PrintIfEqualString(string s1, string s2) {
            if (CompareStrings(s1, s2))
                Console.WriteLine("The strings are same length.");
            else
                Console.WriteLine("Strings are not same length.");
        }

        public void PrintHelloInterface() {
            Console.WriteLine("Hello Interface.");
        }

        public void PrintListByParameter(List<string> list, int param) {
            if (param==1) {
                foreach (var item in list.OrderBy(i => i)) {
                    Console.WriteLine(item.ToString());
                }
            }
            else if (param == 2) {
                foreach (var item in list.OrderByDescending(i => i)) {
                    Console.WriteLine(item.ToString());
                }
            }
        }

        public void PrintFilteredList(List<string> list) {
            List<string> newList = new List<string>();
            foreach (var item in list) {
                if (item.ToString() == "" || item.ToString() == " ") { }
                //Dont add
                else { newList.Add(item); }
            }
            foreach (var item in newList) {
                Console.WriteLine(item.ToString());
            }
        }

        public void PrintFilteredNumberList(List<int> numList) {
            foreach (var item in numList.Distinct().ToList()) {
                Console.Write(item.ToString() + " ");
            }
        }
    }

    interface Family
    {
        void PrintHelloInterface();
    }
}
