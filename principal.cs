using INYECTOR.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INYECTOR
{
    public partial class principal : Form
    {
        claseNegocio ObjConsulta = new claseNegocio();
        claseNegocio objQuery = new claseNegocio();

        DataTable TblDet = null;
        int contador;

        public principal()
        {
            InitializeComponent();
        }
        internal static string variableCompartida;
        internal static string variable_nombre;
        internal static string variable_apellido;
        private void button2_Click(object sender, EventArgs e)
        {
            buscador frm = new buscador();
            frm.ShowDialog();
            txtID.Text = variableCompartida;
            nombre.Text = variable_nombre;
            apellido.Text = variable_apellido;
            button1.Enabled = true;


        }
        private void cargar_tabla()
        {
            dataGridView1.DataSource = ObjConsulta.MostraDatos("SP_SelectAttPunch_fecha", txtID.Text,
       dateTimeBuscar1.Value, dateTimeBuscar2.Value).Tables[0];

        }
        private void button1_Click(object sender, EventArgs e)
        {
            cargar_tabla();
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
        }

        private void principal_Load(object sender, EventArgs e)
        {
            dateTimeEditar.MaxDate = DateTime.Now;
            dateTimeBuscar2.MaxDate = DateTime.Now;
        }

        private void maskedTextBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string[] parts = maskedTextBox1.Text.Split(':');
            int hours, minutes;

            if (parts.Length != 2 ||
                !int.TryParse(parts[0], out hours) ||
                !int.TryParse(parts[1], out minutes) ||
                hours < 0 || hours > 24 ||
                minutes < 0 || minutes > 59)
            {
                MessageBox.Show("La hora ingresada no es válida. Por favor ingrese una hora en formato HH:mm");
                e.Cancel = true;
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // Desactivar botones Editar y Eliminar
            btnEditar.Enabled = false;
            btnNuevo.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
            contador = 1;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Desactivar botón Nuevo y Eliminar
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
            contador = 2;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Reactivar todos los botones
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = false;
            if (contador == 1)
            {
                // Crear una variable DateTime con la fecha seleccionada en el DateTimePicker
                DateTime fechaSeleccionada = dateTimeEditar.Value;

                // Crear una variable TimeSpan con la hora introducida en el TextBox
                TimeSpan horaSeleccionada = TimeSpan.Parse(maskedTextBox1.Text);

                // Crear una nueva variable DateTime con la fecha y hora seleccionadas
                DateTime fechaHoraSeleccionadas = fechaSeleccionada.Date.Add(horaSeleccionada);

                objQuery.AgregarDatos("SP_InsertAttPunch_Guardar", txtID.Text, fechaHoraSeleccionadas);
                objQuery.AgregarDatos("CORRECCION_DE_PARAMETROS_ID", txtID.Text);


                MessageBox.Show("Almacenado Correctamente");
                cargar_tabla();

            }
            else
            {
                // Crear una variable DateTime con la fecha seleccionada en el DateTimePicker
                DateTime fechaSeleccionada = dateTimeEditar.Value;

                // Crear una variable TimeSpan con la hora introducida en el TextBox
                TimeSpan horaSeleccionada = TimeSpan.Parse(maskedTextBox1.Text);

                // Crear una nueva variable DateTime con la fecha y hora seleccionadas
                DateTime fechaHoraSeleccionadas = fechaSeleccionada.Date.Add(horaSeleccionada);

                objQuery.AgregarDatos("SP_UpdateAttPunch", IdReg.Text, fechaHoraSeleccionadas);
                objQuery.AgregarDatos("CORRECCION_DE_PARAMETROS_ID", txtID.Text);

                MessageBox.Show("Editado Correctamente");
                cargar_tabla();

            }
            contador = 0;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CeldasQry();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CeldasQry();
        }
        private void CeldasQry()
        {
            int id = (int)dataGridView1.SelectedRows[0].Cells["id"].Value;
            string IdRegCd = id.ToString();
            IdReg.Text = IdRegCd;
            btnEliminar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            objQuery.AgregarDatos("SP_DeleteAttPunches_id", IdReg.Text);

            MessageBox.Show(IdReg.Text + " eliminado " + txtID.Text + " pertenece a " + variable_nombre + " " + variable_apellido);
            btnEliminar.Enabled = false;

            cargar_tabla();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Preguntar al usuario si realmente desea salir
            if (MessageBox.Show("¿Realmente desea salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Cierra la aplicación
                Application.Exit();
            }
            else
            {
                // Cancelar el cierre de la aplicación

            }
        }
    }
}
