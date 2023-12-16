using Figuras;

namespace Cuadrilateros
{
    // Cuadrilatero hereda de Figura
    public class Cuadrilatero : Figura
    {
        public double Base {get; set;}
        public double Altura {get; set;}
        public override double Area()
        {
            return Base * Altura;
        }

        public override double Perimetro()
        {
            return 0.00;
        }
    }

    // Cuadrado hereda de Cuadrilatero
    public class Cuadrado : Cuadrilatero, IFigura
    {
        public double Lado {get; set;}
        public Cuadrado(double Lado)
        {
            this.Lado = Lado;
        }
        public override double Area()
        {
            return Math.Pow(Lado, 2);
        }

        public override double Perimetro()
        {
            return 4 * Lado;
        }

        public string QuienSoy()
        {
            return "Soy un cuadrado";
        }
    }
}