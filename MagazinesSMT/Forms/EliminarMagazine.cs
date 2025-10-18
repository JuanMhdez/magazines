using MagazinesSMT.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagazinesSMT.Forms
{
    public partial class EliminarMagazine : Form
    {
        // Instancia de la clase MysqlDatabase
        MysqlDatabase database = new MysqlDatabase();
        // Status del magazine
        string status = string.Empty;

        BindingList<RegistroSerial> magazin = new BindingList<RegistroSerial>();


        public EliminarMagazine()
        {
            InitializeComponent();
        }

        private void txtEliminarMagazine_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                BindingList<RegistroSerial> magazin = new BindingList<RegistroSerial>();
                // Mandamos a llamar al magazine a eliminar

                magazin = database.obtenerDatosDeMagazine(txtEliminarMagazine.Text,out status);
                if (magazin.Count > 0)
                {
                    dataGridView1.DataSource = magazin;
                    btnEliminar.Enabled = true;
                    //EstiloDatagrid();
                }

            }
        }

        public void EstiloDatagrid()
        {

            //dataGridView1.AutoGenerateColumns = false;
            //dataGridView1.Columns.Clear();

            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.EnableHeadersVisualStyles = false;
            // se establece el color del encabezado
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Black; // <- mismo color


            // Encabezados
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 16, FontStyle.Bold);

            // Filas
            //dataGridView1.DefaultCellStyle.BackColor = Color.White;
            //dataGridView1.DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 16);
            // Opciones para seleccionar toda la fila
            //dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Blue;
            //dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;

            // Alternar color filas
            //dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Ajustar altura de filas y columnas 
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.ColumnHeadersHeight = 35;

            // Otros detalles 
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeRows = false;

            // Quitar cursor
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
            dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            EstiloDatagrid();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            // DELETE FROM magazine.registro_magazines WHERE idMagazine = (select idmagazines from magazines where nombreMagazine = 'MG5250923081237');
           bool result = database.EliminarMagazine(txtEliminarMagazine.Text);

            Console.WriteLine(result);

            if (result)
            {

                bool resultaEliminarMagazine = database.EliminarMagazineMagazines(txtEliminarMagazine.Text);

                if (resultaEliminarMagazine)
                {
                    MessageBox.Show("Magazine elimina de magazines");
                    dataGridView1.DataSource = null;

                }
                else
                {
                    MessageBox.Show("Magazine no eliminado");
                }


            }

            txtEliminarMagazine.Text = string.Empty;
        }

        private void txtMagazine_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                // Mandamos a llamar al magazine a eliminar

                magazin = database.obtenerDatosDeMagazine(txtMagazine.Text, out status);


                if (magazin.Count > 0)
                {
                    dataGridView1.DataSource = magazin;
                    txtMagazine.Enabled = false;
                    txtSerial.Enabled = true;
                }            

            }
        }

        private void txtSerial_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                Console.WriteLine();
                List<string> listaSeriales = new List<string>();

                for (int i = 0; i < magazin.Count; i++)
                {
                    Console.WriteLine(magazin[i].Serial);

                    listaSeriales.Add(magazin[i].Serial);
                }

              bool result =  database.EliminarPiezaMagazine(txtSerial.Text);

                if (result)
                {
                    Console.WriteLine("Pieza Eliminada");

                    magazin = database.obtenerDatosDeMagazine(txtMagazine.Text, out status);

                    dataGridView1.DataSource = magazin;


                }
                else
                {
                    MessageBox.Show("Error al eliminar la pieza");
                }
               


            }

            txtSerial.Text = string.Empty;


        }
    }
}
