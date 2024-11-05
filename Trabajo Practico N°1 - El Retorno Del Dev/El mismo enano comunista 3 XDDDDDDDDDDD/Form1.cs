using System.Windows.Forms;

namespace El_mismo_enano_comunista_3_XDDDDDDDDDDD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Método para validar los datos del producto
        private bool ValidarProducto()
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text) || !int.TryParse(textBox3.Text, out _))
            {
                MessageBox.Show("ID inválido. Debe ser un número.");
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

        // Método para validar solo números en el TextBox de ID
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
                    dataGridView1.Refresh();
                }

            }
            catch
            {
                MessageBox.Show("Error Funcion Actualizar");
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            // Validaciones y creación del producto
            try
            {
                int id = int.Parse(textBox3.Text);
                decimal precio = decimal.Parse(textBox2.Text);
                string descripcion = textBox1.Text;

                Producto nuevoProducto = new Producto(id, precio, descripcion);

                // Añadir el producto al repositorio
                RepositorioGlobal.repositorio.Add(nuevoProducto);

                // Mostrar alerta
                MessageBox.Show($"Producto generado:\nID: {id}\nPrecio: {precio}\nDescripción: {descripcion}");

                // Limpiar TextBoxes
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Por favor, ingresa valores válidos en todos los campos.");
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                    Producto producto = RepositorioGlobal.repositorio.FirstOrDefault(p => p.id == id);

                    if (producto != null)
                    {
                        textBox3.Text = producto.id.ToString();
                        textBox2.Text = producto.precio.ToString();
                        textBox1.Text = producto.descripcion;
                    }
                    else
                    {
                        MessageBox.Show("Error Boton Editar, producto null");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error Boton Editar");
            }

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox4.Text);
            Producto producto = RepositorioGlobal.repositorio.FirstOrDefault(p => p.Id == id);
        
            if (producto != null)
            {
                label4.Text = $"Producto encontrado:\nID: {producto.id}\nPrecio: {producto.precio}\nDescripción: {producto.descripcion}";
            }
            else
            {
                label4.Text = "Producto no encontrado.";
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                Producto producto = RepositorioGlobal.repositorio.FirstOrDefault(p => p.id == id);

                if (producto != null)
                {
                    RepositorioGlobal.repositorio.Remove(producto);
                    // Actualizar DataGridView
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
                else
                {
                    MessageBox.Show("Error Boton Borrar, producto null");
                }
            }
        }

        // Otros manejadores de eventos de tu formulario
        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
