using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230826_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //File
            //File sınıfını kullanabilmemiz için System.IO kütüphanesini projemize eklememiz gerekmektedir

            string yol= @"C:\Users\pcc\Desktop\Yeni Klasör\deneme.txt";

            //File sınıfı aracılığıyla dosya oluşturmak için File.Createtext(yol)

            File.CreateText(yol);

            //File sınıfı ile dosya varlığının kontrolü Exists() metodu ile sağlanır
            if (File.Exists(yol))
            {
                Console.WriteLine("BU isimde bir dosya var");
            }
            else { Console.WriteLine( "Dosya bulunamadı"); }

            //File sınıf ile dosya silme işlemi 
            //File.Delete(yol);
            Console.ReadKey();
        }
    }
}
