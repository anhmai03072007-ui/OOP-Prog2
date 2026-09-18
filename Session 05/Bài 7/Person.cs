using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Prog2.Session_05.Bài_7
{
    internal class Person
    {
        private string _hoten;
        private string _diachi;
        public string hoTen
        {
            get { return _hoten; }
            set
            {
                _hoten = value;
            }
        }

        public string diaChi
        {
            get { return _diachi; }
            set
            {
                _diachi = value;
            }
        }
        public Person(string hoTen, string diachi)
        {
            this.hoTen = hoTen;
            this.diaChi = diachi;
        }
        public override string ToString()
        {
            return $"Ho ten: {this.hoTen}, Dia chi: {this.diaChi}\n";
        }
    }
}
