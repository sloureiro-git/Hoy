using Datos;
using Entidades;

namespace Negocio
{
    public class LogicaLibro : ILogicaVehiculo
    {
        PersistenciaLibro AccesoPersistencia = new PersistenciaLibro();
        public void AñadirLibro(Libro AñadirLibro)
        {
            AccesoPersistencia.ListaLibros.Add(AñadirLibro);
        }

        public void ModificarLibro(Libro ModificarLibro)
        {
            for (int i = 0; i < AccesoPersistencia.ListaLibros.Count; i++)
            {
                if (AccesoPersistencia.ListaLibros[i].Id.Equals(ModificarLibro.Id))
                {
                    AccesoPersistencia.ListaLibros[i].Nombre = ModificarLibro.Nombre;
                    AccesoPersistencia.ListaLibros[i].Autor = ModificarLibro.Autor;
                    AccesoPersistencia.ListaLibros[i].Año = ModificarLibro.Año;
                }
            }
        }

        public void EliminarLibro(Libro EliminarLibro)
        {
            for (int i = 0; i < AccesoPersistencia.ListaLibros.Count; i++)
            {
                if (AccesoPersistencia.ListaLibros[i].Id.Equals(EliminarLibro.Id))
                {
                    AccesoPersistencia.ListaLibros.Remove(AccesoPersistencia.ListaLibros[i]);
                }
            }
        }
        public List<Libro> ObtenerLibros()
        {
            return AccesoPersistencia.ListaLibros;
        }



    }
}
