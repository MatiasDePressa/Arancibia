using System.Windows.Forms;

//hay 5.000.000 de trys mas que nada para aquellos usuarios que sean
//"especiales". Ahora si quiere saber por que el nombre del proyecto es tan curioso
//visite https://www.youtube.com/watch?v=eFE8NOD4qlE&t=0s
//en los primero 15 segundos del video esta el lore
//que vuelva chusommontero
//voy a armar una campaña de kickstarted para que vuelva el no hiter
//chuso te extrañamos, gracias por tanto, perdon por tan poco :,(
namespace El_mismo_enano_comunista_3_XDDDDDDDDDDD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Carga de datos en el datagridview
        //si ya existen datos en el grid los elimina para evitar que se muestre la lista nueva 
        //y la lista anterior al mismo tiempo
        //se podria haber llamado actualizar grid y daba lo mismo
        //muchos errores en tan poco tiempo me estan quitando años de vida
        //solo quiero mi titulo
        //y una bebida de cebada y lupulo fermentado
        //(se me murio el 50% del cerebro pensando en porque no funcionaba la carga)
        private void CargarDatosEnDataGridView()
        {
            dataGridView1.DataSource = null;

            if (RepositorioGlobal.repositorio != null && RepositorioGlobal.repositorio.Count > 0)
            {
                dataGridView1.DataSource = RepositorioGlobal.repositorio;
                DataGridViewRow fila = dataGridView1.SelectedRows[0];
                int indice = RepositorioGlobal.repositorio.FindIndex(p => p.id == int.Parse(fila.Cells["id"].Value.ToString()));


                //textBox2.Text = producto.precio.ToString();
                //textBox1.Text = producto.descripcion;
                //textBox6.SelectedItem = producto.Categoria;
            }
        }

        //private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //       if (dataGridView1.Rows.Count > 0 && dataGridView1.SelectedRows.Count > 0)
        //       {
        //           if (dataGridView1.SelectedRows[0].Index >= 0) // Verifica que la fila seleccionada es válida
        //           {
        //               int selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
        //               Producto producto = RepositorioGlobal.repositorio.FirstOrDefault(p => p.id == selectedId);
        //
        //               if (producto != null)
        //               {
        //                   textBox3.Text = producto.id.ToString();
        //                   textBox2.Text = producto.precio.ToString();
        //                   textBox1.Text = producto.descripcion;
        //                   textBox6.SelectedItem = producto.Categoria;
        //               }
        //           }
        //       }
        //    }
        //    catch
        //    {
        //        MessageBox.Show("no se como llamar a este error porfavor que alguien me mate llevo 9 codeando");
        //    }
        //}

        // basicamente toma la lista de las categorias y la muestra en el combo box
        // antiguamente lo estuve haciendo con una llamada desde el form2
        //pero me pare a pensar y dije: "mati, tenes una lista con las categorias
        //¿porque %&(@#$= no mostras la lista y punto?"
        //asi que solo carga la lista a la combobox y lo actualiza
        public void ActualizarComboBoxCategorias()
        {
            textBox6.DataSource = null;
            textBox6.DataSource = RepositorioCategorias.categorias;
            textBox6.DisplayMember = "Nombre";
            textBox6.ValueMember = "Id";
        }


        //validar los datos del producto (no estoy orgulloso de esta funcion, pero al menos funciona)
        //dato curioso es solo una segunda barrera en caso de que la validacion por teclas no ande
        //y para la descripcion que no tiene validacion como tal
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

        //validar solo números en el TextBox de id
        //lo hago mediante una llamada cada vez que cambia el texto
        //evita que cierto tipó de usuarios coloquen lo que quieran cuando quieran
        //esta bastante facherazo *chasquidos*
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor, ingrese solo números.");
                textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1);
            }
        }

        //validar solo decimales en el TextBox de Precio
        //lo mismo de arriba solo que para el precio
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9.]"))
            {
                MessageBox.Show("Por favor, ingrese solo números decimales.");
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
            }
        }

        //agregar un producto a la lista
        //no tiene mucha logica, toma los datos de los textbox, crea un objeto Producto,
        //lo almacena en la lista y lo muestra en el grid
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarProducto())
                {
                    return;
                }

                int id = int.Parse(textBox3.Text);
                decimal precio = decimal.Parse(textBox2.Text);
                string descripcion = textBox1.Text;
                Categoria categoriaSeleccionada = textBox6.SelectedItem as Categoria;

                Producto nuevoProducto = new Producto(id, precio, descripcion, categoriaSeleccionada);

                RepositorioGlobal.repositorio.Add(nuevoProducto);

                MessageBox.Show($"Producto generado:\nid: {id}\nPrecio: {precio}\nDescripción: {descripcion}\nCategoría: {categoriaSeleccionada.Nombre}");

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox6.SelectedIndex = -1;

                CargarDatosEnDataGridView();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Por favor, ingresa valores válidos en todos los campos.");
            }
        }

        //la logica es la misma que en la del boton agregar 
        //solo que busca el id en la lista y sobreescribe los datos del precio y de la descripcion
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dataGridView1.SelectedRows[0];
                Producto productoParaEditar = RepositorioGlobal.repositorio.FirstOrDefault(p => p.id == int.Parse(fila.Cells["id"].Value.ToString()));

                if (productoParaEditar != null)
                {
                    // 2. Actualizar el Producto
                    productoParaEditar.precio = decimal.Parse(textBox2.Text);
                    productoParaEditar.descripcion = textBox1.Text;
                    productoParaEditar.Categoria = textBox6.SelectedItem as Categoria;

                    MessageBox.Show($"Producto actualizado:\nid: {productoParaEditar.id}");

                    // Actualizar el DataGridView
                    CargarDatosEnDataGridView();
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para editar.");
            }
        }



        //recorre la lista, encuentra el id, si lo encuentra: agarra los datos y los muestra en el
        //label, si no los encuentra: te dice "no manin, tu no estas en la lista no te puedo dejar
        //pasar. por favor sea respetuoso, esta noche tenemos fiesta privada y el local esta cerrado
        //al publico general, le voy a pedir amablemente que se retire que esta demorando el ingreso
        //de las personas que si han sido invitadas. sino se va tendre que llamar a la guardia civil
        //para que se lo lleven, asi que por favor vaya marchando"
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox4.Text);
                Producto producto = RepositorioGlobal.repositorio.FirstOrDefault(p => p.id == id);

                if (producto != null)
                {
                    label4.Text = $"Producto encontrado:\nid: {producto.id}\nPrecio: {producto.precio}\nDescripción: {producto.descripcion},\nCategoria: {producto.Categoria.Nombre}";
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


        //tiene la misma logica, busca el id y lo manda a volar, aqui no hace falta que se le 
        //coloque nada en el precio o la descripcion, mas que nada porque es totalmente useless
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dataGridView1.SelectedRows[0];
                Producto productoParaEliminar = RepositorioGlobal.repositorio.FirstOrDefault(p => p.id == int.Parse(fila.Cells["id"].Value.ToString()));

                if (productoParaEliminar != null)
                {
                    // 2. Eliminar el Producto
                    RepositorioGlobal.repositorio.Remove(productoParaEliminar);

                    MessageBox.Show($"Producto eliminado:\nid: {productoParaEliminar.id}");

                    // Actualizar el DataGridView
                    CargarDatosEnDataGridView();
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para eliminar.");
            }
        }

        //al cargar el formulario tambien carga el grid y actualixa el selected de las categorias
        //es mas que nada para hacer limpieza del sistema, evitar errores y actualizaciones
        //maybe no es lo mejor pero funca
        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDatosEnDataGridView();
            ActualizarComboBoxCategorias();
        }


        //carga el formulario de las categorias
        //no es ingenieria cuantica, simplemente crea un objeto de form2 y lo carga
        private void irACategoria_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 form2 = new Form2(this);
                form2.Show();
            }
            catch
            {
                MessageBox.Show("No se pudo conectar con el Form2");
            }
        }

    }
}
