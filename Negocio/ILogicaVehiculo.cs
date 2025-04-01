using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Negocio
{
    internal interface ILogicaVehiculo
    {

        public void AñadirLibro(Libro Añadir);
        public void ModificarLibro(Libro Modificar);
        public void EliminarLibro(Libro Eliminar);
        public List<Libro> ObtenerLibros();



    }
}
