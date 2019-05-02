using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests1
{
    public static class Data
    {
        static public object[] DataTest = SetData();
        static object[] SetData()
        {
            int temp = 21;
            object[] DataTest = new object[temp * temp];
            int a = 0;
            for (int i = 0; i < temp; i++)
            {
                for (int j = 0; j < temp; j++)
                {
                    DataTest[a] = new object[] { i, j };
                    a++;
                }
            }
            return DataTest;
        }
    }
}