// Bài Toán căn bậc hai lần 2
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Số của a là: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Số của b là: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Số của c là: ");
        double c = double.Parse(Console.ReadLine());
        double x = 0;
        double delta = b * b - 4 * a * c;

        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
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
                Console.WriteLine(x = -c / b);
            }
        }
        else
        {
            Console.WriteLine(delta = b * b - 4 * a * c);

            if (delta > 0)
            {
                double x11 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x12 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Nghiệm của x1 là: " + x11);
                Console.WriteLine("Nghiệm của x2 là: " + x12);
            }
            else if (delta == 0)
                Console.WriteLine("Có Nghiệm kép x1 = x2 = " + -b / (2 * a));
            else
                Console.WriteLine("Vô Nghiệm");
        }

    }   // luôn nhớ đóng hàm Main
}   //  luôn nhớ đóng class Program 






