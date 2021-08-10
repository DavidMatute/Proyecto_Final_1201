using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FrmLogin : Syncfusion.Windows.Forms.Office2010Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (txt_Usuario.Text == "")
            {
                errorProvider1.SetError(txt_Usuario, "Ingrese el nombre de usuario");
                txt_Usuario.Focus();
                return;
            }
            errorProvider1.SetError(txt_Usuario, "");

            if (txt_Contrasena.Text == "")
            {
                errorProvider1.SetError(txt_Contrasena, "Ingrese una contraseña");
                txt_Contrasena.Focus();
                return;
            }
            errorProvider1.SetError(txt_Contrasena, "");

            /*Canectar a la base de datos

            BaseDatos _base = new BaseDatos();

            if (_base.ValidarUsuario(UsuarioTextBox.Text, ContrasenaTextBox.Text))
            {
                PrincipalForm formulario = new PrincipalForm();
                formulario.CodigoUsuario = UsuarioTextBox.Text;
                this.Hide();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña invalida");
            }*/

        }
    }
}
