using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Prog2.Session_05.Bài_2
{
    internal class SachThamKhao : Sach
    {
        public decimal Thue { get; set; }

        public SachThamKhao(string maSach, DateTime ngayNhap, decimal donGia, byte soLuong, string nhaXuatBan, decimal thue) : base(maSach, ngayNhap, donGia, soLuong, nhaXuatBan)
        {
            Thue = thue;
        }

        public decimal thanhTien()
        {
            return DonGia * SoLuong + Thue;
        }
        public override string ToString()
        {
            return base.ToString() + $", Thue: {Thue}";
        }
    }
}
