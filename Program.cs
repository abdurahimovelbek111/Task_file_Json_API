using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace _1_Topshiriq_file_Json_API
{     
    class Program
    {
        static void Main(string[] args)
        {
               List<string> dori = new List<string>();
               string path = "Dorixona.txt";
                    Console.Write("Yangi dori qushish menyusiga utish uchun 1 ni bosing :\n" +
                        "Dorini qidirish menyusiga utish uchun 2 ni bosing :\n" +
                        "Dorini o'chirish menyusiga utish uchun 3 raqamni bosing :\n" +
                        "Dori ma'lumotlarini o'zgartirish menyusiga utish uchun 4 raqamni bosing :\n" +
                        "Dori haqidagi umumiy ma'lumot olish uchun 5 raqamni bosing:\n");
                      int raqam = int.Parse(Console.ReadLine());
          

        }
    }
}
