using System;
using System.Collections.Generic;

namespace Урок8
{
    public class Program
    {
        public static void Main()
        {
            Class<string> str = new Class<string>();
            Class<int> inter = new Class<int>();
            Class<double> doubles = new Class<double>();

            str.add("tom", "text", "college");
            inter.add(5, 10, 20);
            doubles.add(1.35, 0.66, 122.1);
        }
    }
    class Class<T>
    {
        List<T> list = new List<T>();

        public void add(params T[] value)
        {
            foreach (T a in value)
            {
                list.Add(a);
            }
        }

        public void delete(int number)
        {
            list.RemoveAt(number);
        }

        public T search(int number)
        {
            return list[number];
        }

        public int getLenght()
        {
            return list.Count;

        }
    }
}

    
