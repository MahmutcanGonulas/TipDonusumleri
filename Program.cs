using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1-Implicit Conersion (Bilinçsiz Dönüşüm)
            // 2-Explicit Conversion (Bilinçli Dönüşüm)


            // Implicit Conersion (Bilinçsiz Dönüşüm)
            byte a=5;
            sbyte b=30;
            short c=10;
            int d=a+b+c;
            Console.WriteLine("Integer "+d);
            //integer alanı diğerlerine göre büyük olduğu için herhangi bir sıkıntı yok

            long h=d;
            Console.WriteLine("Long "+h);
            //longun alanı diğerlerine göre büyük olduğu için herhangi bir sıkıntı yok
            float i=h;
            Console.WriteLine("Float "+i);
            
            string e="Blackfyre";
            char f='k';
            object g=e+f+d;
            Console.WriteLine("Object "+g);


            // 2-Explicit Conversion (Bilinçli Dönüşüm)
            int x=4;
            byte y= (byte)x;
            Console.WriteLine("y "+y);

            int z=100;
            byte t=(byte)z;
            Console.WriteLine("t "+t);

            float w=10.3f;
            byte v=(byte)w;
            Console.WriteLine("w "+w);

            // ToString Metodu
            int xx=6;
            string yy=xx.ToString();
            Console.WriteLine("To String "+yy);

            string zz=12.4f.ToString();
            Console.WriteLine("To String "+zz);


            //System.Convert
            string s1="10", s2="20";
            int sayi1,sayi2;
            int Toplam;
            sayi1=Convert.ToInt32(s1);
            sayi2=Convert.ToInt32(s2);
            Toplam=sayi1+sayi2;
            Console.WriteLine("Toplam "+Toplam);

            //Parse
            ParseMethod();
        }
    public static void ParseMethod(){

        string metin1="10";
        string metin2="10,25";
        int rakam1;
        double double1;
        double double2=11.25;

        //String to integer with parse
        rakam1=Int32.Parse(metin1);
        Console.WriteLine("Rakam "+rakam1);
        //String to double with parse
        double1=Double.Parse(metin2);
        Console.WriteLine("double "+double1);
        Console.WriteLine(double1+double2);

        
        
        
        }
    }
}