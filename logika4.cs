using System;

public class Sesi4Page18
{
    public static void Main(string[] args)
    {
        int[][] jagged_array = new int[3][];
        jagged_array[0] = new int[4];
        jagged_array[1] = new int[3];
        jagged_array[2] = new int[5];

        int i;

        for(i=0; i<4; i++){
            jagged_array[0][i] = i;
        }

        for(i=0; i<3; i++){
            jagged_array[1][i] = i;
        }

        for(i=0; i<5; i++){
            jagged_array[2][i] = i;
        }

        for(i=0; i<4; i++){
            Console.Write(jagged_array[0][i] + " ");
        }
        Console.WriteLine();

        for(i=0; i<3; i++){
            Console.Write(jagged_array[1][i] + " ");
        }
        Console.WriteLine();

        for(i=0; i<5; i++){
            Console.Write(jagged_array[2][i] + " ");
        }
        Console.WriteLine();
    }
}