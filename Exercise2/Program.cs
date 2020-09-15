using System;
using System.Linq;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            //1. Constructor that will initialize a class variable.
            MyClass clase1 = new MyClass("dino");
            clase1.ImprimirPantalla(clase1.palabra);
            clase1.palabra = "noon";
            clase1.ImprimirPantalla(clase1.palabra);
            clase1.ImprimirPantalla(8);
        }
    }

    class MyClass
    {
        //4. Create a property that returns a string.
        public string palabra { get; set; }

        public MyClass() { }
        //2. Apply constructor overloading.
        public MyClass(string _palabra) => palabra = _palabra;

        //3. Apply method overloading.
        //5. Create a method to verify if a string is a palindrome (Use the created property).
        public void ImprimirPantalla(string pseudopali) {
            //Verificar si es palindromo
            if (pseudopali.SequenceEqual(pseudopali.Reverse()))
                Console.WriteLine("Is palindrome");
            else
                Console.WriteLine("Is not palindrome");
        }
        //3. Apply method overloading.
        //6. Create a method to print numbers in diagonal.
        public void ImprimirPantalla(int numero) {
            //Imprimir en diagonal
            for (int i = 0; i < numero; i++) {
                for (int j = 0; j < i; j++) {
                    Console.Write("\t");
                }
                Console.WriteLine((i+1).ToString());
            }
        }
    }
}
