namespace DobleClickDataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            string apellido = textBoxApellido.Text;
            string telefono = textBoxTelefono.Text;
            string direccion = textBoxDireccion.Text;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(direccion))
            {
                MessageBox.Show("Debes completar todos los campos antes de agregar un registro.");
                return;
            }
            else if (textBoxTelefono.TextLength != 9)
            {
                MessageBox.Show("El teléfono debe tener 9 dígitos");
                return;
            }

            dataGridView1.Rows.Add(nombre, apellido, telefono, direccion);

            textBoxNombre.Clear();
            textBoxApellido.Clear();
            textBoxTelefono.Clear();
            textBoxDireccion.Clear();

            textBoxTelefono.BackColor = Color.White;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;
                dataGridView1.Rows.RemoveAt(rowIndex);
            }
            else
                MessageBox.Show("Tienes que tener seleccionada al menos una fila para poder eliminarlas.");
        }

        private void textBoxTelefono_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTelefono.TextLength == 9 || textBoxTelefono.TextLength == 0)
                textBoxTelefono.BackColor = Color.White;
            else
                textBoxTelefono.BackColor = Color.Red;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string nombre = dataGridView1.Rows[e.RowIndex].Cells["CNombre"].Value.ToString();
                string apellido = dataGridView1.Rows[e.RowIndex].Cells["CApellido"].Value.ToString();
                string telefono = dataGridView1.Rows[e.RowIndex].Cells["CTelefono"].Value.ToString();
                string direccion = dataGridView1.Rows[e.RowIndex].Cells["CDireccion"].Value.ToString();

                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                Form2 form2 = new Form2(selectedRow, nombre, apellido, telefono, direccion);
                form2.ShowDialog();
            }
        }

    }
}
