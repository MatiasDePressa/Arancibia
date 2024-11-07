namespace El_mismo_enano_comunista_3_XDDDDDDDDDDD
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            labelId = new Label();
            labelNombre = new Label();
            textID = new TextBox();
            textNombre = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            buttonCategoriaC = new Button();
            buttonEditarC = new Button();
            buttonEliminarC = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 12F);
            labelId.Location = new Point(33, 76);
            labelId.Name = "labelId";
            labelId.Size = new Size(110, 21);
            labelId.TabIndex = 0;
            labelId.Text = "Coloque un Id:";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 12F);
            labelNombre.Location = new Point(33, 127);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(155, 21);
            labelNombre.TabIndex = 1;
            labelNombre.Text = "Coloque un Nombre:";
            // 
            // textID
            // 
            textID.Font = new Font("Segoe UI", 12F);
            textID.Location = new Point(202, 78);
            textID.Name = "textID";
            textID.Size = new Size(100, 29);
            textID.TabIndex = 2;
            textID.TextChanged += textID_TextChanged;
            // 
            // textNombre
            // 
            textNombre.Font = new Font("Segoe UI", 12F);
            textNombre.Location = new Point(202, 124);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(238, 29);
            textNombre.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(516, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(261, 532);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(597, 19);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 5;
            label1.Text = "Categorias:";
            // 
            // buttonCategoriaC
            // 
            buttonCategoriaC.BackColor = Color.FromArgb(128, 255, 128);
            buttonCategoriaC.Font = new Font("Segoe UI", 12F);
            buttonCategoriaC.Location = new Point(182, 239);
            buttonCategoriaC.Name = "buttonCategoriaC";
            buttonCategoriaC.Size = new Size(184, 40);
            buttonCategoriaC.TabIndex = 6;
            buttonCategoriaC.Text = "Agregar categoria";
            buttonCategoriaC.UseVisualStyleBackColor = false;
            buttonCategoriaC.Click += buttonCategoriaC_Click;
            // 
            // buttonEditarC
            // 
            buttonEditarC.BackColor = Color.FromArgb(255, 255, 128);
            buttonEditarC.Font = new Font("Segoe UI", 12F);
            buttonEditarC.Location = new Point(182, 304);
            buttonEditarC.Name = "buttonEditarC";
            buttonEditarC.Size = new Size(184, 40);
            buttonEditarC.TabIndex = 7;
            buttonEditarC.Text = "Editar categoria";
            buttonEditarC.UseVisualStyleBackColor = false;
            buttonEditarC.Click += buttonEditarC_Click;
            // 
            // buttonEliminarC
            // 
            buttonEliminarC.BackColor = Color.FromArgb(255, 128, 128);
            buttonEliminarC.Font = new Font("Segoe UI", 12F);
            buttonEliminarC.Location = new Point(182, 369);
            buttonEliminarC.Name = "buttonEliminarC";
            buttonEliminarC.Size = new Size(184, 40);
            buttonEliminarC.TabIndex = 8;
            buttonEliminarC.Text = "Eliminar categoria";
            buttonEliminarC.UseVisualStyleBackColor = false;
            buttonEliminarC.Click += buttonEliminarC_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(12, 9);
            button1.Name = "button1";
            button1.Size = new Size(86, 40);
            button1.TabIndex = 9;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 616);
            Controls.Add(button1);
            Controls.Add(buttonEliminarC);
            Controls.Add(buttonEditarC);
            Controls.Add(buttonCategoriaC);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(textNombre);
            Controls.Add(textID);
            Controls.Add(labelNombre);
            Controls.Add(labelId);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCategoriaC;
        private System.Windows.Forms.Button buttonEditarC;
        private System.Windows.Forms.Button buttonEliminarC;
        private Button button1;
    }
}