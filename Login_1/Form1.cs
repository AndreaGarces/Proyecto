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

        private void TextBoxUsuario_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            string usuario;
            usuario = Convert.ToString(textBoxUsuario.Text);
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
