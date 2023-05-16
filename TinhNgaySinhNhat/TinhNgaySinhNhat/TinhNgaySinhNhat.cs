using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhNgaySinhNhat
{
    class TinhNgaySinhNhat
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap ngay sinh (dd/MM/yyyy):");
            DateTime ngaySinh = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            DateTime ngayHienTai = DateTime.Now;
            DateTime ngaySinhNhatTiepTheo = new DateTime(ngayHienTai.Year, ngaySinh.Month, ngaySinh.Day);

            if (ngaySinhNhatTiepTheo < ngayHienTai)
            {
                ngaySinhNhatTiepTheo = ngaySinhNhatTiepTheo.AddYears(1);
            }

            TimeSpan timeSpan = ngaySinhNhatTiepTheo - ngayHienTai;
            int soNgayConLai = timeSpan.Days;

            Console.WriteLine("So ngay con lai den sinh nhat: " + soNgayConLai);

            Console.ReadKey();
        }
    }
}
