using System;

public class Sesi4Page16
{
    public static void Main(string[] args)
    {
        int i, j;
        int[,] tabel = {
            {1,1},
            {2,4},
            {3,9},
            {4,16},
            {5,25},
            {6,36},
            {7,49},
            {8,64},
            {9,81},
            {10,100}
        };

        for (i=0; i<10; i++){
            for (j=0; j<2; j++){
                Console.Write(tabel[i,j] + " ");
            }
            Console.WriteLine();
        }
    }
}