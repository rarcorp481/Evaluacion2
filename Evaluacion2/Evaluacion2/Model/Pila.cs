using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evaluacion2.DAO;
using Evaluacion2.Model;

namespace Evaluacion2.Model
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }

        public Empleado(string nombre, string apellido, string cargo, decimal salario)
        {
            Nombre = nombre;
            Apellido = apellido;
            Cargo = cargo;
            Salario = salario;
        }

        public string NombreCompleto()
        {
            return $"{Nombre} {Apellido}";
        }

        public override string ToString()
        {
            return $"{NombreCompleto()} - {Cargo} - ${Salario}";
        }
    }
}
