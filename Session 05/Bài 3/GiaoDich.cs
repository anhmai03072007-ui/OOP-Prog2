using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Prog2.Session_05.Bài_3
{
    internal class GiaoDich
    {
        public string MaGiaoDich { get; set; }
        public DateTime NgayGiaoDich { get; set; }
        public decimal DonGia { get; set; }
        public int SoLuong { get; set; }

        public GiaoDich(string maGiaoDich, DateTime ngayGiaoDich, decimal donGia, int soLuong)
        {
            MaGiaoDich = maGiaoDich;
            NgayGiaoDich = ngayGiaoDich;
            DonGia = donGia;
            SoLuong = soLuong;
        }
        public override string ToString()
        {
            return $"Ma giao dich: {MaGiaoDich}, Ngay giao dich: {NgayGiaoDich.ToShortDateString()}, Don gia: {DonGia}, So luong: {SoLuong}";
        }

    }
}
