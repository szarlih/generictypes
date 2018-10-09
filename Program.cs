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

            ListMagician<string> tList = new ListMagician<string>();
            for (int i = 1; i <= 5; i++)
            {
                tList.Add(i.ToString());
            }
            Console.WriteLine(tList);

          //  tList.Sum<string>();

            sList.Swap(1.1, 3.1);

            Console.WriteLine(sList);

            Console.WriteLine(sList.Sum<double>());

            Console.ReadLine();
        }
    }
}
