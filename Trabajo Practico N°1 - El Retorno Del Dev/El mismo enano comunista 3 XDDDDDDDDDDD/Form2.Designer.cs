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
            this.labelId = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCategoriaC = new System.Windows.Forms.Button();
            this.buttonEditarC = new System.Windows.Forms.Button();
            this.buttonEliminarC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelId.Location = new System.Drawing.Point(34, 33);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(110, 21);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "Coloque un Id:";

            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelNombre.Location = new System.Drawing.Point(34, 106);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(155, 21);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Coloque un Nombre:";

            // 
            // textID
            // 
            this.textID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textID.Location = new System.Drawing.Point(203, 35);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 29);
            this.textID.TabIndex = 2;

            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textNombre.Location = new System.Drawing.Point(203, 103);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(238, 29);
            this.textNombre.TabIndex = 3;

            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(558, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(191, 532);
            this.dataGridView1.TabIndex = 4;

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(606, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Categorias:";

            // 
            // buttonCategoriaC
            // 
            this.buttonCategoriaC.BackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            this.buttonCategoriaC.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonCategoriaC.Location = new System.Drawing.Point(182, 239);
            this.buttonCategoriaC.Name = "buttonCategoriaC";
            this.buttonCategoriaC.Size = new System.Drawing.Size(184, 40);
            this.buttonCategoriaC.TabIndex = 6;
            this.buttonCategoriaC.Text = "Agregar categoria";
            this.buttonCategoriaC.UseVisualStyleBackColor = false;
            this.buttonCategoriaC.Click += new System.EventHandler(this.buttonCategoriaC_Click);

            // 
            // buttonEditarC
            // 
            this.buttonEditarC.BackColor = System.Drawing.Color.FromArgb(255, 255, 128);
            this.buttonEditarC.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonEditarC.Location = new System.Drawing.Point(182, 375);
            this.buttonEditarC.Name = "buttonEditarC";
            this.buttonEditarC.Size = new System.Drawing.Size(184, 40);
            this.buttonEditarC.TabIndex = 7;
            this.buttonEditarC.Text = "Editar categoria";
            this.buttonEditarC.UseVisualStyleBackColor = false;
            this.buttonEditarC.Click += new System.EventHandler(this.buttonEditarC_Click);

            // 
            // buttonEliminarC
            // 
            this.buttonEliminarC.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            this.buttonEliminarC.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonEliminarC.Location = new System.Drawing.Point(182, 510);
            this.buttonEliminarC.Name = "buttonEliminarC";
            this.buttonEliminarC.Size = new System.Drawing.Size(184, 40);
            this.buttonEliminarC.TabIndex = 8;
            this.buttonEliminarC.Text = "Eliminar categoria";
            this.buttonEliminarC.UseVisualStyleBackColor = false;
            this.buttonEliminarC.Click += new System.EventHandler(this.buttonEliminarC_Click);

            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 616);
            this.Controls.Add(this.buttonEliminarC);
            this.Controls.Add(this.buttonEditarC);
            this.Controls.Add(this.buttonCategoriaC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelId);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
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
    }
}