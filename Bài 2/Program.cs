using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shop> listShop = new List<Shop>();
            listShop.Add(new Shop(1, "HCM", "Quan 12"));
            listShop.Add(new Shop(2, "Ha noi", "Quan Nam tu lien"));
            listShop.Add(new Shop(3, "Da nang", "Quan Hai chau"));

            List<Phone> listPhone = new List<Phone>();

            listPhone.Add(new Phone(1, 1, "IP 15", 100, "Doc la binh duong"));
            listPhone.Add(new Phone(2, 2, "IP 16", 1000, "Doc la binh duong"));
            listPhone.Add(new Phone(3, 3, "IP 17", 10000, "Doc la binh duong"));
            listPhone.Add(new Phone(4, 1, "IP 18", 100000, "Doc la binh duong"));

            
            var result = listShop.GroupJoin(
            listPhone,
            shop => shop.id,
            phone => phone.shop_id,
            (shop, phones) => new
            {
                ShopName = shop.name,
                Phones = phones.Select(phone => new
                {
                    PhoneName = phone.name,
                    PhonePrice = phone.price
                })
            });

            foreach (var shop in result)
            {
                Console.WriteLine($"Ten cua hang: {shop.ShopName}");
                Console.WriteLine("-------------------");
                foreach (var phone in shop.Phones)
                {
                    Console.WriteLine($"Ten dien thoai: {phone.PhoneName}");
                    Console.WriteLine($"Gia dien thoai: {phone.PhonePrice}");
                    Console.WriteLine("-------------------");
                }
            }
        }
    }
}
