using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Prog2.Session_05.Bài_7
{
    internal class Student : Person
    {
        private float _diemmon1;
        private float _diemmon2;

        public float diemMon1
        {
            get { return _diemmon1; }
            set
            {
                if (value < 0 || value > 10)
                    throw new ArgumentException("Diem phai tu 0 den 10");
                else
                    _diemmon1 = value;
            }
        }

        public float diemMon2
        {
            get { return _diemmon2; }
            set
            {
                if (value < 0 || value > 10)
                    throw new ArgumentException("Diem phai tu 0 den 10");
                else
                    _diemmon2 = value;
            }
        }

        public Student(
            string hoTen,
            string diachi,
            float diemMon1,
            float diemMon2) : base(hoTen, diachi)
        {
            this.diemMon1 = diemMon1;
            this.diemMon2 = diemMon2;
        }

        public float DiemTrungBinh()
        {
            return (diemMon1 + diemMon2) / 2f;
        }

        public string DanhGia()
        {
            string DG;

            switch (this.DiemTrungBinh())
            {
                case < 5f:
                    DG = "Yeu";
                    break;

                case < 7.5f:
                    DG = "Trung binh";
                    break;

                case < 8.5f:
                    DG = "Kha";
                    break;

                default:
                    DG = "Gioi";
                    break;
            }

            return DG;
        }

        public override string ToString()
        {
            return base.ToString()
                + $"Diem mon 1: {this.diemMon1}, "
                + $"Diem mon 2: {this.diemMon2}, "
                + $"Diem trung binh: {this.DiemTrungBinh()}, "
                + $"Danh gia: {this.DanhGia()}";
        }
    }
}
