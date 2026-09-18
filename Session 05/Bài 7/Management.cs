using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Prog2.Session_05.Bài_7
{
    internal class Management
    {
        private Person[] danhSach;
        private int soLuong;

        public Management(int n)
        {
            danhSach = new Person[n];
            soLuong = 0;
        }

        // Them nguoi vao danh sach
        public void Them(Person p)
        {
            if (soLuong < danhSach.Length)
            {
                danhSach[soLuong] = p;
                soLuong++;

                Console.WriteLine("Them thanh cong!");
            }
            else
            {
                Console.WriteLine("Danh sach da day!");
            }
        }

        // Xoa nguoi theo ho ten
        public void Xoa(string hoTen)
        {
            for (int i = 0; i < soLuong; i++)
            {
                if (danhSach[i].hoTen == hoTen)
                {
                    for (int j = i; j < soLuong - 1; j++)
                    {
                        danhSach[j] = danhSach[j + 1];
                    }

                    soLuong--;

                    Console.WriteLine("Xoa thanh cong!");
                    return;
                }
            }

            Console.WriteLine("Khong tim thay nguoi can xoa!");
        }

        // Sap xep theo ho ten
        public void SapXep()
        {
            for (int i = 0; i < soLuong - 1; i++)
            {
                for (int j = i + 1; j < soLuong; j++)
                {
                    if (string.Compare(
                        danhSach[i].hoTen,
                        danhSach[j].hoTen) > 0)
                    {
                        Person temp = danhSach[i];
                        danhSach[i] = danhSach[j];
                        danhSach[j] = temp;
                    }
                }
            }
            Console.WriteLine("Da sap xep danh sach!");
        }

        // Xuat danh sach
        public void Xuat()
        {
            if (soLuong == 0)
            {
                Console.WriteLine("Danh sach rong!");
                return;
            }

            Console.WriteLine("\n========== DANH SACH ==========");

            for (int i = 0; i < soLuong; i++)
            {
                Console.WriteLine(danhSach[i].ToString());
            }

            Console.WriteLine("===============================");
            Console.WriteLine("Tong so nguoi: " + soLuong);
        }
    }
}
