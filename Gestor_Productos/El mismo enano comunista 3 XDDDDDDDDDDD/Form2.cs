using System;
using System.Linq;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


//si vas a codear, vos no podes minar codigo plano, porque despues dicen que lo hiciste con IA
//vos lo tenes que trabajar con lo mas recondito de tu cerebro, y si es posible con las neuro-autistas,
//bien autista. y ahi lo reventas a excepciones, le metes todos los trys, no uno porque vas a
//ser senior programmer y te vas a comer un garron de la gran flauta.
//vos estabas en un estado de programacion violenta y de locura, lo reventaste a ifs, lo debugueaste,
//lo compilas, para demostrar tu estado de locura e inconciencia temporal. ¿me explico?
//Ademas tenes que tener un cafe a mano, te lo tomas y si tenes una speed encima mandale y lo mandas
//a produccion asi...
//Sos inimputable hermano, en 10 dias sos freelancer
namespace El_mismo_enano_comunista_3_XDDDDDDDDDDD
{
    public partial class Form2 : Form
    {
        private Form1 formPrincipal;

        //conecta el form1 con el 2 para poder mandarle las categorias al comboBox
        //*sonido de persona palideciendo de la sorpresa*
        public Form2(Form1 formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }

    //FUNCIONES DE VALIDACION:

        //valida el id como entero y el nombre como texto
        //nada mas
        //absolutamente nada mas
        //o...
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

        //si se trate de colocar texto en el id lo evita
        //cuchau
        private void textID_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textID.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor, ingrese solo números enteros.");
                textID.Text = textID.Text.Remove(textID.Text.Length - 1);
            }
        }

    //FUNCIONES LOGICAS:

        //lo mismo que en el anterior form, me permite seleccionar una fila
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

        //carga los datos en el grid
        //no lo dije en el otro form pero ese if es el pilar de toda la parte de seleccion
        //basicamente evita que el codigo explote, que haga PUM, que implosione
        //y tambien es lo que me ayuda a dormir por las noches
        //me arropa, me prepara una chocolatada y me lee un cuento
        //es mi figura paterna ese if 
        private void CargarDatosEnDataGridView()
        {
            dataGridView1.DataSource = null;

            if (RepositorioCategorias.categorias != null && RepositorioCategorias.categorias.Count > 0)
            {
                dataGridView1.DataSource = RepositorioCategorias.categorias;
            }
        }

        //carga el grid junto con el form, caching
        private void Form2_Load(object sender, EventArgs e)
        {
            CargarDatosEnDataGridView();
        }

    //FUNCIONES PARA LOS BOTONES:

        //funcionan exactamente igual a los botones del otro form
        //pero cuando digo exactamente, me refiero a que hice el mejor copia pega de mi exitencia
        //considero que no hay mejor copia y pega que el que hice pero bueno
        //si quieren saber:
        //tomo los datos de los textBox
        //creo un objeto Categoria con esos datos
        //lo cargo a la lista
        //limpio los textBox
        //actualizo el comboBox del form1
        //cargo la tabla de este form
        //y mando un mensaje de que todo anda bien
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


        //ya explique como se edita en el otro boton (en el del form1)
        //seamos personas razonables y no me hagan escribir de mas que me quiero ir a dormir
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

        //lo mismo para este boton, si tienen alguna queja
        //ahi hay un libro de quejas que jamas leere
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

        //cierra el form2
        //esto me costo un monton
        //tuve que pedirle ayuda a Elon Musk porque no podia
        //a el tambien se le complico asi que llamamos a Mark Zuckerberg que tampoco pudo
        //finalmente con los equipos de meta y tesla trabajando al mismo tiempo con aplle, nvidia
        //intel, amd, OpenIA, y linux logramos resolverlo
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}