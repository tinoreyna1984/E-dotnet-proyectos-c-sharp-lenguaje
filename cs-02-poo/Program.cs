using System;
using Triangulos;
using Cuadrilateros;

// deshabilita warnings molestosos
//#pragma warning disable CS0168
#pragma warning disable IDE0060
#pragma warning disable IDE0079
#pragma warning disable IDE0090
#pragma warning disable IDE0057
#pragma warning disable IDE0028
#pragma warning disable SYSLIB1045

namespace Program
{
    public class Program {
        static void Main(string[] args)
        {
            HelloWorld helloWorld = new HelloWorld("Este es un programa en C#");
            helloWorld.Saludo();
            Console.WriteLine("Probando clases");
            Triangulo triangulo = new Triangulo(4, 2, 2, 2);
            Console.WriteLine(triangulo.QuienSoy());
            Console.WriteLine("Area: " + triangulo.Area());
            Console.WriteLine("Perímetro: " + triangulo.Perimetro());
            Cuadrado cuadrado = new Cuadrado(6);
            Console.WriteLine(cuadrado.QuienSoy());
            Console.WriteLine("Area: " + cuadrado.Area());
            Console.WriteLine("Perímetro: " + cuadrado.Perimetro());
        }
    }

    public class HelloWorld
    {
        public string Mensaje {set; get;}
        public HelloWorld(string Mensaje)
        {
            this.Mensaje = Mensaje;
        }
        public void Saludo()
        {
            Console.WriteLine(Mensaje);
        }
    }
}
