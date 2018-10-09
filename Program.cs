namespace GenericDemo
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            ListMagician<int> list = new ListMagician<int>();
            for (int i = 1; i <= 5; i++)
            {
                list.Add(i);
            }
            Console.WriteLine(list);

            ListMagician<double> sList = new ListMagician<double>();
            for (int i = 1; i <= 5; i++)
            {
                sList.Add(0.1 + i);
            }
            Console.WriteLine(sList);

            Console.ReadLine();
        }
    }
}
