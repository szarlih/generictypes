namespace GenericDemo
{
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
