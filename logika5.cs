using System;

public class Sesi4Page1920
{
    public static void Main(string[] args)
    {
        int[] angka = new int[10];

        Console.WriteLine("Panjang Array : " + angka.Length);

        for(int i=0; i<angka.Length; i++){
            angka[i] = i * i;
        }

        for(int i=0; i<angka.Length; i++){
            Console.Write(angka[i] + " ");
        }
        Console.WriteLine();

        // page 20
        int[, ,] angka2 = new int[10, 5, 6];
        Console.WriteLine("Panjang : " + angka2.Length);
    }
}