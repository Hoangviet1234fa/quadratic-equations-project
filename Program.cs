using System.Net;

class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("nhập a vô nhanh:");
        var a = Console.ReadLine();
        Console.WriteLine("nhập b vô nhanh:");
        var b = Console.ReadLine();
        Console.WriteLine("nhập c vô nhanh:");
        var c = Console.ReadLine();

        int aInt = int.Parse(a ?? "0");
        int bInt = int.Parse(b ?? "0");
        int cInt = int.Parse(c ?? "0");

        if (aInt == 0)
        {
            if (bInt == 0)
            {
                if (cInt == 0)
                {
                    Console.WriteLine("Vô Số Nghiệm");
                }
                else
                {
                    Console.WriteLine("Vô Nghiệm");
                }
            }
            else
            {
                double x = -cInt * 1.0 / bInt;
                Console.WriteLine($"Nghiệm của phương trình là x = {x}");
            }
        }
        else
        {
            int delta = bInt * bInt - 4 * aInt * cInt;
            if (delta > 0)
            {
                double sqrtDelta = Math.Sqrt(delta);
                double x1 = (-bInt + sqrtDelta) / (2.0 * aInt);
                double x2 = (-bInt - sqrtDelta) / (2.0 * aInt);
                Console.WriteLine($"Hai nghiệm phân biệt: x1={x1} và x2={x2}");
            }
            else if (delta == 0)
            {
                double x = -bInt * 1.0 / (2 * aInt);
                Console.WriteLine($"Nghiệm kép: x1 = x2 = {x}");
            }
            else
            {
                Console.WriteLine("Không có nghiệm");
            }
        }
    }
}



