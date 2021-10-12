using System;

public class Sesi4Page12
{
    public static void Main(string[] args)
    {
        string[] contoh = new string[4]{
            "Motherboard", "Processor", "Power Supply", "Video Card"
        };

        Console.WriteLine("Menampilkan semua isi array\n");

        foreach (var item in contoh)
        {
            Console.WriteLine(item);
        }
    }
}