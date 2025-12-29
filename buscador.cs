
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

        public partial class buscador : Form
        {
            claseNegocio ObjConsulta = new claseNegocio();
            DataTable TblDet = null;
            public buscador()
            {
                InitializeComponent();
            }
            private void buscador_Load(object sender, EventArgs e)
            {
                dataGridView1.DataSource = ObjConsulta.MostraDatos("SP_SelectHrEmployee_TOTAL").Tables[0];
            }
            private void button2_Click(object sender, EventArgs e)
            {
                dataGridView1.DataSource = ObjConsulta.MostraDatos("SP_SelectHrEmployee", textBox1.Text).Tables[0];
            }
            private void button3_Click(object sender, EventArgs e)
            {
                dataGridView1.DataSource = ObjConsulta.MostraDatos("SP_SelectHrEmployee_TOTAL").Tables[0];
            }
            private void buscador_FormClosed(object sender, FormClosedEventArgs e)
            {
                if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
                {
                    int id = (int)dataGridView1.SelectedRows[0].Cells["id"].Value;
                    string miCadena = id.ToString();
                    principal.variableCompartida = miCadena.ToString();

                    string firstname = (string)dataGridView1.SelectedRows[0].Cells["emp_firstname"].Value;

                    principal.variable_nombre = firstname.ToString();

                    string lastname = (string)dataGridView1.SelectedRows[0].Cells["emp_lastname"].Value;

                    principal.variable_apellido = lastname.ToString();




                }
            }
            private void textBox1_KeyDown(object sender, KeyEventArgs e)
            {
                dataGridView1.DataSource = ObjConsulta.MostraDatos("SP_SelectHrEmployee", textBox1.Text).Tables[0];
            }
        }

}
