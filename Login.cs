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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (autenticar.Autenticar(txtusuario.Text, Funciones.SHA1(txtpass.Text)))
            {

                principal frm = new principal();
                frm.Show();
                Hide();

            }
            else
            {
                MessageBox.Show("error de contraseña");

            }

        }

        private void button2_Click(object sender, EventArgs e)
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
