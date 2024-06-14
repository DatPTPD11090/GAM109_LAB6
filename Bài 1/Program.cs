using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 2, 4, 5, 6, 7, 8, 9, };
            List<string> listStr = new List<string>() { null, "T1", "T2", "T3", null };
            List<string> listNull = new List<string>();

            // a
            var sochanlonhon5 = numbers.FirstOrDefault(x => x % 2 == 0 && x > 5);
            if (sochanlonhon5 != 0)
            {
                Console.WriteLine("so chan dau tien lon hon 5 trong danh sach la: " + sochanlonhon5);
            }
            else
            {
                Console.WriteLine("Khong tim thay so chan nao lon hon 5 trong danh sach.");
            }

            // b
            var phantucuoi = numbers.LastOrDefault(x => x > 200);
            Console.WriteLine("Phan tu cuoi cung lon hon 200 la: " + phantucuoi);

            // c
            var phantudautien = listStr.FirstOrDefault(x => x != null && x.StartsWith("T"));
            if (phantudautien != null)
            {
                Console.WriteLine("Phan tu dau tien bat dau bang ky tu (T) trong listStr la: " + phantudautien);

            }
            else
            {
                Console.WriteLine("Khong tim thay phan tu bat dau bang ky tu (T). ");

            }
            var Tong = numbers.Where((value, index) => index % 2 != 0 && value % 2 == 0).Sum();
            Console.WriteLine("Tong gia tri chia het cho 2 la: "+ Tong);
        }
    }
}
