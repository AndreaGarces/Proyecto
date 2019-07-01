using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string clave;
            clave = Convert.ToString(textBoxClave);
            if (clave.Length != 0)
            {
                Console.WriteLine("*");
            }
        }
    }
}
