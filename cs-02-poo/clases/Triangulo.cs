using Figuras;

namespace Triangulos
{
    // el operador : equivale tanto a extends como a implements de otros lenguajes
    public class Triangulo : Figura, IFigura
    {
        public double Base {get; set;}
        public double Altura {get; set;}
        public double Lado01 {get; set;}
        public double Lado02 {get; set;}
        public Triangulo(double Base, double Altura, double Lado01, double Lado02)
        {
            this.Base = Base;
            this.Altura = Altura;
            this.Lado01 = Lado01;
            this.Lado02 = Lado02;
        }
        public override double Area()
        {
            return Base * Altura/2;
        }

        public override double Perimetro()
        {
            return Lado01 + Lado02 + Base;
        }

        public string QuienSoy()
        {
            return "Soy un triángulo";
        }
    }
}