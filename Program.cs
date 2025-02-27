using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            Console.OutputEncoding  = Encoding.UTF8;
            SinhVien sv;
            int choice;
            Console.WriteLine("Hãy nhập 1 nếu bạn là sinh viên ATTT và 2 là sinh viên MMT");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1) sv = new ATTT();
            else sv = new MMT();
            sv.Nhap();
            sv.Xuat();
            Console.ReadKey();
        }
    }
}
