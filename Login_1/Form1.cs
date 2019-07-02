using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//usuario: prueba@correo.com
//clave: clavedeprueba

namespace Login_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text;
            string usuario_valido = "prueba@correo.com";
            string clave = textBoxClave.Text;
            string clave_valida = "clavedeprueba";
            if(String.Compare(usuario, usuario_valido) != 0 || String.Compare(clave, clave_valida) != 0)
            {
                string txtincorrecto = "Error";
                string incorrecto = "Usuario o clave inválida";
                MessageBoxIcon icono = MessageBoxIcon.Error;
                MessageBoxButtons botones = MessageBoxButtons.OK;
                MessageBox.Show(incorrecto, txtincorrecto, botones, icono);
            }
        }

        private void TextBoxClave_TextChanged(object sender, EventArgs e)
        {
            textBoxClave.UseSystemPasswordChar = true;
        }

        private void CheckMostrar_CheckedChanged(object sender, EventArgs e)
        {
            string clave = textBoxClave.Text;
            if(checkMostrar.Checked)
            {
                textBoxClave.UseSystemPasswordChar = false;
                textBoxClave.Text = clave;
            }
            else
            {
                textBoxClave.UseSystemPasswordChar = true;
                textBoxClave.Text = clave;
            }
            
        }
    }
}
