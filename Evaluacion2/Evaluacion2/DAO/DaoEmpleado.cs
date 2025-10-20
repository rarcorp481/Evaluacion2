using Evaluacion2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion2.DAO
{
    public class PilaEmpleados
    {
        private Stack<Empleado> pila = new Stack<Empleado>();

        public void Agregar(Empleado empleado)
        {
            pila.Push(empleado);
        }

        public Empleado Eliminar()
        {
            return pila.Count > 0 ? pila.Pop() : null;
        }

        public Empleado VerTope()
        {
            return pila.Count > 0 ? pila.Peek() : null;
        }

        public List<string> ObtenerContenido()
        {
            return pila.Select(e => e.ToString()).ToList();
        }
    }
}
