namespace Gestion_seguro
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_id = new System.Windows.Forms.Label();
            this.label_suma = new System.Windows.Forms.Label();
            this.label_descripcion = new System.Windows.Forms.Label();
            this.label_precio = new System.Windows.Forms.Label();
            this.text_id = new System.Windows.Forms.TextBox();
            this.text_suma = new System.Windows.Forms.TextBox();
            this.text_descripcion = new System.Windows.Forms.TextBox();
            this.text_precio = new System.Windows.Forms.TextBox();
            this.radio_terceros = new System.Windows.Forms.RadioButton();
            this.radio_riesgo = new System.Windows.Forms.RadioButton();
            this.button_generar = new System.Windows.Forms.Button();
            this.label_total = new System.Windows.Forms.Label();
            this.text_total = new System.Windows.Forms.TextBox();
            this.vista_seguros = new System.Windows.Forms.DataGridView();
            this.button_guardar = new System.Windows.Forms.Button();
            this.button_editar = new System.Windows.Forms.Button();
            this.button_eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vista_seguros)).BeginInit();
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.Location = new System.Drawing.Point(60, 45);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(30, 20);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "ID:";
            // 
            // label_suma
            // 
            this.label_suma.AutoSize = true;
            this.label_suma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_suma.Location = new System.Drawing.Point(60, 254);
            this.label_suma.Name = "label_suma";
            this.label_suma.Size = new System.Drawing.Size(137, 20);
            this.label_suma.TabIndex = 2;
            this.label_suma.Text = "Suma Asegurada:";
            // 
            // label_descripcion
            // 
            this.label_descripcion.AutoSize = true;
            this.label_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_descripcion.Location = new System.Drawing.Point(60, 157);
            this.label_descripcion.Name = "label_descripcion";
            this.label_descripcion.Size = new System.Drawing.Size(96, 20);
            this.label_descripcion.TabIndex = 3;
            this.label_descripcion.Text = "Descripcion:";
            // 
            // label_precio
            // 
            this.label_precio.AutoSize = true;
            this.label_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_precio.Location = new System.Drawing.Point(60, 106);
            this.label_precio.Name = "label_precio";
            this.label_precio.Size = new System.Drawing.Size(121, 20);
            this.label_precio.TabIndex = 4;
            this.label_precio.Text = "Precio Mensual:";
            // 
            // text_id
            // 
            this.text_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_id.Location = new System.Drawing.Point(242, 39);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(141, 26);
            this.text_id.TabIndex = 5;
            this.text_id.TextChanged += new System.EventHandler(this.text_id_TextChanged);
            // 
            // text_suma
            // 
            this.text_suma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_suma.Location = new System.Drawing.Point(242, 248);
            this.text_suma.Name = "text_suma";
            this.text_suma.Size = new System.Drawing.Size(141, 26);
            this.text_suma.TabIndex = 7;
            this.text_suma.TextChanged += new System.EventHandler(this.text_suma_TextChanged);
            // 
            // text_descripcion
            // 
            this.text_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_descripcion.Location = new System.Drawing.Point(242, 154);
            this.text_descripcion.Multiline = true;
            this.text_descripcion.Name = "text_descripcion";
            this.text_descripcion.Size = new System.Drawing.Size(141, 72);
            this.text_descripcion.TabIndex = 8;
            // 
            // text_precio
            // 
            this.text_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_precio.Location = new System.Drawing.Point(242, 100);
            this.text_precio.Name = "text_precio";
            this.text_precio.Size = new System.Drawing.Size(141, 26);
            this.text_precio.TabIndex = 9;
            this.text_precio.TextChanged += new System.EventHandler(this.text_precio_TextChanged);
            // 
            // radio_terceros
            // 
            this.radio_terceros.AutoSize = true;
            this.radio_terceros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_terceros.Location = new System.Drawing.Point(64, 325);
            this.radio_terceros.Name = "radio_terceros";
            this.radio_terceros.Size = new System.Drawing.Size(84, 24);
            this.radio_terceros.TabIndex = 10;
            this.radio_terceros.TabStop = true;
            this.radio_terceros.Text = "Teceros";
            this.radio_terceros.UseVisualStyleBackColor = true;
            // 
            // radio_riesgo
            // 
            this.radio_riesgo.AutoSize = true;
            this.radio_riesgo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_riesgo.Location = new System.Drawing.Point(154, 325);
            this.radio_riesgo.Name = "radio_riesgo";
            this.radio_riesgo.Size = new System.Drawing.Size(117, 24);
            this.radio_riesgo.TabIndex = 11;
            this.radio_riesgo.TabStop = true;
            this.radio_riesgo.Text = "Todo Riesgo";
            this.radio_riesgo.UseVisualStyleBackColor = true;
            // 
            // button_generar
            // 
            this.button_generar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_generar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_generar.Location = new System.Drawing.Point(120, 401);
            this.button_generar.Name = "button_generar";
            this.button_generar.Size = new System.Drawing.Size(189, 33);
            this.button_generar.TabIndex = 12;
            this.button_generar.Text = "Generar Calculo";
            this.button_generar.UseVisualStyleBackColor = false;
            this.button_generar.Click += new System.EventHandler(this.button_generar_Click);
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.Location = new System.Drawing.Point(315, 407);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(196, 20);
            this.label_total.TabIndex = 13;
            this.label_total.Text = "Valor total de la franquicia:";
            // 
            // text_total
            // 
            this.text_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_total.Location = new System.Drawing.Point(517, 404);
            this.text_total.Name = "text_total";
            this.text_total.Size = new System.Drawing.Size(98, 26);
            this.text_total.TabIndex = 14;
            // 
            // vista_seguros
            // 
            this.vista_seguros.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vista_seguros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vista_seguros.Location = new System.Drawing.Point(682, 39);
            this.vista_seguros.Name = "vista_seguros";
            this.vista_seguros.Size = new System.Drawing.Size(478, 562);
            this.vista_seguros.TabIndex = 15;
            this.vista_seguros.SelectionChanged += this.vista_seguros_SelectionChanged;
            // 
            // button_guardar
            // 
            this.button_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_guardar.Location = new System.Drawing.Point(120, 457);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(189, 33);
            this.button_guardar.TabIndex = 16;
            this.button_guardar.Text = "Guardar Seguro";
            this.button_guardar.UseVisualStyleBackColor = false;
            this.button_guardar.Click += new System.EventHandler(this.button_guardar_Click);
            // 
            // button_editar
            // 
            this.button_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_editar.Location = new System.Drawing.Point(120, 515);
            this.button_editar.Name = "button_editar";
            this.button_editar.Size = new System.Drawing.Size(189, 33);
            this.button_editar.TabIndex = 17;
            this.button_editar.Text = "Editar Calculo";
            this.button_editar.UseVisualStyleBackColor = false;
            this.button_editar.Click += new System.EventHandler(this.button_editar_Click);
            // 
            // button_eliminar
            // 
            this.button_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_eliminar.Location = new System.Drawing.Point(120, 571);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(189, 33);
            this.button_eliminar.TabIndex = 18;
            this.button_eliminar.Text = "Eliminar Calculo";
            this.button_eliminar.UseVisualStyleBackColor = false;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 628);
            this.Controls.Add(this.button_eliminar);
            this.Controls.Add(this.button_editar);
            this.Controls.Add(this.button_guardar);
            this.Controls.Add(this.vista_seguros);
            this.Controls.Add(this.text_total);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.button_generar);
            this.Controls.Add(this.radio_riesgo);
            this.Controls.Add(this.radio_terceros);
            this.Controls.Add(this.text_precio);
            this.Controls.Add(this.text_descripcion);
            this.Controls.Add(this.text_suma);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.label_precio);
            this.Controls.Add(this.label_descripcion);
            this.Controls.Add(this.label_suma);
            this.Controls.Add(this.label_id);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.vista_seguros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_suma;
        private System.Windows.Forms.Label label_descripcion;
        private System.Windows.Forms.Label label_precio;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.TextBox text_suma;
        private System.Windows.Forms.TextBox text_descripcion;
        private System.Windows.Forms.TextBox text_precio;
        private System.Windows.Forms.RadioButton radio_terceros;
        private System.Windows.Forms.RadioButton radio_riesgo;
        private System.Windows.Forms.Button button_generar;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.TextBox text_total;
        private System.Windows.Forms.DataGridView vista_seguros;
        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.Button button_editar;
        private System.Windows.Forms.Button button_eliminar;
    }
}

