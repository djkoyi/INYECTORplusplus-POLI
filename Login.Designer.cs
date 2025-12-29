using System.Drawing;
using System.Windows.Forms;

namespace INYECTOR
{
    partial class Login
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
            txtusuario = new TextBox();
            txtpass = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // txtusuario
            // 
            txtusuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtusuario.Location = new Point(3, 12);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(219, 29);
            txtusuario.TabIndex = 0;
            txtusuario.TextAlign = HorizontalAlignment.Center;
            // 
            // txtpass
            // 
            txtpass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtpass.Location = new Point(3, 47);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(219, 29);
            txtpass.TabIndex = 1;
            txtpass.TextAlign = HorizontalAlignment.Center;
            txtpass.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Location = new Point(3, 82);
            button1.Name = "button1";
            button1.Size = new Size(101, 29);
            button1.TabIndex = 2;
            button1.Text = "Iniciar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(121, 82);
            button2.Name = "button2";
            button2.Size = new Size(101, 29);
            button2.TabIndex = 3;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(229, 119);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtpass);
            Controls.Add(txtusuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtusuario;
        private TextBox txtpass;
        private Button button1;
        private Button button2;
    }
}