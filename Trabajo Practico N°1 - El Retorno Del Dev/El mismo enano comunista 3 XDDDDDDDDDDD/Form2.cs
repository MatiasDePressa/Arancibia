using System;
using System.Linq;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace El_mismo_enano_comunista_3_XDDDDDDDDDDD
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            try
            {
                InitializeComponent();
            }
            catch
            {
                MessageBox.Show("Error al conectar con el formulario principal");
            }
        }

        private void buttonCategoriaC_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textID.Text);
                string nombre = textNombre.Text;

                Categoria nuevaCategoria = new Categoria(id, nombre);
                RepositorioCategorias.categorias.Add(nuevaCategoria);

                textID.Clear();
                textNombre.Clear();

                MessageBox.Show("Categoría agregada con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la categoría: " + ex.Message);
            }
        }

        private void buttonEditarC_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textID.Text);
                Categoria categoria = RepositorioCategorias.categorias.FirstOrDefault(c => c.Id == id);

                if (categoria != null)
                {
                    categoria.Nombre = textNombre.Text;

                    MessageBox.Show("Categoría editada con éxito.");
                }
                else
                {
                    MessageBox.Show("Categoría no encontrada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar la categoría: " + ex.Message);
            }
        }

        private void buttonEliminarC_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textID.Text);
                Categoria categoria = RepositorioCategorias.categorias.FirstOrDefault(c => c.Id == id);

                if (categoria != null)
                {
                    RepositorioCategorias.categorias.Remove(categoria);

                    MessageBox.Show("Categoría eliminada con éxito.");
                }
                else
                {
                    MessageBox.Show("Categoría no encontrada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la categoría: " + ex.Message);
            }
        }
    }
}


