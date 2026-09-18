using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Prog2.Session_05.Bài_1
{
    internal class XeNoiThanh : ChuyenXe
    {
        public int SoTuyen { get; set; }
        public int SoKmDiDuoc { get; set; }

        public XeNoiThanh(string maSoChuyen, string hoTenTaiXe, string soXe, decimal doanhThu, int soTuyen, int soKmDiDuoc) : base(maSoChuyen, hoTenTaiXe, soXe, doanhThu)
        {
            SoTuyen = soTuyen;
            SoKmDiDuoc = soKmDiDuoc;
        }

        public override string ToString()
        {
            return base.ToString() + $", So tuyen: {SoTuyen}, So km di duoc: {SoKmDiDuoc}";
        }
    }
}
