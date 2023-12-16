namespace Clases
{
    public class Empleado
    {
        public string Nombre {get; set;}
        public int Edad {get; set;}
        public string CodDpto {get; set;}
        public int Salario {get; set;}

        public Empleado(string Nombre, int Edad, string CodDpto, int Salario)
        {
            this.Nombre = Nombre;
            this.Edad = Edad;
            this.CodDpto = CodDpto;
            this.Salario = Salario;
        }
    }

    public class Departamento
    {
        public string CodDpto {get; set;}
        public string DescrDpto {get; set;}

        public Departamento(string CodDpto, string DescrDpto)
        {
            this.CodDpto = CodDpto;
            this.DescrDpto = DescrDpto;
        }
    }
}