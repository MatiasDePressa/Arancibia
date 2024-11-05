using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_mismo_enano_comunista_3_XDDDDDDDDDDD
{
    public class Producto
    {
        public int id { get; set; }
        public decimal precio { get; set; }
        public string descripcion { get; set; }

        public Producto(int id, decimal precio, string descripcion)
        {
            this.id = id;
            this.precio = precio;
            this.descripcion = descripcion;
        }
    }



    public static class RepositorioGlobal
    {
        public static List<Producto> repositorio = new List<Producto>();
    }

}
