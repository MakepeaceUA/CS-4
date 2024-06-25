using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp7
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //Задание 1
        //Random rand = new Random();
        //int[,] arr = new int[5, 4];
        //for (int i = 0; i < arr.GetLength(0); i++)
        //{
        //    for (int j = 0; j < arr.GetLength(1); j++)
        //    {
        //        arr[i, j] = rand.Next(0, 100); 
        //        Console.Write(arr[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}

        //int Max = arr[0, 0];
        //int Min = arr[0, 0];

        //for (int i = 0; i < arr.GetLength(0); i++)
        //{
        //    for (int j = 0; j < arr.GetLength(1); j++)
        //    {
        //        Max = Math.Min(Max, arr[i, j]);
        //        Min = Math.Max(Min, arr[i, j]);
        //    }
        //}
        //Console.WriteLine("\nМаксимальное значение: " + Max);
        //Console.WriteLine("Минимальное значение: " + Min);

        //for (int i = 0; i < arr.GetLength(0); i++)
        //{
        //    int MaxStr = arr[i, 0];
        //    int MinStr = arr[i, 0];

        //    for (int j = 0; j < arr.GetLength(1); j++)
        //    {
        //        MaxStr = Math.Min(MaxStr, arr[i, j]);
        //        MinStr = Math.Max(MinStr, arr[i, j]);
        //    }
        //    Console.WriteLine("\nСтрока " + (i + 1) + ":");
        //    Console.WriteLine("Максимальное значение: " + MaxStr);
        //    Console.WriteLine("Минимальное значение: " + MinStr);
        //}


        //Задание 2
        //Console.Write("Введите строку: ");
        //string str = Console.ReadLine();

        //char[] ch = str.ToCharArray();
        //for (int i = 0; i < ch.Length; i++)
        //{
        //    if (char.IsLower(ch[i]))
        //    {
        //        ch[i] = char.ToUpper(ch[i]);
        //    }
        //    else if (char.IsUpper(ch[i]))
        //    {
        //        ch[i] = char.ToLower(ch[i]);
        //    }
        //}
        //string NewStr = new string(ch);
        //Console.WriteLine(NewStr);


        //Задание 3
        //Console.WriteLine("Введите строку из нескольких слов:");
        //string str = Console.ReadLine();
        //string[] words = str.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        //for (int i = 0; i < words.Length; i++)
        //{
        //    Console.WriteLine(words[i]);
        //}


        //Задание 4
        //string str = "Ваш текст здесь";
        //char[] ch = str.ToCharArray();

        //bool found = false;
        //int count = 1;

        //for (int i = 1; i < ch.Length; i++)
        //{
        //    if (ch[i] == ch[i - 1])
        //    {
        //        count++;
        //        if (count == 5)
        //        {
        //            found = true;
        //            break;
        //        }
        //    }
        //}
        //if (found)
        //{
        //    Console.WriteLine("В тексте есть пять идущих подряд одинаковых символов.");
        //}
        //else
        //{
        //    Console.WriteLine("В тексте нет пяти идущих подряд одинаковых символов.");
        //}


        //Задание 5 и 6
        //struct Client
        //{
        //    public int ClientCode;
        //    public string FullName;
        //    public string Address;
        //    public string Phone;
        //    public int OrderCount;
        //    public int OrderAmount;

        //    public Client(int cc, string fn, string a, string p, int oc, int ta)
        //    {
        //        ClientCode = cc;
        //        FullName = fn;
        //        Address = a;
        //        Phone = p;
        //        OrderCount = oc;
        //        OrderAmount = ta;
        //    }

        //    public void Print()
        //    {
        //        Console.WriteLine($"Код клиента: {ClientCode}, ФИО: {FullName}, Адрес: {Address}, Телефон: {Phone}, Количество заказов: {OrderCount}, Общее кол-во заказов: {OrderAmount}");
        //    }
        //}
        //struct Request
        //{
        //    public int OrderCode;
        //    public string Client;
        //    public string Date;
        //    public string[] OrderedItems;
        //    public int OrderAmount;

        //    public Request(int oc, string c, string od, string[] oi, int oa)
        //    {
        //        OrderCode = oc;
        //        Client = c;
        //        Date = od;
        //        OrderedItems = oi;
        //        OrderAmount = oa;
        //    }

        //    public void Print()
        //    {
        //        Console.WriteLine($"Код заказа: {OrderCode},Клиент: {Client},Дата заказа: {Date},Перечень заказанных товаров: ");
        //        for (int i = 0; i < OrderedItems.Length; i++)
        //        {
        //            Console.WriteLine($"- {OrderedItems[i]}");
        //        }
        //        Console.WriteLine($"Сумма заказа: {OrderAmount}");
        //    }
        //}
        //static void Main()
        //{
        //    Client obj1 = new Client(123, "Имя Фамилия", "Улица", "38000000", 5, 10);
        //    string[] orderedItems = { "Товар 1", "Товар 2", "Товар 3" };
        //    Request obj2 = new Request(123, "Имя Фамилия", "25.06.2024", orderedItems, 10000);

        //    obj1.Print();
        //    obj2.Print();

        //}
        //}
    }
}
