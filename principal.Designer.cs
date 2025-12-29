using System.Drawing;
using System.Windows.Forms;
using System;

namespace INYECTOR
{
    partial class principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            txtID = new TextBox();
            button1 = new Button();
            dateTimeBuscar1 = new DateTimePicker();
            maskedTextBox1 = new MaskedTextBox();
            button2 = new Button();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            apellido = new Label();
            nombre = new Label();
            label3 = new Label();
            label1 = new Label();
            dateTimeBuscar2 = new DateTimePicker();
            groupBox2 = new GroupBox();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnNuevo = new Button();
            dateTimeEditar = new DateTimePicker();
            dataGridView1 = new DataGridView();
            groupBox3 = new GroupBox();
            IdReg = new TextBox();
            label2 = new Label();
            button3 = new Button();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(176, 24);
            txtID.Name = "txtID";
            txtID.Size = new Size(40, 23);
            txtID.TabIndex = 2;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(377, 54);
            button1.Name = "button1";
            button1.Size = new Size(72, 24);
            button1.TabIndex = 4;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimeBuscar1
            // 
            dateTimeBuscar1.Format = DateTimePickerFormat.Custom;
            dateTimeBuscar1.Location = new Point(57, 56);
            dateTimeBuscar1.Name = "dateTimeBuscar1";
            dateTimeBuscar1.Size = new Size(136, 23);
            dateTimeBuscar1.TabIndex = 5;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(175, 16);
            maskedTextBox1.Mask = "00:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(43, 23);
            maskedTextBox1.TabIndex = 7;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            maskedTextBox1.Validating += maskedTextBox1_Validating;
            // 
            // button2
            // 
            button2.Location = new Point(0, 24);
            button2.Name = "button2";
            button2.Size = new Size(168, 24);
            button2.TabIndex = 8;
            button2.Text = "Buscar Funcionario";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dateTimeBuscar2);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dateTimeBuscar1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(455, 85);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscador";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(apellido, 1, 1);
            tableLayoutPanel1.Controls.Add(nombre, 0, 1);
            tableLayoutPanel1.Location = new Point(224, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(225, 24);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // apellido
            // 
            apellido.AutoSize = true;
            apellido.Location = new Point(9, 0);
            apellido.Name = "apellido";
            apellido.Size = new Size(0, 15);
            apellido.TabIndex = 1;
            // 
            // nombre
            // 
            nombre.AutoSize = true;
            nombre.Location = new Point(3, 0);
            nombre.Name = "nombre";
            nombre.Size = new Size(0, 15);
            nombre.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(199, 62);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 11;
            label3.Text = "Hasta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 64);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 10;
            label1.Text = "Desde";
            // 
            // dateTimeBuscar2
            // 
            dateTimeBuscar2.Format = DateTimePickerFormat.Custom;
            dateTimeBuscar2.Location = new Point(241, 54);
            dateTimeBuscar2.Name = "dateTimeBuscar2";
            dateTimeBuscar2.Size = new Size(136, 23);
            dateTimeBuscar2.TabIndex = 9;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnGuardar);
            groupBox2.Controls.Add(btnEliminar);
            groupBox2.Controls.Add(btnEditar);
            groupBox2.Controls.Add(btnNuevo);
            groupBox2.Controls.Add(dateTimeEditar);
            groupBox2.Controls.Add(maskedTextBox1);
            groupBox2.Location = new Point(473, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(228, 113);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Editar";
            // 
            // btnGuardar
            // 
            btnGuardar.Enabled = false;
            btnGuardar.Location = new Point(126, 45);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(96, 24);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.Location = new Point(126, 83);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(96, 23);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Enabled = false;
            btnEditar.Location = new Point(6, 83);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(96, 24);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Enabled = false;
            btnNuevo.Location = new Point(6, 45);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(96, 24);
            btnNuevo.TabIndex = 11;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // dateTimeEditar
            // 
            dateTimeEditar.Format = DateTimePickerFormat.Custom;
            dateTimeEditar.Location = new Point(6, 16);
            dateTimeEditar.Name = "dateTimeEditar";
            dateTimeEditar.Size = new Size(163, 23);
            dateTimeEditar.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(673, 267);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(12, 131);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(689, 298);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Registros";
            // 
            // IdReg
            // 
            IdReg.Enabled = false;
            IdReg.Location = new Point(395, 101);
            IdReg.Name = "IdReg";
            IdReg.Size = new Size(72, 23);
            IdReg.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(325, 104);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 13;
            label2.Text = "ID Registro";
            // 
            // button3
            // 
            button3.Location = new Point(626, 435);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 14;
            button3.Text = "Cerrar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 467);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(IdReg);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "INYECCION++";
            Load += principal_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private DateTimePicker dateTimeBuscar1;
        private MaskedTextBox maskedTextBox1;
        private Button button2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DateTimePicker dateTimeEditar;
        public TextBox txtID;
        private Label label1;
        private DateTimePicker dateTimeBuscar2;
        private Label label3;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label apellido;
        private Label nombre;
        private GroupBox groupBox3;
        private Button btnEditar;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button btnGuardar;
        public TextBox IdReg;
        private Label label2;
        private Button button3;
    }

 
 
}

