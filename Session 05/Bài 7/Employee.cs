using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Prog2.Session_05.Bài_7
{
    internal class Employee : Person
    {
        private float _hesoluong;

        public float heSoLuong
        {
            get { return _hesoluong; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("He so luong phai >= 0");
                else
                    _hesoluong = value;
            }
        }

        public Employee(
            string hoTen,
            string diachi,
            float heSoLuong) : base(hoTen, diachi)
        {
            this.heSoLuong = heSoLuong;
        }

        public float TinhLuong()
        {
            return 2530000f * heSoLuong;
        }

        public string DanhGia()
        {
            string DG;

            switch (this.TinhLuong())
            {
                case < 8000000f:
                    DG = "Trung binh";
                    break;

                case < 15000000f:
                    DG = "Kha";
                    break;

                default:
                    DG = "Tot";
                    break;
            }

            return DG;
        }

        public override string ToString()
        {
            return base.ToString()
                + $"He so luong: {this.heSoLuong}, "
                + $"Tien luong: {this.TinhLuong()}, "
                + $"Danh gia: {this.DanhGia()}";
        }
    }
}
