using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithAray
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleArrays();
            VarArrays();
            ArrayOfObject();
            RectArray();
            Console.ReadLine ();
        }

        static void SimpleArrays()
        {
            Console.WriteLine("=>Funny Array");
            int[] myInt = new int[3];
            string[] Books = new string[100];
            myInt[0] = 100;
            myInt[1] = 200;
            foreach (int i in myInt)
                Console.WriteLine("Элемент массива={0}", i);
            Console.WriteLine();

        }

        static void VarArrays()
        {
            Console.WriteLine("=> Show var Array");
            var a = new[] { 1, 2, 4, 6, 7, 8};
            var b = new[] { 2.3, 4.6, 6.7 };
            var c = new[] { "hello", "sd", "vd", "rt" };
            Console.WriteLine("{0}", a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine();
        }

        static void ArrayOfObject()
        {
            Console.WriteLine("=>Array of object");
            object [] myObject = new object[4];
            myObject [0] = 10;
            myObject[1] = false;
            myObject[2] = new DateTime(2012, 5, 30);
            myObject[3] = "Good array";
            foreach (object obj in myObject)
                Console.WriteLine("Type: {0}, Value: {1}",obj.GetType(), obj);
            Console.WriteLine();

        }

        static void RectArray()
        {
            Console.WriteLine("=>ReactArray");
            int [,] myMatrix = new int [6,6];
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 6; j++)
                    myMatrix[i, j] = i * j;
            for (int i=0;i<6; i++)
            { for (int j=0;j<6; j++)
                    Console.Write(myMatrix [i,j]+ "\t");
                Console.WriteLine();
            }
            Console.WriteLine();


        }

        static void JagedArray()
        {
            int[][] myInt = new int [5] [];

        }
    }

}
