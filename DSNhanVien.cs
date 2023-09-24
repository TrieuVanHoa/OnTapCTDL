using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapNguyenHuynhDongTrieu22dh113859
{
    internal class DSNhanVien
    {
        NhanVien[] mangNV;
        int n;

        public int N { get => n; set => n = (value>0&&value<=10000000?value:0); }

        internal NhanVien[] MangNV { get => mangNV; set => mangNV = value; }

        public void NhapDS()
        {
            do
            {
                Console.Write("Nhap so luong sinh vien: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 0 || n > 100000000);
            mangNV = new NhanVien[n];
            for(int i = 0;i<n;i++)
            {
                Console.Write("Nhap thong tin nhan vien thu:{0}",i);
                mangNV[i] = new NhanVien();
                mangNV[i].Nhap();
                if (KiemTraNVNhap(mangNV[i].MaSo,i))
                {
                    do
                    {
                        Console.WriteLine("Nhap trung ma nhan vien. Nhap Lai ma khac");
                        mangNV[i].MaSo = int.Parse(Console.ReadLine());
                    } while (KiemTraNVNhap(mangNV[i].MaSo, i));
                }
            }
        }
        public void XuatDS()
        {
            for(int i = 0;i<n;i++)
            {
                Console.WriteLine("NV[{0}]", i);
                mangNV[i].Xuat();
            }
        }
        public bool KiemTraNVNhap(int maNV,int viTri)
        {
            for (int i = 0; i < viTri; i++)
            {
                if (mangNV[i].MaSo == maNV)
                    return false;
            }
            return false;

        }
        public int TimKiemNV(NhanVien nv)
        {
            for(int i=0;i<n;i++)
            {
                if (mangNV[i].MaSo==nv.MaSo)
                {
                    return i;
                }
            }
            return -1;
        }
        public void SapXepTheoTen()
        {
            for(int i=0;i<n;i++)
            { 
                for(int j=1+i;j<n;j++)
                {
                    if (mangNV[i].HoTen.CompareTo(mangNV[j].HoTen)==1)
                    {
                        NhanVien tam = mangNV[i];
                        mangNV[i] = mangNV[j];
                        mangNV[j]=tam;
                    }
                }
            }
        }
        public void SapXepTheoMaNV()
        {
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = 1+i; j < n; j++)
                {
                    if (mangNV[j].MaSo < mangNV[minIndex].MaSo)
                    {
                        minIndex = j;

                    }
                }
                NhanVien tam = mangNV[i];
                mangNV[i] = mangNV[minIndex];
                mangNV[minIndex] = tam;
            }
        }
        public void NhanVienLuongCaoNhat()
        {
            double maxLuong = mangNV[0].LuongCB;
            int maxIndex = 0;
            for(int i = 1; i < n ; i++)
            {
                if (mangNV[i].LuongCB > mangNV[maxIndex].LuongCB)
                {
                    maxIndex = i;
                }
            }
            Console.WriteLine("Nhan vien co luong cao nhat la: " + mangNV[maxIndex].ToString() );
        }

        public void ChenNhanVien(NhanVien nv,int viTri)
        {
            NhanVien[] mangTam = mangNV;
            n = n + 1;
            mangNV = new NhanVien[n];
            for (int i = 0; i <mangNV.Length; i++)
            {
                mangNV[i] = mangTam[i];
            }
            for (int i = n-1; i >=viTri;i--)
            {
                mangNV[i] = mangNV[i-1];
            }
            MangNV[viTri] = nv;
        }
        public void XoaNhanVien(NhanVien nv)
        {
            int viTri=TimKiemNV(nv);
            if(viTri>0) 
            {
                for(int i = viTri; i < n -1;i++)
                {
                    mangNV[i] = mangNV[i+1];
                }
            }
        }
    }
}
