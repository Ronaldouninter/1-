using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            string user = TextbUsuario.Text;
            string password = TextbContraseña.Text;
            if (user.Trim().ToLower()== "ronaldo" && password.Trim().ToLower()== "1234" )
            {
                MessageBox.Show($"Bienvenido al sistema {user}....");
                Inicio ventana = new Inicio();
                ventana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Fallaste");
            }

        }
    }
}
