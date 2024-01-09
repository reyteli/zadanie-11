using System;

namespace zadanie_11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Equation lineEquation = new Equation();
            try
            {
                Console.WriteLine("Решаем линейное уравнение 0=kx+b ");
                Console.Write("Укажите коэффициент k: ");
                lineEquation.K = Convert.ToDouble(Console.ReadLine());
                Console.Write("Укажите коэффициент b: ");
                lineEquation.B = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат ввода!");
                return;
            }
            lineEquation.Solution();
            Console.ReadKey();
        }
    }
    struct Equation
    {
        private double _K;

        public double K
        {
            get
            {
                return _K;
            }
            set
            {
                if (value != 0)
                {
                    _K = value;
                }
                else
                {
                    Console.WriteLine("Коэффициент k не может быть равен 0");
                }
            }
        }

        public double B { get; set; }

        public Equation(double K, double B)
        {
            this._K = K;

            this.B = B;
        }

        public void Solution()
        {
            Console.WriteLine("Решение уравнения. Х = {0:f2}", (-B) / K);
        }
    }
}
