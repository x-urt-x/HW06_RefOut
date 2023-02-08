using System.Globalization;

namespace HW06_RefOut
{
    internal class Program
    {
        static NumberFormatInfo nFI = new NumberFormatInfo()
        {
            NumberDecimalSeparator = ","
        };
        static void Main(string[] args)
        {

            double a, b;
            
            Console.WriteLine("1-swap\t2-quantity\t3-indexof");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.Write("a= ");
                    a = double.Parse(Console.ReadLine().Replace(".", ","), nFI);
                    Console.Write("b= ");
                    b = double.Parse(Console.ReadLine().Replace(".", ","), nFI);
                    Swap(ref a, ref b);
                    Console.WriteLine($"a={a}\tb={b}");
                    break;
                case 2:
                    Console.Write("a= ");
                    a = double.Parse(Console.ReadLine().Replace(".", ","), nFI);
                    Quan(a, out b);
                    Console.WriteLine($"quantity={b}");
                    break;
                case 3:
                    Console.Write("str= ");
                    string str = Console.ReadLine();
                    Console.Write("index= ");
                    a = double.Parse(Console.ReadLine().Replace(".", ","), nFI);
                    char c;
                    IndexOf1(str, (int)a, out c);
                    Console.WriteLine($"char at {a}= {c}");
                    break;
                default:
                    break;
            }


        }

        static void Swap(ref double a, ref double b)
        {
            double c = b;
            b = a; a = c;
        }
        static void Quan(double a, out double b)
        {
            b = a.ToString().Replace("-", "").Replace(",", "").Length;
        }
        static void IndexOf1(string str, int a, out char c)
        {
                c = str[a];
        }
    }
}