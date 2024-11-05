using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_mismo_enano_comunista_3_XDDDDDDDDDDD
{
    public class Categoria
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public Categoria(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
    }

    public class Producto
    {
        public int id { get; set; }
        public decimal precio { get; set; }
        public string descripcion { get; set; }
        //public Categoria Categoria { get; set; }

        public Producto(int id, decimal precio, string descripcion)//, Categoria categoria)
        {
            this.id = id;
            this.precio = precio;
            this.descripcion = descripcion;
            //Categoria = categoria;
        }
    }

    public static class RepositorioGlobal
    {
        public static List<Producto> repositorio = new List<Producto>();
    }

}
