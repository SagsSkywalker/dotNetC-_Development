using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args) {
            Class1 myClass1 = new Class1();
            Class2 myClass2 = new Class2();
            //Class 1 Methods
            //String Comparison
            //Honestly, I don't know what the original intention was, so I'm just comparing if they are equal or not.
            Console.WriteLine(myClass1.StringComparison1("Nvidia", "Nvda"));

            //Biggest Number
            int[] numbList = new int[] { 1, 3, 5, 7, 9 };
            myClass1.VerifyBiggestNumber(numbList);

            //SortList
            List<string> strList = new List<string>() {"Xbox","PlayStation","Nintendo" };
            myClass1.SortList(strList);

            //Count String Length
            myClass1.CountStringLength("ThisIsQuiteTheLongStringIsntIt?");

            //Class 2 Methods
            //String Print First Five
            List<int> intList = new List<int>() {1,2,3,4,5,6,7,8 } ;
            myClass2.PrintFirstFiveValues(intList);

            //Print Smallest
            myClass2.PrintSmallestNumber(new int[] { 1, 3, 5, 7, 9 });

            //Print Dictionary
            myClass2.PrintDictionary();
        }
    }

    class Class1
    {
        public string StringComparison1 (string s1, string s2) {
            if (s1 == s2)
                return "Equal";
            else
                return "Not Equal";
        }
        public void VerifyBiggestNumber(int[] list) {
             System.Console.WriteLine(list.Max());
        }
        public void SortList(List<string> myList) {
            foreach (var item in myList.OrderBy(q => q).ToList()) {
                System.Console.WriteLine(item);
            }
        }
        public int CountStringLength(string str) {
            Console.WriteLine(str.Length.ToString());
            return str.Length;
        }
    }

    class Class2
    {
        public void PrintFirstFiveValues(List<int> myList) {
            for (int i = 0; i < myList.Count; i++) {
                if (i>=5)
                    break;
                Console.WriteLine(myList[i].ToString());
            }
        }
        public void PrintSmallestNumber(int[] arr) {
            System.Console.WriteLine(arr.Min());
        }
        public void PrintDictionary() {
            IDictionary<int, string> dicto = new Dictionary<int, string>();
            dicto.Add(1, "Xbox");
            dicto.Add(2, "PlayStation");
            dicto.Add(3, "Nintendo");
            for (int i = 0; i < dicto.Count; i++) {
                Console.WriteLine(dicto[i+1]);
            }
        }
    }
}
