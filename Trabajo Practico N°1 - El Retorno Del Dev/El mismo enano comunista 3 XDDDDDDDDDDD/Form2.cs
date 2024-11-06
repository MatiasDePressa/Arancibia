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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow fila = dataGridView1.SelectedRows[0];
                    if (fila.Cells["Id"].Value != null)
                    {
                        int selectedId = int.Parse(fila.Cells["Id"].Value.ToString());
                        Categoria categoria = RepositorioCategorias.categorias.FirstOrDefault(c => c.Id == selectedId);

                        if (categoria != null)
                        {
                            textID.Text = categoria.Id.ToString();
                            textNombre.Text = categoria.Nombre;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos de la categoría: {ex.Message}");
            }
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

            if (RepositorioCategorias.categorias != null && RepositorioCategorias.categorias.Count > 0)
            {
                dataGridView1.DataSource = RepositorioCategorias.categorias;
            }
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
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow fila = dataGridView1.SelectedRows[0];
                    int indice = RepositorioCategorias.categorias.FindIndex(c => c.Id == int.Parse(fila.Cells["Id"].Value.ToString()));

                    if (indice >= 0)
                    {
                        Categoria categoriaModificar = RepositorioCategorias.categorias[indice];

                        categoriaModificar.Nombre = textNombre.Text;

                        RepositorioCategorias.categorias[indice] = categoriaModificar;

                        // Actualizar el DataGridView
                        CargarDatosEnDataGridView();
                        formPrincipal.ActualizarComboBoxCategorias();

                        textID.Clear();
                        textNombre.Clear();

                        MessageBox.Show("Categoría actualizada con éxito.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar la categoría: {ex.Message}");
            }
        }


        private void buttonEliminarC_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow fila = dataGridView1.SelectedRows[0];
                    int selectedId = int.Parse(fila.Cells["Id"].Value.ToString());

                    Categoria categoriaParaEliminar = RepositorioCategorias.categorias.FirstOrDefault(c => c.Id == selectedId);

                    if (categoriaParaEliminar != null)
                    {
                        RepositorioCategorias.categorias.Remove(categoriaParaEliminar);

                        // Actualizar el DataGridView
                        CargarDatosEnDataGridView();
                        formPrincipal.ActualizarComboBoxCategorias();

                        textID.Clear();
                        textNombre.Clear();

                        MessageBox.Show($"Categoría eliminada:\nid: {selectedId}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar la categoría: {ex.Message}");
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