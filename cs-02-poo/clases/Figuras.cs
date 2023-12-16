namespace Figuras
{
    public abstract class Figura
    {
        public abstract double Perimetro();
        public abstract double Area();
    }

    public interface IFigura
    {
        public string QuienSoy();
    }
}