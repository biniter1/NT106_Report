using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN
{
    public class SinhVien
    {
        public string Name {get ;set ;}
        public string Mssv {get ;set ;}
        public string MaKhoa { get ;set ;}
        public double DiemA { get; set; }
        public double DiemB { get; set; }
        public double DiemC { get; set; }

        public virtual void Nhap()
        {
            Name=Console.ReadLine();
            Mssv=Console.ReadLine();
            MaKhoa=Console.ReadLine();
            DiemA=double.Parse(Console.ReadLine());
            DiemB=double.Parse(Console.ReadLine());
            DiemC=double.Parse(Console.ReadLine());
        }
        
        public virtual void Xuat() 
        { 
            Console.WriteLine(Name+" "+Mssv+" "+MaKhoa+" ");
        }
    }
    class ATTT : SinhVien
    {
        public override void Nhap()
        {
            base.Nhap();
        }
        public override void Xuat()
        {
            base.Xuat();    
            Console.WriteLine((DiemA*2+DiemB+DiemC)/4);
        }
    }
    class MMT : SinhVien
    {
        public override void Nhap()
        {
            base.Nhap();
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine((DiemA + DiemB + DiemC) / 3);
        }
    }
 }
