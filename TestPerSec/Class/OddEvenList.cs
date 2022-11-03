using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestPerSec.Class
{
    public class OddEvenList
    {
        private static List<string> ListStore = new List<string>();
        public static int add<T>(T input)
        {
            ListStore.Add(input.ToString());

            return ListStore.IndexOf(input.ToString());
        }

        public static bool remove(int index)
        {
            try
            {
                ListStore.RemoveAt(index);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Array getOdd<T>()
        {
            List<T> listanswer = new List<T>();
            int leg = ListStore.ToArray().Length;
            var value = ListStore.ToArray();
            for (int i = 0; i < leg; i++)
            {
                if (i % 2 != 0)
                {
                    listanswer.Add((T)Convert.ChangeType(value[i], typeof(T)));
                }
            }
            return listanswer.ToArray();
        }

        public static Array getEven<T>()
        {
            List<T> listanswer = new List<T>();
            int leg = ListStore.ToArray().Length;
            var value = ListStore.ToArray();
            for (int i = 0; i < leg; i++)
            {
                if (i % 2 == 0)
                {
                    listanswer.Add((T)Convert.ChangeType(value[i], typeof(T)));
                }
            }
            return listanswer.ToArray();
        }

        public static Array getRandom<T>()
        {
            List<T> listanswer = new List<T>();
            List<int> listindexuse = new List<int>();
            int leg = ListStore.ToArray().Length;
            var value = ListStore.ToArray();
            Random ran = new Random();
            for (int i = 0; i < leg; i++)
            {
                int rannum = 0;
                do
                {
                    rannum = ran.Next(leg);

                } while (listindexuse.Contains(rannum) == true);
                listindexuse.Add(rannum);
                listanswer.Add((T)Convert.ChangeType(value[rannum], typeof(T)));
            }
            return listanswer.ToArray();
        }
    }
}