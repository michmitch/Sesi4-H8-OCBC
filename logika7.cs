using System;

public class Sesi4Page24
{
    public static void Main(string[] args)
    {
        string str1 = "Untuk pemrograman .NET, C# adalah #1.";
        string str2 = "Untuk pemrograman .NET, C# adalah #1.";
        string str3 = "string C# sangat tangguh.";
        string strAtas, strBawah;
        int hasil, idx;

        Console.WriteLine("str1: " + str1);
        Console.WriteLine("panjang str1: " + str1.Length);
        
        strBawah = str1.ToLower(CultureInfo.CurrentCulture);
        strAtas = str1.ToUpper(CultureInfo.CurrentCulture);

        Console.WriteLine("str1 lower: " + strBawah);
        Console.WriteLine("str1 upper: " + strAtas + "\n");

        Console.WriteLine("str1 char by char: ");

        for (int i = 0; i < str1.Length; i++)
        {
            Console.WriteLine(str1[i]);
        }
        Console.WriteLine();

        if(str1 == str2){
            Console.WriteLine("str1 == str2");
        }
        else{
            Console.WriteLine("str1 != str2");
        }

        if(str1 == str3){
            Console.WriteLine("str1 == str3");
        }
        else{
            Console.WriteLine("str1 != str3");
        }

        hasil = string.Compare(str1, str3, StringComparison.CurrentCulture);

        if(hasil == 0){
            Console.WriteLine("str1 & str3 sama");
        }
        else if(hasil<0){
            Console.WriteLine("str1 kurang dr str3");
        }
        else{
            Console.WriteLine("str1 lebih bsr dr str3");
        }

        Console.WriteLine();

        str2 = "Satu Dua Tiga Satu";

        idx = str2.IndexOf("Satu", StringComparison.Ordinal);
        Console.WriteLine("Index kemunculan pertama dari kata 'satu' : " + idx);

        idx = str2.LastIndexOf("Satu", StringComparison.Ordinal);
        Console.WriteLine("Index kemunculan terakhir dari kata 'satu' : " + idx);

    }
}