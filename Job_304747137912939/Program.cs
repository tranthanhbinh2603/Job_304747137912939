using System;

namespace Job_304747137912939
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] gt = new int[250];
            int max = 0;
            int vtmax = 0;
            Console.Write("Nhap so luong phan tu: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap gia tri cho phan tu thu " + (i + 1) + ": ");
                gt[i]= int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    max = gt[0];
                    vtmax = 0;
                }
                else
                {
                    if (max < gt[i])
                    {
                        max = gt[i];
                        vtmax = i;
                    }
                }
            }
            Console.WriteLine("Gia tri lon nhat là: " + max + ", vi tri la: " + (vtmax + 1));
        }
    }
}
