using System;
namespace ConsoleApp3
{
    class MinValue
    {
        public void Invoke(List<int> a)
        {
            Console.WriteLine("Мінімум: " + a.Min());
        }
    }
    class MaxValue
    {
        public void Invoke(List<int> a)
        {
            Console.WriteLine("Максимум: " + a.Max());
        }
    }
    class SortUp
    {
        public void Invoke(List<int> a)
        {
            a.Sort();
        }
    }
    class SortDown
    {
        public void Invoke(List<int> a)
        {
            a.Sort();
            a.Reverse();
        }
    }
    class Increase
    {
        public void Invoke(List<int> a, int n)
        {
            for (int i = 0; i < a.Count; i++)
                a[i] += n;
        }
    }
    class Decrease
    {
        public void Invoke(List<int> a, int n)
        {
            for (int i = 0; i < a.Count; i++)
                a[i] -= n;
        }
    }
    class RemoveNumber
    {
        public void Invoke(List<int> a, int n)
        {
            a.RemoveAll(x => x == n);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int> { 8, 3, 12, 5, 1, 9, 6 };

            Console.WriteLine("Початковий список: " + string.Join(" ", a));

            new MinValue().Invoke(a);
            new MaxValue().Invoke(a);

            new SortUp().Invoke(a);
            Console.WriteLine("За зростанням: " + string.Join(" ", a));

            new SortDown().Invoke(a);
            Console.WriteLine("За спаданням: " + string.Join(" ", a));

            new Increase().Invoke(a, 5);
            Console.WriteLine("Збільшення на 5: " + string.Join(" ", a));

            new Decrease().Invoke(a, 3);
            Console.WriteLine("Зменшення на 3: " + string.Join(" ", a));

            new RemoveNumber().Invoke(a, 6);
            Console.WriteLine("Після видалення 6: " + string.Join(" ", a));
        }
    }
}

