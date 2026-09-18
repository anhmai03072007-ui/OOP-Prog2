using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Prog2.Session_05.Bài_3
{
    internal class GiaoDichVang : GiaoDich
    {
        public string LoaiVang { get; set; }
        public GiaoDichVang(string maGiaoDich, DateTime ngayGiaoDich, decimal donGia, int soLuong, string loaiVang)
            : base(maGiaoDich, ngayGiaoDich, donGia, soLuong)
        {
            LoaiVang = loaiVang;
        }
        public override string ToString()
        {
            return base.ToString() + $", Loai vang: {LoaiVang}";
        }
        public decimal ThanhTien()
        {
            return DonGia * SoLuong;
        }
    }
}
