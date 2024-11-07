using Gestion_seguro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//como se nota cuando uno esta de humor para programar, este archivo es MUCHO mas prolijo que el anterior
namespace Gestion_seguro
{
    public partial class Form1 : Form
    {
        //inicializa todo y oculta el label y el textBox de los valores
        public Form1()
        {
            InitializeComponent();
            label_total.Visible = false;
            text_total.Visible = false;
            InicializarDataGridView();
        }

        //actualiza el dataGridView
        //basicamente elimina todo y lo vuelve a cargar
        private void ActualizarVistaSeguros()
        {
            vista_seguros.Rows.Clear();
            foreach (var seguro in RepositorioGlobal.repositorio)
            {
                vista_seguros.Rows.Add(seguro.Id, seguro.PrecioMensual, seguro.SumaAsegurada, seguro.Descripcion);
            }
        }

        //inicializa las columnas con un indice
        private void InicializarDataGridView()
        {
            vista_seguros.ColumnCount = 4;
            vista_seguros.Columns[0].Name = "ID";
            vista_seguros.Columns[1].Name = "Precio Mensual";
            vista_seguros.Columns[2].Name = "Suma Asegurada";
            vista_seguros.Columns[3].Name = "Descripción";
        }

        //limpia las textBox
        private void LimpiarTextBoxes()
        {
            text_id.Clear();
            text_precio.Clear();
            text_suma.Clear();
            text_descripcion.Clear();
            text_total.Clear();
        }

        //Validacion de datos por si pasan el filtro de los inputs
        private bool Validar_Datos()
        {
            if (string.IsNullOrWhiteSpace(text_id.Text) || !int.TryParse(text_id.Text, out _))
            {
                MessageBox.Show("El ID debe ser un número entero.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(text_precio.Text) || !decimal.TryParse(text_precio.Text, out decimal precioMensual) || precioMensual >= 300000)
            {
                MessageBox.Show("El precio mensual debe ser un número decimal y menor a 300,000.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(text_suma.Text) || !decimal.TryParse(text_suma.Text, out decimal sumaAsegurada) || sumaAsegurada > 3000000)
            {
                MessageBox.Show("La suma asegurada debe ser un número decimal y no mayor a 3,000,000.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(text_descripcion.Text) || decimal.TryParse(text_descripcion.Text, out _))
            {
                MessageBox.Show("La descripción no puede estar vacía ni debe ser un número.");
                return false;
            }
            return true;
        }

        //el filtro de los inputs del id
        private void text_id_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(text_id.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor, ingrese solo números enteros.");
                text_id.Text = text_id.Text.Remove(text_id.Text.Length - 1);
            }
        }

        //el filtro de los inputs del precio
        private void text_precio_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(text_precio.Text, "[^0-9.]"))
            {
                MessageBox.Show("Por favor, ingrese solo números decimales.");
                text_precio.Text = text_precio.Text.Remove(text_precio.Text.Length - 1);
            }
        }

        //el filtro de los inputs de la suma
        private void text_suma_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(text_suma.Text, "[^0-9.]"))
            {
                MessageBox.Show("Por favor, ingrese solo números decimales.");
                text_suma.Text = text_suma.Text.Remove(text_suma.Text.Length - 1);
            }
        }

        //es para que al seleccionar una fila de la tabla cargue todo a los textBox
        private void vista_seguros_SelectionChanged(object sender, EventArgs e)
        {
            if (vista_seguros.SelectedRows.Count > 0)
            {
                var row = vista_seguros.SelectedRows[0];
                text_id.Text = row.Cells["ID"].Value.ToString();
                text_precio.Text = row.Cells["Precio Mensual"].Value.ToString();
                text_suma.Text = row.Cells["Suma Asegurada"].Value.ToString();
                text_descripcion.Text = row.Cells["Descripción"].Value.ToString();
            }
        }

        //al precionar el boton de generar, toma los datos de los textbox
        //los valida
        //los guarda
        //y dependiendo de que radio este seleccionado va a mostar o no el valor total
        private void button_generar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validar_Datos())
                {
                    return;
                }

                int id = int.Parse(text_id.Text);
                string descripcion = text_descripcion.Text;
                decimal sumaAsegurada = decimal.Parse(text_suma.Text);
                decimal precioMensual = decimal.Parse(text_precio.Text);
                Seguro seguro = null;

                if (radio_riesgo.Checked)
                {
                    label_total.Visible = true;
                    text_total.Visible = true;
                    seguro = new TodoRiesgo(id, precioMensual, sumaAsegurada, descripcion);
                    text_total.Text = ((TodoRiesgo)seguro).ValorFranquicia.ToString("C");
                }
                else if (radio_terceros.Checked)
                {
                    label_total.Visible = false;
                    text_total.Visible = false;
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }

        //hace lo mismo que el boton de generar solo que este guarda el objeto en la lista
        private void button_guardar_Click(object sender, EventArgs e)
        {
            try
            {

                if (!Validar_Datos())
                {
                    return;
                }

                int id = int.Parse(text_id.Text);
                string descripcion = text_descripcion.Text;
                decimal sumaAsegurada = decimal.Parse(text_suma.Text);
                decimal precioMensual = decimal.Parse(text_precio.Text);
                Seguro seguro = null;

                if (radio_riesgo.Checked)
                {
                    label_total.Visible = true;
                    text_total.Visible = true;
                    seguro = new TodoRiesgo(id, precioMensual, sumaAsegurada, descripcion);
                }
                else if (radio_terceros.Checked)
                {
                    label_total.Visible = false;
                    text_total.Visible = false;
                    seguro = new Terceros(id, precioMensual, sumaAsegurada, descripcion);
                }

                if (seguro != null)
                {
                    RepositorioGlobal.repositorio.Add(seguro);
                    ActualizarVistaSeguros();
                }

                LimpiarTextBoxes();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores válidos en todos los campos.");
            }
        }


        //recorre la lista encuentra el id del objeto seleccionado y modifica el objeto con los nuevos
        //valores
        private void button_editar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(text_id.Text);
            var seguro = RepositorioGlobal.repositorio.FirstOrDefault(s => s.Id == id);

            if (seguro != null)
            {
                seguro.PrecioMensual = decimal.Parse(text_precio.Text);
                seguro.SumaAsegurada = decimal.Parse(text_suma.Text);
                seguro.Descripcion = text_descripcion.Text;
                ActualizarVistaSeguros();
            }
            else
            {
                MessageBox.Show("No se encontró un objeto con el ID especificado.");
            }

            LimpiarTextBoxes();
        }

        //recorre la lista encuentra al objeto con el id y lo manda a Nueva Zelanda
        private void button_eliminar_Click(object sender, EventArgs e)
        {

            int id = int.Parse(text_id.Text);
            var seguro = RepositorioGlobal.repositorio.FirstOrDefault(s => s.Id == id);

            if (seguro != null)
            {
                RepositorioGlobal.repositorio.Remove(seguro);
                ActualizarVistaSeguros();
                LimpiarTextBoxes();
                MessageBox.Show("Objeto eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("No se encontró un objeto con el ID especificado.");
            }
        }
    }
}
