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
    public partial class Inicio : Form
    {
        Acciones acciones = new Acciones();
        public Inicio()
        {
            InitializeComponent();
        }


        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Form1 formloggin = new Form1();
            this.Hide();
            formloggin.Show();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            dgvNombres.DataSource = null;
            var nombres = acciones.Obtenernombre();

            if (nombres.Count >0)
            {
                dgvNombres.DataSource = nombres.Select(n => new { Nombre = n}).ToList();
            }
            else
            {
                MessageBox.Show("No hay nombres para mostrar");
            }
        }


        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (acciones.AgregarNombre(TextbNombre.Text))
            {
                MessageBox.Show("Agregado con exito");
            }
            else
            {
                MessageBox.Show("No se pudo agregar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (acciones.Eliminarnombres(TextbEliminar.Text))
            {
                MessageBox.Show("Eliminado con exito");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar");
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";
                saveFileDialog.Title = "Guardar nombres en Excel";
                saveFileDialog.FileName = "Nombres.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string rutaArchivo = saveFileDialog.FileName;
                    if (acciones.ExportarNombresAExcel(rutaArchivo))
                        MessageBox.Show("Exportación exitosa");
                    else
                        MessageBox.Show("Error al exportar");
                }
            }
        }
    }
}
