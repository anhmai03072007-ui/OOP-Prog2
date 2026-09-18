using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Prog2.Session_05.Bài_7
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhap so luong nguoi toi da: ");
            int n = int.Parse(Console.ReadLine());

            Management ql = new Management(n);

            int chon;

            do
            {
                Console.WriteLine();
                Console.WriteLine("========== MENU ==========");
                Console.WriteLine("1. Them sinh vien");
                Console.WriteLine("2. Them nhan vien");
                Console.WriteLine("3. Them khach hang");
                Console.WriteLine("4. Xoa nguoi");
                Console.WriteLine("5. Sap xep theo ho ten");
                Console.WriteLine("6. Xuat danh sach");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("==========================");

                Console.Write("Nhap lua chon: ");
                chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    // =========================
                    // THEM SINH VIEN
                    // =========================
                    case 1:
                        Console.WriteLine("\n--- THEM SINH VIEN ---");

                        Console.Write("Ho ten: ");
                        string hoTenSV = Console.ReadLine();

                        Console.Write("Dia chi: ");
                        string diaChiSV = Console.ReadLine();

                        Console.Write("Diem mon 1: ");
                        float diem1 = float.Parse(Console.ReadLine());

                        Console.Write("Diem mon 2: ");
                        float diem2 = float.Parse(Console.ReadLine());

                        Student sv = new Student(
                            hoTenSV,
                            diaChiSV,
                            diem1,
                            diem2);

                        ql.Them(sv);

                        break;


                    // =========================
                    // THEM NHAN VIEN
                    // =========================
                    case 2:
                        Console.WriteLine("\n--- THEM NHAN VIEN ---");

                        Console.Write("Ho ten: ");
                        string hoTenNV = Console.ReadLine();

                        Console.Write("Dia chi: ");
                        string diaChiNV = Console.ReadLine();

                        Console.Write("He so luong: ");
                        float heSo = float.Parse(Console.ReadLine());

                        Employee nv = new Employee(
                            hoTenNV,
                            diaChiNV,
                            heSo);

                        ql.Them(nv);

                        break;


                    // =========================
                    // THEM KHACH HANG
                    // =========================
                    case 3:
                        Console.WriteLine("\n--- THEM KHACH HANG ---");

                        Console.Write("Ho ten: ");
                        string hoTenKH = Console.ReadLine();

                        Console.Write("Dia chi: ");
                        string diaChiKH = Console.ReadLine();

                        Console.Write("Ten cong ty: ");
                        string tenCongTy = Console.ReadLine();

                        Console.Write("Tri gia hoa don: ");
                        float triGia = float.Parse(Console.ReadLine());

                        Console.Write("Danh gia: ");
                        string danhGia = Console.ReadLine();

                        Customer kh = new Customer(
                            hoTenKH,
                            diaChiKH,
                            tenCongTy,
                            triGia,
                            danhGia);

                        ql.Them(kh);

                        break;


                    // =========================
                    // XOA
                    // =========================
                    case 4:
                        Console.Write("\nNhap ho ten can xoa: ");
                        string tenXoa = Console.ReadLine();

                        ql.Xoa(tenXoa);

                        break;


                    // =========================
                    // SAP XEP
                    // =========================
                    case 5:
                        ql.SapXep();

                        break;


                    // =========================
                    // XUAT
                    // =========================
                    case 6:
                        ql.Xuat();

                        break;


                    // =========================
                    // THOAT
                    // =========================
                    case 0:
                        Console.WriteLine("Ket thuc chuong trinh!");

                        break;


                    default:
                        Console.WriteLine("Lua chon khong hop le!");

                        break;
                }

            } while (chon != 0);
        }
    }
}

