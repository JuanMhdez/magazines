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
    public partial class RegistroAutomatico : Form
    {

        MysqlDatabase database = new MysqlDatabase();

        runcard_wsdlPortTypeClient cliente = new runcard_wsdlPortTypeClient("runcard_wsdlPort");

        BindingList<RegistroSerial> listaSeriales = new BindingList<RegistroSerial>();


        // Número de parte de panel
        string partnumPanel = string.Empty;

        // Cantidad de paneles por numero de partes en magazine
        int cantidadPaneles = 0;

        public RegistroAutomatico()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            txtSerial.Enabled = true;
            txtSerial.Focus();
        }

        public void ingresarPanel()
        {
                           
                // Variables
                string msg = string.Empty;
                int error;
                string carrier_id = string.Empty;

                // Obtener ID del magazine creado
                int idMagazine = database.obtenerIDMagazine(lblMagazine.Text);
                Console.WriteLine("Id magazine " + idMagazine);

                if (idMagazine != -1)
                {

                    if (txtSerial.Text.Trim() != string.Empty)
                    {
                        // Obtenemos el status con la api del serial
                        var statusSerial = cliente.getUnitStatus(txtSerial.Text.Trim(), out error, out msg);

                    Console.WriteLine("Estatus de consulta api "+error+ " " + msg);

                        // Validamos que exista el serial
                        if (error == 0)
                        {


                            // Validamos que la cantidad de paneles este inicializada si ya esta inicializada avanzamos
                            if (cantidadPaneles == 0)
                            {
                                // Validar que la cantidad de piezas de magazine del numero de parte del serial este registrado

                                int cantidadPartNum = database.cantidadMGPartNum(statusSerial.partnum);

                                if (cantidadPartNum == -2)
                                {
                                    MessageBox.Show("La cantidad de unidades del magazine para el número de parte " + statusSerial.partnum + " no está registrado en la base de datos, favor de registrarlo");
                                    txtSerial.Text = string.Empty;
                                    return;
                                }
                                else
                                {
                                    // Inicializamos la variable para no estar reutilizando la consulta a la base de datos
                                    cantidadPaneles = cantidadPartNum;
                                }

                            }

                            // Validamos que todos los seriales sean del mismo número de parte
                            // Inicializamos el número de parte del magazine
                            if (partnumPanel == string.Empty)
                            {
                                partnumPanel = statusSerial.partnum;
                            }
                            else
                            {
                                if (statusSerial.partnum == partnumPanel)
                                {
                                    Console.WriteLine("Si es del mismo número de parte");
                                }
                                else
                                {

                                    Console.WriteLine("Diferente número de parte " + statusSerial.partnum);
                                    MessageBox.Show("El serial es de diferente número de parte " + statusSerial.partnum);
                                    txtSerial.Text = string.Empty;
                                    return;
                                }
                            }


                            // Obtenemos el carrier del serial
                            var carrier = cliente.getCarrierStatus(statusSerial.serial, "AOI_L14", 0, out error, out msg);

                            // Validamos que tenga carrier
                            if (error == 0)
                            {
                                // Igualamos el carrier id de la api con la variable local
                                carrier_id = carrier[0].carrier_id;

                            }
                            else
                            {
                                Console.WriteLine("No tiene serial padre");
                                MessageBox.Show("No tiene serial padre");
                                return;
                            }


                            Console.WriteLine("Carrier ID: " + carrier_id);

                            // Insertamos el serial en la base de datos con su respectivo magazine
                            bool insertado = database.InsertarSerialesMagazine(idMagazine, statusSerial.partnum, carrier_id);

                            // Se valida que se haya insertado en base de datos
                            if (insertado)
                            {
                                Console.WriteLine("Valores insertados");

                                // Guardamos status del magazine
                                string statusMagazine = string.Empty;

                                // Obtenemos los valores de la consulta que devuelve los seriales de un magazine
                                listaSeriales = database.obtenerDatosDeMagazine(lblMagazine.Text, out statusMagazine);

                                // Si la lista no fue vacia se deposita la lista en el datagridview
                                if (listaSeriales.Count > 0)
                                {
                                    // Se carga la lista en la base de datos
                                    dataGridView1.DataSource = listaSeriales;
                                    // Contamos las filas
                                    ContarFilas();

                                    // Validamos que el magazine este lleno
                                    bool magazineLleno = ValidarMagazineLleno();

                                    if (magazineLleno)
                                    {
                                        label5.Text = "Complete";
                                        MessageBox.Show("Magazine lleno!");

                                        // Actualizamos el status del magazine
                                        int cantidadPaneles = Convert.ToInt32(lblCantidad.Text);
                                        actualizarStatusMagazine(cantidadPaneles, idMagazine);



                                        // Reiniciamos el magazine
                                        ReiniciarMagazine();


                                        return;

                                    }

                                    label5.Text = statusMagazine;


                                }
                            else
                            {
                                Console.WriteLine("No se devuelve nada a la lista");
                            }

                            }
                            else
                            {
                                MessageBox.Show("Error al insertar el serial en la base de datos");
                            }

                        }

                    }
                    else
                    {
                        Console.WriteLine("Error con serial");
                    }


                }
                else
                {
                    Console.WriteLine($"No existe el magazine {lblSerialMagazine.Text}");
                }

                txtSerial.Text = string.Empty;

            
        }

        private void txtSerial_KeyDown(object sender, KeyEventArgs e)
        {

           
        }

        public void actualizarStatusMagazine(int cantidad, int idMagazine)
        {

            string status = "Complete";

            database.actualizarStatusTablaMagazine(status, cantidad, idMagazine);
        }

        public bool ValidarMagazineLleno()
        {

            // Funcion para contar la cantidad de seriales en el magazine
            ContarFilas();

            // Convertir la etiqueta en int
            int conteoMagazine = Convert.ToInt32(lblCantidad.Text);

            // Validamos que el magazine este lleno
            if (conteoMagazine == cantidadPaneles)
            {

                return true;

            }
            else
            {
                return false;
            }

        }

        public void ReiniciarMagazine()
        {

            // Reiniciamos el magazinero

            dataGridView1.DataSource = null;

            txtSerial.Text = string.Empty;
            // Como se vacia el datagridview hay que actualizar la etiqueta que cuenta las filas del datagridview
            ContarFilas();
            // Reset partnum de magazine
            partnumPanel = string.Empty;
            // Reset a la cantidad de paneles por magazine
            cantidadPaneles = 0;
            // Limpiamos el magazine
            lblSerialMagazine.Text = string.Empty;
            // Limpiamos magazine
            lblMagazine.Text = "Magazine";
            txtSerial.Enabled = true;

            btnIniciar.Enabled = false;

            label5.Text = "Esperando Panel";




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



        private string GenerarSerialMagazine()
        {

            string serialMagazine = DateTime.Now.ToString("yyMMddHHmmss");


            // Armar el serial: MG + año + mes + segundos
            string serial = $"MG5{serialMagazine}";

            return serial;


        }

        private void txtSerial_TextChanged(object sender, EventArgs e)
        {
            // Si el string contiene "Magazine" indicamos que es un nuevo magazine
            if (lblMagazine.Text == "Magazine")
            {

                // Vamos a crear e ingresar nuevo magazine
                string serialMagazine = GenerarSerialMagazine();
                // Mostramos el serial en la etiqueta
                lblMagazine.Text = serialMagazine;
                // Insertamos en base de datos

                bool insercionNuevoMagazine = database.InsertarNuevoMagazine(serialMagazine);

                if (insercionNuevoMagazine)
                {
                    Console.WriteLine("Magazine ingresado");
                }
                else
                {
                    Console.WriteLine("Error al ingresar magazine");
                }

            }

            // Se inserta

            ingresarPanel();
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
    }
}
