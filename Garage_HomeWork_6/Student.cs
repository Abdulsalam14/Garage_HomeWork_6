using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_HomeWork_6
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        private int[] _grades;

        public int[] Grades
        {
            get { return _grades; }
            set
            {
                int count = 0;
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] % 2 == 0)
                    {
                        count++;
                    }
                }
                int[] tempArr=new int[count];
                for (int i = 0, k = 0; i < value.Length; i++)
                {
                    if (value[i] % 2 == 0)
                    {
                        tempArr[k++] = value[i];
                    }
                }
                _grades = tempArr;
            }
        }


    }
}
