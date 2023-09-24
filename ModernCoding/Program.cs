using System;



namespace ModernCodingNS
{
    public class ModernCoding
    {
        public int[] Fun1(int[] a, int[] b)
        {
            int[] c = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
                c[i] = a[i] + b[i];

            return c;
        }

        public double[] Fun2(double[] a, int k)
        {
            if (k > a.Length)
                k %= a.Length;

            double[] b = new double[a.Length];
            int id = 0;

            for (int i = k; i < a.Length; ++i)
                b[id++] = a[i];

            for (int i = 0; i < k; ++i)
                b[id++] = a[i];

            return b;
        }
        //qqqqwe
        //qwe

        //qwe
        //qwe
        public int Fun3(int[] vec, int[] sec)
        {
            int count = 0;
            for (int i = 0; i < vec.Length; i++)
            {
                if (vec[i] == sec[count])
                    count++;
                else
                {
                    i -= count;
                    count = 0;
                }
                if (count == sec.Length)
                    return i - count + 1;
            }
            return -666;
        }

        public static void Main()
        {
            ModernCoding mc = new ModernCoding();
            double[] a = mc.Fun2(new double[] { 0, 1, 2, 3, 4, 5 }, 5);
            if (a[0] == 1)
                Console.WriteLine("YYYYYYYEs");
            foreach (int i in a)
                Console.Write(i);
        }
    }
}



//int n = Convert.ToInt32(Console.ReadLine());

//int[] A = new int[n];
//for (int i = 0; i < A.Length; i++)
//    A[i] = i;

//int[] B = new int[n];
//for (int i = 0; i < B.Length; i++)
//    B[i] = B.Length - i;

//int[] C = Fun(A, B);

//foreach (int i in C)
//    Console.Write(i);
//Console.Write("\n");

//double[] D = new double[n];
//for (int i = 0; i < A.Length; i++)
//    D[i] = i;


//foreach (int i in D)
//    Console.Write(i);
//Console.Write("\n");

//D = Fun2(D, 8);


//foreach (int i in D)
//    Console.Write(i);

//Console.Write("\n");
//Console.Write(Fun3(new int[] { 4, 4, 5, 7, 1, 2 }, new int[] { 1, 2, 3 }));
