using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Prog2.Session_05.Bài_4
{
    internal class SachThamKhao : Sach
    {
        private double thue;
        public SachThamKhao(string maSach, DateTime ngayNhap, double donGia, int soLuong, string nhaXuatBan, double thue) : base(maSach, ngayNhap, donGia, soLuong, nhaXuatBan)
        {
            this.thue = thue;
        }
        public SachThamKhao() : this("N/A", DateTime.Now, 0, 0, "N/A", 0) { }
        public void setThue(double thue)
        {
            this.thue = thue;
        }
        public double getThue() { return thue; }
        public override double getThanhTien()
        {
            return (double)getDonGia() * getSoLuong() + getThue();
        }
        public override string ToString()
        {
            return base.ToString() + $"Thue: {thue}";
        }
    }
}
