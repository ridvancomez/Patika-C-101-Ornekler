using System;

namespace CSharpEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(Gunler.Pazar);
            System.Console.WriteLine((int)Gunler.Cumartesi);
        }
    }
    enum Gunler
    {
        Pazartesi=1,Salı,Çarşamba,Perşembe,Cuma,Cumartesi,Pazar
    }
}
