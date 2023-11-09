using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_HomeWork_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st=new Student();
            st.Grades = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            foreach (var item in st.Grades)
            {
                Console.WriteLine(item);
            }
        }
    }
}
