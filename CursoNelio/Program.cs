using System.Formats.Asn1;

namespace CursoNelio
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine($"a soma é de {a + b}");

            //double raio = double.Parse(Console.ReadLine());
            //double pi = 3.14159;
            //double area = pi * Math.Pow(raio, 2);
            //Console.WriteLine(area);

            //int A = int.Parse(Console.ReadLine());
            //int B = int.Parse(Console.ReadLine());
            //int C = int.Parse(Console.ReadLine());
            //int D = int.Parse(Console.ReadLine());
            //int diferenca = (A * B - C * D);
            //Console.WriteLine(diferenca);

            int serial = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());
            double valorHora = double.Parse(Console.ReadLine());
            double salario = horas * valorHora;
            Console.WriteLine($"number = {serial}");
            Console.WriteLine($"salary = ${salario}");

        }
    }
}
