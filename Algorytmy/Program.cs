namespace Algorytmy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RailFence.Encode("CRYPTOGRAPHY", 3));
            Console.WriteLine(MatrixShiftB.Encode("FRANCJA", "BCADA"));
            Console.WriteLine(MatrixShiftB.Decode("IIEYURNSVT", "BCADA"));
        }
    }
}