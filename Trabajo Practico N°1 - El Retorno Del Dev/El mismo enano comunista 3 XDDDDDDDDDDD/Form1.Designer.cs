namespace El_mismo_enano_comunista_3_XDDDDDDDDDDD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAgregar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            buttonEditar = new Button();
            buttonEliminar = new Button();
            dataGridView1 = new DataGridView();
            ListaXD = new Label();
            buttonBuscar = new Button();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox6 = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            irACategoria = new Button();
            panel1 = new Panel();
            precio1 = new TextBox();
            precio2 = new TextBox();
            filtro = new Button();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAgregar
            // 
            buttonAgregar.BackColor = Color.FromArgb(128, 255, 128);
            buttonAgregar.Font = new Font("Segoe UI", 12F);
            buttonAgregar.ForeColor = SystemColors.ActiveCaptionText;
            buttonAgregar.Location = new Point(31, 418);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(320, 34);
            buttonAgregar.TabIndex = 0;
            buttonAgregar.Text = "Agregar Producto";
            buttonAgregar.UseVisualStyleBackColor = false;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(31, 24);
            label1.Name = "label1";
            label1.Size = new Size(105, 21);
            label1.TabIndex = 1;
            label1.Text = "Ingrese un ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(133, 21);
            label2.TabIndex = 2;
            label2.Text = "Ingrese un Precio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 189);
            label3.Name = "label3";
            label3.Size = new Size(179, 21);
            label3.TabIndex = 3;
            label3.Text = "Ingrese una Descripcion:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(205, 191);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(154, 184);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(205, 77);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(154, 23);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(205, 26);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(154, 23);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox2_TextChanged;
            // 
            // buttonEditar
            // 
            buttonEditar.BackColor = Color.FromArgb(255, 255, 128);
            buttonEditar.Font = new Font("Segoe UI", 12F);
            buttonEditar.ForeColor = SystemColors.ActiveCaptionText;
            buttonEditar.Location = new Point(31, 489);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(320, 34);
            buttonEditar.TabIndex = 7;
            buttonEditar.Text = "Editar Producto";
            buttonEditar.UseVisualStyleBackColor = false;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackColor = Color.FromArgb(255, 128, 128);
            buttonEliminar.Font = new Font("Segoe UI", 12F);
            buttonEliminar.ForeColor = SystemColors.ActiveCaptionText;
            buttonEliminar.Location = new Point(31, 554);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(320, 34);
            buttonEliminar.TabIndex = 8;
            buttonEliminar.Text = "Eliminar Producto";
            buttonEliminar.UseVisualStyleBackColor = false;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1 = new System.Windows.Forms.DataGridView();
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridView1.Location = new System.Drawing.Point(658, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new System.Drawing.Size(452, 393);
            dataGridView1.TabIndex = 9;
            //dataGridView1.SelectionChanged += new System.EventHandler(dataGridView1_SelectionChanged);
            //Controls.Add(dataGridView1);
            // 
            // ListaXD
            // 
            ListaXD.AutoSize = true;
            ListaXD.Font = new Font("Segoe UI", 12F);
            ListaXD.Location = new Point(810, 24);
            ListaXD.Name = "ListaXD";
            ListaXD.Size = new Size(139, 21);
            ListaXD.TabIndex = 10;
            ListaXD.Text = "Lista De Productos";
            // 
            // buttonBuscar
            // 
            buttonBuscar.BackColor = Color.FromArgb(128, 128, 255);
            buttonBuscar.Font = new Font("Segoe UI", 12F);
            buttonBuscar.ForeColor = SystemColors.ActiveCaptionText;
            buttonBuscar.Location = new Point(394, 24);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(147, 34);
            buttonBuscar.TabIndex = 11;
            buttonBuscar.Text = "Buscar Producto";
            buttonBuscar.UseVisualStyleBackColor = false;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(556, 33);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(56, 23);
            textBox4.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(3, 43);
            label4.Name = "label4";
            label4.Size = new Size(0, 21);
            label4.TabIndex = 13;
            // 
            // textBox6
            // 
            textBox6.FormattingEnabled = true;
            textBox6.Location = new Point(205, 139);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(154, 23);
            textBox6.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(12, 137);
            label6.Name = "label6";
            label6.Size = new Size(187, 21);
            label6.TabIndex = 15;
            label6.Text = "Seleccione una Categoria:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonFace;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 11);
            label5.Name = "label5";
            label5.Size = new Size(82, 21);
            label5.TabIndex = 16;
            label5.Text = "Resultado:";
            // 
            // irACategoria
            // 
            irACategoria.BackColor = Color.FromArgb(128, 255, 128);
            irACategoria.Font = new Font("Segoe UI", 12F);
            irACategoria.ForeColor = SystemColors.ActiveCaptionText;
            irACategoria.Location = new Point(401, 554);
            irACategoria.Name = "irACategoria";
            irACategoria.Size = new Size(211, 34);
            irACategoria.TabIndex = 17;
            irACategoria.Text = "Agregar categoria";
            irACategoria.UseVisualStyleBackColor = false;
            irACategoria.Click += irACategoria_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(394, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 267);
            panel1.TabIndex = 18;
            // 
            // precio1
            // 
            precio1.Location = new Point(796, 525);
            precio1.Name = "precio1";
            precio1.Size = new Size(76, 23);
            precio1.TabIndex = 19;
            // 
            // precio2
            // 
            precio2.Location = new Point(900, 525);
            precio2.Name = "precio2";
            precio2.Size = new Size(76, 23);
            precio2.TabIndex = 20;
            // 
            // filtro
            // 
            filtro.BackColor = Color.FromArgb(128, 128, 255);
            filtro.Font = new Font("Segoe UI", 12F);
            filtro.ForeColor = SystemColors.ActiveCaptionText;
            filtro.Location = new Point(823, 554);
            filtro.Name = "filtro";
            filtro.Size = new Size(126, 34);
            filtro.TabIndex = 21;
            filtro.Text = "Filtrar";
            filtro.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(796, 496);
            label7.Name = "label7";
            label7.Size = new Size(169, 21);
            label7.TabIndex = 22;
            label7.Text = "Filtar Por Precios Entre:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(878, 525);
            label8.Name = "label8";
            label8.Size = new Size(16, 21);
            label8.TabIndex = 23;
            label8.Text = "-";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1153, 622);
            Controls.Add(label8);
            Controls.Add(filtro);
            Controls.Add(precio2);
            Controls.Add(precio1);
            Controls.Add(irACategoria);
            Controls.Add(label6);
            Controls.Add(textBox6);
            Controls.Add(textBox4);
            Controls.Add(buttonBuscar);
            Controls.Add(ListaXD);
            Controls.Add(dataGridView1);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonEditar);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonAgregar);
            Controls.Add(panel1);
            Controls.Add(label7);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBuscar;
        private Label label1; // aca no les cambie los nombres por que era mi primer
        private Label label2; // form en c# y no tenia ni idea de que estaba haciendo
        private Label label3;
        private TextBox textBox1; //descrp
        private TextBox textBox2; //precio   no tengo ni idea de por que se colocaron al reves
        private TextBox textBox3; //id       pero fuck off, no me importa mucho, me hizo reir bastante
        private Button buttonAgregar;
        private Button buttonEditar;
        private Button buttonEliminar;
        private DataGridView dataGridView1;
        private Label ListaXD;
        private TextBox textBox4;
        private Label label4;
        private ComboBox textBox6;
        private Label label6;
        private Label label5;
        private Button irACategoria;
        private Panel panel1;
        private TextBox precio1;
        private TextBox precio2;
        private Button filtro;
        private Label label7;
        private Label label8;
    }
}
