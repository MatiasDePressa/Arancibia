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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.InactiveCaptionText;
            dataGridView1.Location = new Point(771, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(339, 529);
            dataGridView1.TabIndex = 9;
            // 
            // ListaXD
            // 
            ListaXD.AutoSize = true;
            ListaXD.Font = new Font("Segoe UI", 12F);
            ListaXD.Location = new Point(870, 22);
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
            buttonBuscar.Size = new Size(160, 34);
            buttonBuscar.TabIndex = 11;
            buttonBuscar.Text = "buscar Producto";
            buttonBuscar.UseVisualStyleBackColor = false;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(573, 24);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(145, 34);
            textBox4.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(394, 104);
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
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(394, 74);
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
            irACategoria.Location = new Point(442, 489);
            irACategoria.Name = "irACategoria";
            irACategoria.Size = new Size(257, 34);
            irACategoria.TabIndex = 17;
            irACategoria.Text = "Agregar categoria";
            irACategoria.UseVisualStyleBackColor = false;
            //irACategoria.Click += irACategoria_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1153, 622);
            Controls.Add(irACategoria);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(textBox6);
            Controls.Add(label4);
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
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
    }
}
