using System; // Директива using и пространство имен System позволяют не указывать название пространства имен для каждого класса
using System.Collections.Generic;   // Пространство имен System.Collections.Generic содержит интерфейсы и классы, которые определяют универсальные коллекции, позволяющие пользователям создавать строго типизированные коллекции, обеспечивая лучшую безопасность типов и производительность, чем неуниверсальные коллекции со строгим типом 
using System.Linq; //Пространство имен System.Linq содержит классы и интерфейсы, которые поддерживают LINQ (специальные классы коллекций)
using System.Text; //Пространство имен содержит классы, которые представляют кодировки символов ASCII и Unicode; абстрактные базовые классы для преобразования блоков символов в и из блоков байтов
using System.Threading.Tasks; // Пространство имен System.Threading.Tasks предоставляет типы, которые упрощают работу по написанию параллельного и асинхронного кода.


namespace Task_1 //Пространство имен Таск 1
{
    class Sample //класс Sample для опредения, подсчета и выведения простых чисел 
    {
        protected int[] arr; //declaration of the array arr, which will contain values ​​of type int
        protected int n; //declaration of array length n of int type
        int count = 0; //declaration of a variable of type int is used to count the number of primes; value assigns to 0, zeroing the variable

        public Sample(int[] arr, int n) //Class "Sample" constructor with two parameters: array a and array length n with public access modifier, class member is accessible from anywhere in the code
        {
            this.arr = arr; //
            this.n = n; //
        }
        public void PrintCount() //method is used to count the number of primes 
        {
            for (int i = 0; i < n; i++) //цикл для обхода массива длиной n, повторяется для всех элементов массива
            {
                if (Prime(arr[i])) //if condition, if prime function returns true value, then
                {
                    count++; // value of the variable count increases by 1
                }
            }
            Console.WriteLine(count); //output the counted number of primes
        }
        public void PrintS() //method is used to output the array of prime numbers
        {
            for (int i = 0; i < n; i++) //цикл для массива длиной n, повторяется для всех элементов массива
            {
                if (Prime(arr[i])) //if condition, if prime function returns true value, then
                {
                    Console.Write(arr[i] + " "); //output the prime number
                }
            }
            
        }
        bool Prime(int b) //функция для определения простого числа с параметром, в который передается элемент массива
        {
            if (b == 1) return false; //если элемент массива равен единице, то значение функции равно false, следовательно,это не простое число
            for (int i = 2; i <= Math.Sqrt(b); i++) // 
                if (b % i == 0) //если число (элемент массива) делится без остатка на i
                    return false; //то функция возвращает false, следовательно, это не простое число
            return true; //если число (элемент массива) делится с остатком, то возвращает true, следовательно, число простое
        }
    }
    class Program //основной класс программы
    {
        static void Main(string[] args) //функция Main, которая запускается первой, является главной
        {
            int n = int.Parse(Console.ReadLine()); //декларация и считывание переменной n (длины массива), с использованием метода .Parse для конвертации (string в int) в  любого значения в значение определенного типа

            int[] a = new int[n]; //объявление целочисленного массива a
            string[] nums = Console.ReadLine().Split(new char[] { ',', ';', '#', ' ' }); //объявление массива строк nums, также его заполнение с использованием функции Split

            for (int i = 0; i < n; i++) //цикл для заполнения массива а 
            {
                a[i] = int.Parse(nums[i]); //присвоение значения каждого элемента массива а значения разделенных на элементы массива строк nums
            }
            Sample s = new Sample(a, n); //создание объекта s с параметрами: массив и длина массива
            s.PrintCount(); //вызов метод класса для подсчета количества простых чисел
            s.PrintS(); //вызов метод класса для вывода массива простых чисел 
        }

    }
}
