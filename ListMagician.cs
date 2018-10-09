namespace GenericDemo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class ListMagician<T>
    {
        private List<T> list;
        public ListMagician()
        {
            list = new List<T>();
        }

        public void Add(T input)
        {
            list.Add(input);
        }

        public void Swap(T source, T target)
        {
            int sourceIndex = -1;
            int targetIndex = -1;
            try
            {
                sourceIndex = list.FindIndex(e => e.Equals(source));
                targetIndex = list.FindIndex(e => e.Equals(target));
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("One of selected elements is not existing in the list");
                return;
            }

            list[sourceIndex] = target;
            list[targetIndex] = source;
        }

        public T Sum<T>() where T : struct, IComparable, IConvertible
        {
            if(!list.Any())
            {
                return default(T);
            }

            dynamic sum = default(T);
            foreach (var element in list)
            {
                sum += element;
            }

            return sum;
        }

        public override string ToString()
        {
            if(!list.Any())
            {
                return "Empty";
            }

            StringBuilder listAsString = new StringBuilder();
            list.ForEach(l => listAsString.Append(string.Format("{0} ", l)));

            return listAsString.ToString();
        }
    }
}
