using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Entidades
{
    public class Libro
    {
        private string _id;
        private string _nombre;
        private string _autor;
        private int _año;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Autor
        {
            get { return _autor; }
            set { _autor = value; }
        }
        public int Año
        {
            get { return _año; }
            set { _año = value; }
        }

        public string Display
        {
            get { return Id+", "+Nombre+", "+Autor+", "+Año; }
        }

        public Libro(string id, string nombre, string autor, int año)
        {
            Id = id;
            Nombre = nombre;
            Autor = autor;
            Año = año;
        }

        public Libro()
        {
            Id = "";
            Nombre = "";
            Autor = "";
            Año = 0;
        }
    }
}
