using System;

namespace ejejrcicio02iñiguezoscar




{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Double a;
                Double b;
                Double c;
                Double d;
                Double e;
                Double radio = 0;
                Double centro1 = 0;
                Double centro2 = 0;

                Console.WriteLine("Ingrese los datos de la ecuación Ax2+By2+Cx+Dy+E=0.");
                Console.WriteLine("");

                Console.Write("Ingrese el primer número: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese el segundo número: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese el tercer número: ");
                c = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese el cuarto número: ");
                d = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese el quinto número: ");
                e = Convert.ToDouble(Console.ReadLine());



                if (a == 0 & b == 0)
                {
                    Console.WriteLine("Los datos ingresados no conforman una cónica.");
                }
                else
                {
                    if (a > 0 & b == 0 || a == 0 & b > 0)
                    {
                        Console.WriteLine("La cónica es una parábola.");
                    }
                    else
                    {
                        if (a == b)
                        {
                            Console.WriteLine($"{verificarcirculo(a, b, c, d, e, centro1, centro2, radio)}");
                        }
                        else
                        {
                            if (a != 0 & b != 0 & a > 0 & b > 0 & a != b || a != 0 & b != 0 & a < 0 & b < 0 & a != b)
                            {
                                Console.WriteLine("La cónica es un elipse");
                            }
                            else
                            {
                                if (a != 0 & b != 0 & a < 0 & b > 0 & a != b || a != 0 & b != 0 & a > 0 & b < 0 & a != b)
                                {
                                    Console.WriteLine("La cónica es una hipérbola");
                                }
                            }
                        }
                    }
                }
                Console.ReadKey();
            }
            catch (Exception)
            {

                Console.Write("Los números están mal ingresados");
                Console.ReadKey();
            }

        }

        private static string verificarcirculo(double a, double b, double c, double d, double e, double radio, double centro1, double centro2)
        {
            if (a != 1 & b != 1 & a == b)
            {
                d = d / a;
                e = e / a;
                c = c / a;
            }
            if (a == b & a != 0 & b != 0)
            {
                radio = (1 / 2) * (Math.Sqrt((c * c + d * d)) - (4 * e));
                centro1 = -d / 2;
                centro2 = -e / 2;

            }
            return $"La cónica es una circunferencia, su radio es {radio} y sus coordenadas centro son {centro1};{centro2}";
        }
    }
}