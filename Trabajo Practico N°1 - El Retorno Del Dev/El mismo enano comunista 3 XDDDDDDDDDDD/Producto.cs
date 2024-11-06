using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_mismo_enano_comunista_3_XDDDDDDDDDDD
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Categoria(int id, string nombre)
        {
            this.Id = id;
            this.Nombre = nombre;
        }

        public override string ToString()
        {
            return this.Nombre;
        }
    }

    public class Producto
    {
        public int id { get; set; }
        public decimal precio { get; set; }
        public string descripcion { get; set; }
        public Categoria Categoria { get; set; }

        public Producto(int id, decimal precio, string descripcion, Categoria categoria)
        {
            this.id = id;
            this.precio = precio;
            this.descripcion = descripcion;
            this.Categoria = categoria;
        }
    }

    public static class RepositorioGlobal
    {
        public static List<Producto> repositorio = new List<Producto>();
    }

    public static class RepositorioCategorias
    {
        public static List<Categoria> categorias = new List<Categoria>();
    }

}
