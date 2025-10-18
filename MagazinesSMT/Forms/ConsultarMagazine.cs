using MagazinesSMT.Modelos;
using MagazinesSMT.Runcard;
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



    public partial class ConsultarMagazine : Form
    {
        BindingList<RegistroSerial> listMG = new BindingList<RegistroSerial>();

        runcard_wsdlPortTypeClient cliente = new runcard_wsdlPortTypeClient("runcard_wsdlPort");


        MysqlDatabase database = new MysqlDatabase();

        public ConsultarMagazine()
        {
            InitializeComponent();
        }

        private void btnConsultarMagazine_Click(object sender, EventArgs e)
        {

            if (txtMagazine.Text.Trim() != string.Empty)
            {

                // Obtenemos status del magazine
                string statusMagazine = string.Empty;
                // LLenamos la lista con los datos de la consulta a la BD
              listMG = database.obtenerDatosDeMagazine(txtMagazine.Text.Trim(),out statusMagazine);

                if (listMG.Count > 0)
                {
                    dataGridView1.DataSource = listMG;

                    // Ver el status
                    label5.Text  = statusMagazine;

                    // Contamos filas
                    ContarFilas();
                    txtMagazine.Text = string.Empty;

                }
                else
                {
                    MessageBox.Show("No se encontraron registros");
                    txtMagazine.Text = string.Empty;
                }

            }
            else
            {
                MessageBox.Show("Campo vacio");
            }

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            EstiloDatagrid();
        }


        public void EstiloDatagrid()
        {
            //  dataGridView1.AutoGenerateColumns = false;
            //dataGridView1.Columns.Clear();

            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.EnableHeadersVisualStyles = false;

            // Encabezados
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 16, FontStyle.Bold);

            // Filas
            // dataGridView1.DefaultCellStyle.BackColor = Color.White;
            //  dataGridView1.DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 16);
            // dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            //  dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;

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

        public void ContarFilas()
        {


            int contarFilas = dataGridView1.Rows.Count;
            Console.WriteLine("Cantidad de filas: " + contarFilas);

            if (contarFilas != 0)
            {
                lblCantidad.Text = contarFilas.ToString();
            }
            else if (contarFilas == 0)
            {

                lblCantidad.Text = Convert.ToString("0");
            }

        }

        private void btnConsultarPanel_Click(object sender, EventArgs e)
        {

            List<RegistroSerial> lista = new List<RegistroSerial>();

            if (txtSerialPanel.Text.Trim() != string.Empty)
            {

                int error;
                string msg = string.Empty;

                var padre = cliente.getCarrierStatus(txtSerialPanel.Text.Trim(), "AOI_L14", 0, out error, out msg);

                lista = database.obtenerMagazineDeSerial(padre[0].carrier_id);

                if (lista.Count > 0)
                {
                    dataGridView1.DataSource = lista;

                    txtSerialPanel.Text = string.Empty;
                    ContarFilas();
                }
                else
                {
                    MessageBox.Show("Error no se obtuvo magazine");
                }

              


            }
            else
            {
                MessageBox.Show("Campo vacio");
            }


        }
    }
}
