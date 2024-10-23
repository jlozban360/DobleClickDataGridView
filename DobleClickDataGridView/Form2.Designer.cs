namespace DobleClickDataGridView
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelNombre = new Label();
            textBoxEditNombre = new TextBox();
            textBoxEditApellido = new TextBox();
            label1 = new Label();
            textBoxEditTelefono = new TextBox();
            label2 = new Label();
            textBoxEditDireccion = new TextBox();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 12F);
            labelNombre.Location = new Point(22, 45);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(71, 21);
            labelNombre.TabIndex = 0;
            labelNombre.Text = "Nombre:";
            // 
            // textBoxEditNombre
            // 
            textBoxEditNombre.BorderStyle = BorderStyle.FixedSingle;
            textBoxEditNombre.Font = new Font("Segoe UI", 12F);
            textBoxEditNombre.Location = new Point(113, 45);
            textBoxEditNombre.Name = "textBoxEditNombre";
            textBoxEditNombre.Size = new Size(227, 29);
            textBoxEditNombre.TabIndex = 1;
            // 
            // textBoxEditApellido
            // 
            textBoxEditApellido.BorderStyle = BorderStyle.FixedSingle;
            textBoxEditApellido.Font = new Font("Segoe UI", 12F);
            textBoxEditApellido.Location = new Point(113, 93);
            textBoxEditApellido.Name = "textBoxEditApellido";
            textBoxEditApellido.Size = new Size(227, 29);
            textBoxEditApellido.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(22, 93);
            label1.Name = "label1";
            label1.Size = new Size(70, 21);
            label1.TabIndex = 2;
            label1.Text = "Apellido:";
            // 
            // textBoxEditTelefono
            // 
            textBoxEditTelefono.BorderStyle = BorderStyle.FixedSingle;
            textBoxEditTelefono.Font = new Font("Segoe UI", 12F);
            textBoxEditTelefono.Location = new Point(113, 142);
            textBoxEditTelefono.Name = "textBoxEditTelefono";
            textBoxEditTelefono.Size = new Size(227, 29);
            textBoxEditTelefono.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(22, 142);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 4;
            label2.Text = "Teléfono:";
            // 
            // textBoxEditDireccion
            // 
            textBoxEditDireccion.BorderStyle = BorderStyle.FixedSingle;
            textBoxEditDireccion.Font = new Font("Segoe UI", 12F);
            textBoxEditDireccion.Location = new Point(113, 192);
            textBoxEditDireccion.Name = "textBoxEditDireccion";
            textBoxEditDireccion.Size = new Size(227, 29);
            textBoxEditDireccion.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(22, 192);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 6;
            label3.Text = "Dirección:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16F);
            button1.Location = new Point(22, 258);
            button1.Name = "button1";
            button1.Size = new Size(318, 46);
            button1.TabIndex = 8;
            button1.Text = "Editar registro";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 344);
            Controls.Add(button1);
            Controls.Add(textBoxEditDireccion);
            Controls.Add(label3);
            Controls.Add(textBoxEditTelefono);
            Controls.Add(label2);
            Controls.Add(textBoxEditApellido);
            Controls.Add(label1);
            Controls.Add(textBoxEditNombre);
            Controls.Add(labelNombre);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNombre;
        private TextBox textBoxEditNombre;
        private TextBox textBoxEditApellido;
        private Label label1;
        private TextBox textBoxEditTelefono;
        private Label label2;
        private TextBox textBoxEditDireccion;
        private Label label3;
        private Button button1;
    }
}