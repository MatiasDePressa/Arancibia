using System;
using System.Linq;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace El_mismo_enano_comunista_3_XDDDDDDDDDDD
{
    public partial class Form2 : Form
    {
        private Form1 formPrincipal;

        public Form2(Form1 formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }

        private bool ValidarCategoria()
        {
            if (string.IsNullOrWhiteSpace(textID.Text) || !int.TryParse(textID.Text, out _))
            {
                MessageBox.Show("ID inválido. Debe ser un número entero.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(textNombre.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío.");
                return false;
            }
            return true;
        }

        private void textID_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textID.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor, ingrese solo números enteros.");
                textID.Text = textID.Text.Remove(textID.Text.Length - 1);
            }
        }

        private void CargarDatosEnDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = RepositorioCategorias.categorias;
        }


        private void buttonCategoriaC_Click(object sender, EventArgs e)
        {
            try
            {

                if (!ValidarCategoria()) 
                { 
                    return;
                }

                int id = int.Parse(textID.Text);
                string nombre = textNombre.Text;

                Categoria nuevaCategoria = new Categoria(id, nombre);
                RepositorioCategorias.categorias.Add(nuevaCategoria);

                textID.Clear();
                textNombre.Clear();

                formPrincipal.ActualizarComboBoxCategorias();
                CargarDatosEnDataGridView();

                MessageBox.Show("Categoría agregada con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la categoría");
            }
        }

        private void buttonEditarC_Click(object sender, EventArgs e)
        {
            try
            {

                if (!ValidarCategoria())
                {
                    return;
                }

                int id = int.Parse(textID.Text);
                Categoria categoria = RepositorioCategorias.categorias.FirstOrDefault(c => c.Id == id);

                if (categoria != null)
                {
                    categoria.Nombre = textNombre.Text;

                    formPrincipal.ActualizarComboBoxCategorias();
                    CargarDatosEnDataGridView();

                    MessageBox.Show("Categoría editada con éxito.");
                }
                else
                {
                    MessageBox.Show("Categoría no encontrada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar la categoría");
            }
        }

        private void buttonEliminarC_Click(object sender, EventArgs e)
        {
            try
            {

                if (!ValidarCategoria())
                {
                    return;
                }

                int id = int.Parse(textID.Text);
                Categoria categoria = RepositorioCategorias.categorias.FirstOrDefault(c => c.Id == id);

                if (categoria != null)
                {
                    RepositorioCategorias.categorias.Remove(categoria);
                    formPrincipal.ActualizarComboBoxCategorias();
                    CargarDatosEnDataGridView();

                    MessageBox.Show("Categoría eliminada con éxito.");
                }
                else
                {
                    MessageBox.Show("Categoría no encontrada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la categoría");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CargarDatosEnDataGridView();
        }

    }
}