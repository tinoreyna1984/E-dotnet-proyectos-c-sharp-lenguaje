﻿using System;
using Clases;

// deshabilita warnings molestosos
#pragma warning disable IDE0060
#pragma warning disable IDE0079
#pragma warning disable IDE0090
#pragma warning disable IDE0057
#pragma warning disable IDE0028
#pragma warning disable SYSLIB1045

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Departamento> dptos = new List<Departamento>()
            {
                new Departamento("RRPP", "Relaciones públicas"),
                new Departamento("VTAS", "Ventas"),
                new Departamento("TI", "Sistemas y TI"),
                new Departamento("RRHH", "Recursos humanos"),
            };
            List<Empleado> empleados = new List<Empleado>()
            {
                new Empleado("Tino Reyna", 39, "TI", 5000),
                new Empleado("Luisa Marcano", 25, "VTAS", 3200),
                new Empleado("Jorge Prado", 39, "RRHH", 4100),
                new Empleado("Carla Torres", 23, "TI", 2200),
                new Empleado("Arturo Cuadros", 35, "TI", 5000),
                new Empleado("Julio Sanchez", 27, "VTAS", 3200),
                new Empleado("Mariana Cevallos", 31, "RRHH", 4300),
            };

            // 1- Filtrado LINQ funcional
            List<Empleado> sistemas = empleados.Where(emp => emp.CodDpto.Equals("TI")).ToList();
            foreach (var emp in sistemas)
            {
                Console.WriteLine("Empleado: " + emp.Nombre + ", dpto: " + emp.CodDpto + ", edad: " + emp.Edad);
            }

            // 2- Filtrado LINQ con lenguaje
            var dptosConR = from dpto in dptos
                            where dpto.CodDpto.StartsWith('R')
                            select dpto;
            foreach (var dpto in dptosConR)
            {
                Console.WriteLine(dpto.DescrDpto);
            }

            // 3- Join
            var empDptos = from emp in empleados
                            join dpto in dptos
                            on emp.CodDpto equals dpto.CodDpto
                            select new {
                                NombreEmp = emp.Nombre,
                                Dpto = dpto.DescrDpto
                            };
            foreach (var emp in empDptos)
            {
                Console.WriteLine("Nombre: " + emp.NombreEmp + ", Departamento: " + emp.Dpto);
            }
        }
    }
}