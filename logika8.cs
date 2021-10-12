public class Sesi4Page2628
{
    public static void Main(string[] args)
    {
        string[] str = {"Ini", "adalah", "sebuah", "test."};
        Console.WriteLine("Array Asli: ");

        for(int i=0;i<str.Length;i++){
            Console.WriteLine(str[i] + " ");
        }
        Console.WriteLine();

        str[1] = "merupakan";
        str[3] = "test, juga!";
        Console.WriteLine("Array modifikasi: ");

        for(int i=0; i<str.Length; i++){
            Console.Write(str[i] + " ");
        }

        // page 28
        string cobasubstr = "C# membuat string mudah.";

        string substrr = cobasubstr.Substring(5,12);
        Console.WriteLine("String awal: " + cobasubstr);
        Console.WriteLine("substring" + substrr);
    }
}