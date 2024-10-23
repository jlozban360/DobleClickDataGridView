namespace DobleClickDataGridView
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
            textBoxNombre = new TextBox();
            textBoxApellido = new TextBox();
            textBoxTelefono = new TextBox();
            textBoxDireccion = new TextBox();
            buttonAgregar = new Button();
            buttonEliminar = new Button();
            dataGridView1 = new DataGridView();
            CNombre = new DataGridViewTextBoxColumn();
            CApellido = new DataGridViewTextBoxColumn();
            CTelefono = new DataGridViewTextBoxColumn();
            CDireccion = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(60, 67);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(106, 23);
            textBoxNombre.TabIndex = 0;
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(172, 67);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(105, 23);
            textBoxApellido.TabIndex = 1;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(283, 67);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(113, 23);
            textBoxTelefono.TabIndex = 2;
            textBoxTelefono.TextChanged += textBoxTelefono_TextChanged;
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Location = new Point(402, 67);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(100, 23);
            textBoxDireccion.TabIndex = 3;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(519, 67);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(140, 40);
            buttonAgregar.TabIndex = 4;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += button1_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(519, 120);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(140, 40);
            buttonEliminar.TabIndex = 5;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CNombre, CApellido, CTelefono, CDireccion });
            dataGridView1.Location = new Point(60, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(442, 250);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // CNombre
            // 
            CNombre.HeaderText = "Nombre";
            CNombre.Name = "CNombre";
            CNombre.ReadOnly = true;
            // 
            // CApellido
            // 
            CApellido.HeaderText = "Apellido";
            CApellido.Name = "CApellido";
            CApellido.ReadOnly = true;
            // 
            // CTelefono
            // 
            CTelefono.HeaderText = "Telefono";
            CTelefono.Name = "CTelefono";
            CTelefono.ReadOnly = true;
            // 
            // CDireccion
            // 
            CDireccion.HeaderText = "Dirección";
            CDireccion.Name = "CDireccion";
            CDireccion.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 425);
            Controls.Add(dataGridView1);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonAgregar);
            Controls.Add(textBoxDireccion);
            Controls.Add(textBoxTelefono);
            Controls.Add(textBoxApellido);
            Controls.Add(textBoxNombre);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNombre;
        private TextBox textBoxApellido;
        private TextBox textBoxTelefono;
        private TextBox textBoxDireccion;
        private Button buttonAgregar;
        private Button buttonEliminar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CNombre;
        private DataGridViewTextBoxColumn CApellido;
        private DataGridViewTextBoxColumn CTelefono;
        private DataGridViewTextBoxColumn CDireccion;
    }
}
