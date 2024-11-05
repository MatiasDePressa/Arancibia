using System.Windows.Forms;

namespace El_mismo_enano_comunista_3_XDDDDDDDDDDD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CargarDatosEnDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = RepositorioGlobal.repositorio;
        }

        // Método para validar los datos del producto
        private bool ValidarProducto()
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text) || !int.TryParse(textBox3.Text, out _))
            {
                MessageBox.Show("id inválido. Debe ser un número.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text) || !decimal.TryParse(textBox2.Text, out _))
            {
                MessageBox.Show("Precio inválido. Debe ser un número decimal.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Descripción no puede estar vacía.");
                return false;
            }
            return true;
        }

        // Método para validar solo números en el TextBox de id
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor, ingrese solo números.");
                textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1);
            }
        }

        // Método para validar solo decimales en el TextBox de Precio
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9.]"))
            {
                MessageBox.Show("Por favor, ingrese solo números decimales.");
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
            }
        }

        private void ActualizarProducto()
        {
            try
            {
                int id = int.Parse(textBox3.Text);
                Producto producto = RepositorioGlobal.repositorio.FirstOrDefault(p => p.id == id);

                if (producto != null)
                {
                    producto.precio = decimal.Parse(textBox2.Text);
                    producto.descripcion = textBox1.Text;

                    // Actualizar DataGridView
                    CargarDatosEnDataGridView();
                }
            }
            catch
            {
                MessageBox.Show("Error Funcion Actualizar");
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Boton Presionado");
            try
            {
                if (!ValidarProducto())
                {
                    return;
                }

                int id = int.Parse(textBox3.Text);
                decimal precio = decimal.Parse(textBox2.Text);
                string descripcion = textBox1.Text;

                Producto nuevoProducto = new Producto(id, precio, descripcion);

                RepositorioGlobal.repositorio.Add(nuevoProducto);

                MessageBox.Show($"Producto generado:\nid: {id}\nPrecio: {precio}\nDescripción: {descripcion}");

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();

                // Actualizar DataGridView
                CargarDatosEnDataGridView();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Por favor, ingresa valores válidos en todos los campos.");
            }
        }


        private void buttonEditar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Boton Presionado");

            try
            {
                if (!ValidarProducto())
                {
                    return;
                }

                int id = int.Parse(textBox3.Text);
                Producto producto = RepositorioGlobal.repositorio.FirstOrDefault(p => p.id == id);

                if (producto != null)
                {
                    producto.precio = decimal.Parse(textBox2.Text);
                    producto.descripcion = textBox1.Text;

                    MessageBox.Show($"Producto actualizado:\nid: {producto.id}\nPrecio: {producto.precio}\nDescripción: {producto.descripcion}");

                    // Actualizar DataGridView
                    CargarDatosEnDataGridView();

                    // Limpiar TextBoxes
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                }
                else
                {
                    MessageBox.Show("Error Boton Editar, producto no encontrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Boton Editar: {ex.Message}");
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Boton Presionado");
                int id = int.Parse(textBox4.Text);
                Producto producto = RepositorioGlobal.repositorio.FirstOrDefault(p => p.id == id);

                if (producto != null)
                {
                    label4.Text = $"Producto encontrado:\nid: {producto.id}\nPrecio: {producto.precio}\nDescripción: {producto.descripcion}";
                }
                else
                {
                    label4.Text = "Producto no encontrado.";
                }
            }
            catch
            {
                MessageBox.Show("Error al Buscar un Producto");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Boton Presionado");

            try
            {
                int id = int.Parse(textBox3.Text);
                Producto producto = RepositorioGlobal.repositorio.FirstOrDefault(p => p.id == id);

                if (producto != null)
                {
                    RepositorioGlobal.repositorio.Remove(producto);

                    MessageBox.Show($"Producto eliminado:\nid: {id}");

                    // Actualizar DataGridView
                    CargarDatosEnDataGridView();

                    // Limpiar TextBoxes
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                }
                else
                {
                    MessageBox.Show("Error Boton Eliminar, producto no encontrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Boton Eliminar: {ex.Message}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDatosEnDataGridView();
        }

    }
}
