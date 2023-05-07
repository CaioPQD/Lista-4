using System;


namespace Lista4
{
    public class atividade8
    {
        public static void rodar() {
            Console.Write("Digite um valor inteiro positivo: ");
            int n = int.Parse(Console.ReadLine());
            double s = CalculaS(n);
            Console.WriteLine("S = " + s);
        }

        public static double CalculaS(int n) {
            double s = 0;
            for (int i = 0; i <= n; i++) {
                double numerador = i * i + 1;
                double denominador = i + 3;
                double termo = numerador / denominador;
                s += termo;
            }
            return s;
        }
    }
}
