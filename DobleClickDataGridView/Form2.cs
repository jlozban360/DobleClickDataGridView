using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DobleClickDataGridView
{
    public partial class Form2 : Form
    {
        private DataGridViewRow selectedRow;

        public Form2(DataGridViewRow row, String nombre, String apellido, String telefono, String direccion)
        {
            InitializeComponent();

            textBoxEditNombre.Text = nombre;
            textBoxEditApellido.Text = apellido;
            textBoxEditTelefono.Text = telefono;
            textBoxEditDireccion.Text = direccion;

            selectedRow = row;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxEditNombre.Text) || string.IsNullOrEmpty(textBoxEditApellido.Text) || string.IsNullOrEmpty(textBoxEditTelefono.Text) || string.IsNullOrEmpty(textBoxEditDireccion.Text))
            {
                MessageBox.Show("No puedes dejar ningún campo vacío");
                return;
            }

            // Aplicar los cambios a la fila seleccionada
            selectedRow.Cells["CNombre"].Value = textBoxEditNombre.Text;
            selectedRow.Cells["CApellido"].Value = textBoxEditApellido.Text;
            selectedRow.Cells["CTelefono"].Value = textBoxEditTelefono.Text;
            selectedRow.Cells["CDireccion"].Value = textBoxEditDireccion.Text;

            // Cerrar el formulario
            this.Close();
        }
    }
}
