using System;

namespace Job_304747137912939
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] gt = new int[250];
            int min = 0;
            int vtmin = 0;
            Console.Write("Nhap so luong phan tu: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap gia tri cho phan tu thu " + (i + 1) + ": ");
                gt[i] = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    min = gt[0];
                    vtmin = 0;
                }
                else
                {
                    if (min > gt[i])
                    {
                        min = gt[i];
                        vtmin = i;
                    }
                }
            }
            Console.WriteLine("Gia tri nho nhat là: " + min + ", vi tri la: " + (vtmin + 1));
        }
    }
}
