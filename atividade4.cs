using System;

namespace Lista4
{
    public static class atividade4
    {
        public static void rodar(){
            double x, y, z;

            try{
                while (true)
                {
                    Console.WriteLine("Digite N a qualquer momento para sair");
                    Console.WriteLine("Digite o valor de x: ");
                    x = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor de y: ");
                    y = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor de z: ");
                    z = double.Parse(Console.ReadLine());
                    IdentificarTriangulo(x,y,z);
                    Console.WriteLine("\n");
                }
            }
            catch(System.FormatException ex){
                return;
            }
        }

        public static void IdentificarTriangulo(double x, double y, double z){

            if(x + y > z && x + z > y && y + z > x)
            {
                if(x == y && y == z){
                    Console.WriteLine("O triangulo é equilatero");
                }
                else if(x == y || z == x || z == y){
                    Console.WriteLine("O Triangulo é Isoceles");
                }
                else{
                    Console.WriteLine("O Triangulo é Escaleno:");
                }
            }
            else{
                Console.WriteLine("Triangulo Invalido");
            }
        }
    }
}
