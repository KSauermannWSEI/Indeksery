using System;
using System.Collections.Generic;

namespace IndexersClasses
{
    public class Years
    {
        private Dictionary<string, int> years;
        public int Count => years.Count;
        public Years()
        {
            years = new Dictionary<string, int>();
        }

        public int this[string index]
        {
            get
            {
                if (!years.ContainsKey(index))
                    throw new IndexOutOfRangeException("Index nie istnieje");
                return years[index];
            }
            set
            {
                if (!years.ContainsKey(index))
                    years.Add(index, value);
                else
                    years[index] = value;
            }
        }
    }
}
