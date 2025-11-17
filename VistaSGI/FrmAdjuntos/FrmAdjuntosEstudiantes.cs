using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;

namespace VistaSGI
{
    public partial class FrmAdjuntosEstudiantes : Form
    {
        private CL_CargaBox clCargaBox = new CL_CargaBox();

        public FrmAdjuntosEstudiantes()
        {
            InitializeComponent();
        }

        private void FrmAdjuntosEstudiantes_Load(object sender, EventArgs e)
        {
            // Cargar categorías en el ComboBox
            DataTable categorias = clCargaBox.ClBoxCategoriasAdj();
            comboBoxCategorias.DataSource = categorias;
            comboBoxCategorias.DisplayMember = "NombreCategoria"; // Ajusta esto según el nombre de la columna
            comboBoxCategorias.ValueMember = "IdCategoria"; // Ajusta esto según el nombre de la columna
        }

        private void btnCargarArchivos_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "Todos los archivos (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string fileName in openFileDialog.FileNames)
                    {
                        listBoxArchivos.Items.Add(fileName);
                    }
                }
            }
        }

        private void btnAbrirArchivo_Click(object sender, EventArgs e)
        {
            if (listBoxArchivos.SelectedItem != null)
            {
                string filePath = listBoxArchivos.SelectedItem.ToString();
                try
                {
                    Process.Start(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo abrir el archivo: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un archivo de la lista.");
            }
        }
    }
}
