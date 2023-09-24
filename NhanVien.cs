using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapNguyenHuynhDongTrieu22dh113859
{
    internal class NhanVien
    {
        int maSo;
        string hoTen;
        double luongCB;
        double heSoLuong;

        public int MaSo { get => maSo; set => maSo = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public double LuongCB { get => luongCB; set => luongCB = value; }
        public double HeSoLuong { get => heSoLuong; set => heSoLuong = value; }

        public NhanVien()
        {
            this.maSo = 0;
            this.hoTen = "";
            this.luongCB = 0;
            this.heSoLuong = 0;
        }
        public NhanVien(int maso, string hoten, double luongCB, double heSoLuong)
        {
            this.maSo = maso;
            this.hoTen = hoten;
            this.luongCB = luongCB;
            this.heSoLuong = heSoLuong;
        }
        public NhanVien(NhanVien nv)
        {
            this.maSo = nv.maSo;
            this.hoTen = nv.hoTen;
            this.luongCB = nv.luongCB;
            this.heSoLuong = nv.heSoLuong;
        }
        public void Nhap()
        {
            Console.Write("Nhap ma so: ");
            maSo = int.Parse(Console.ReadLine());
            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();

            Console.Write("Nhap he so luong: ");
            heSoLuong = double.Parse(Console.ReadLine());
            Console.Write("Nhap luong co ban: ");
            luongCB = double.Parse(Console.ReadLine());

        }
        public void Xuat()
        {
            Console.WriteLine("Ho ten NV: {0}, ma so: {1}, he so luong {2} , luongCB{3}", hoTen, maSo, heSoLuong, luongCB);
        }
        public override string ToString()
        {
            return String.Format("Ho ten NV: {0}, ma so: {1}, he so luong {2} , luongCB{3}", hoTen, maSo, heSoLuong, luongCB);
        }
    }

}

