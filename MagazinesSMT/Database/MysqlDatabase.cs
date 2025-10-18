using MagazinesSMT.Modelos;
using MagazinesSMT.Runcard;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagazinesSMT
{
    internal class MysqlDatabase
    {

        private string cadenaConexion = "server=localhost;user=root;password=artesanos10;database=magazine;";
       

        public bool InsertarNuevoMagazine(string nombreMagazine)
        {

            string status = "In progress";
            int cantidad = 0;

            using (MySqlConnection conn = new MySqlConnection(cadenaConexion)) {

                try
                {

                    conn.Open();

                    string qry = "INSERT INTO magazines (nombreMagazine,status,cantidad) value (@nombreMagazine,@status,@cantidad)";

                    using (MySqlCommand cmd = new MySqlCommand(qry,conn))
                    {

                        cmd.Parameters.AddWithValue("@nombreMagazine",nombreMagazine);
                        cmd.Parameters.AddWithValue("@status",status);
                        cmd.Parameters.AddWithValue("@cantidad",cantidad);

                        int filas = cmd.ExecuteNonQuery();

                        return filas > 0;

                    }
                }
                catch (MySqlException ex)
                {

                    Console.WriteLine("MySQL error: " + ex.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }          
            }

        }

        // Insertar unidades al magazine

        public bool InsertarSerialesMagazine(int idMagazine, string numeroParte,string serial)
        {

            using (MySqlConnection conn = new MySqlConnection(cadenaConexion))
            {

                try
                {
                    conn.Open();

                   

                    string qry = "INSERT INTO registro_magazines (idmagazine,numeroParte,serial) value (@idMagazine,@numeroParte,@serial)";

                    using (MySqlCommand cmd = new MySqlCommand(qry, conn))
                    {

                        cmd.Parameters.AddWithValue("@idMagazine", idMagazine);
                        cmd.Parameters.AddWithValue("@numeroParte", numeroParte);
                        cmd.Parameters.AddWithValue("@serial", serial);

                        int filas = cmd.ExecuteNonQuery();

                        Console.WriteLine("Datos ingresados!!");

                        return filas > 0;

                    }
                }
                catch (MySqlException ex)
                {

                    Console.WriteLine("MySQL error: " + ex.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }

        }

        // Obtencion de Id de Magazine
        public int obtenerIDMagazine(string magazine) {

            int id = -1;

            string qry = "SELECT idmagazines FROM magazine.magazines where nombreMagazine = @nombreMagazine;";

            using (MySqlConnection conn = new MySqlConnection(cadenaConexion))
            using (MySqlCommand cmd = new MySqlCommand(qry,conn)) {

                cmd.Parameters.AddWithValue("@nombreMagazine", magazine);

                try
                {
                    conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            id = reader.GetInt32(0);

                            Console.WriteLine($"El Id de {magazine} es {id}");

                        }
                        else
                        {
                            Console.WriteLine("No se encontró el usuario.");
                            MessageBox.Show("No se encontró el usuario.");

                        }
                    }

                }
                catch (MySqlException ex)
                {

                    Console.WriteLine("MySQL error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

            }

                return id;
        }

        // Obtener el magazine de un serial

        public List<RegistroSerial> obtenerMagazineDeSerial(string serial)
        {

            List<RegistroSerial> lista = new List<RegistroSerial>();

            string qry = "SELECT m.nombreMagazine,rm.serial,rm.numeroParte,rm.mod_date  FROM registro_magazines as rm inner join magazines as m on rm.idmagazine=m.idmagazines where rm.serial = @serial;";

            using (MySqlConnection conn = new MySqlConnection(cadenaConexion))
            using (MySqlCommand cmd = new MySqlCommand(qry,conn)) {


                cmd.Parameters.AddWithValue("@serial",serial);

                try
                {

                    conn.Open();


                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {

                        if (reader.Read())
                        {

                            lista.Add(new RegistroSerial {
                            
                                NombreMagazine = reader.GetString(0),
                                Serial = reader.GetString(1),
                                NumParte = reader.GetString(2),
                                Mod_date = reader.GetDateTime(3),

                            
                            
                            });


                            foreach (var item in lista) {

                                Console.WriteLine($"Magazine: {item.NombreMagazine}, Serial: {item.Serial}, Número de parte {item.NumParte}, Fecha de operación {item.Mod_date} ");
                                                  
                            }

                        }
                        else {


                            Console.WriteLine("No se encontro magazine para este panel");
                            MessageBox.Show("No se encontro magazine para este panel");

                        }

                    }
                }
                catch (MySqlException ex)
                {

                    Console.WriteLine("MySQL error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }


            }


                return lista;
        }

        // Obtencion de Id de Magazine
        public int cantidadMGPartNum(string PartNum)
        {

            


            int cantidad = -2;

            string qry = "SELECT CantidadMG FROM magazine.partnums where PartNum = @PartNum;";


            using (MySqlConnection conn = new MySqlConnection(cadenaConexion))
            using (MySqlCommand cmd = new MySqlCommand(qry, conn))
            {

                cmd.Parameters.AddWithValue("@PartNum", PartNum);

                try
                {

                    conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            cantidad = reader.GetInt32(0);

                            Console.WriteLine($"Cantidad que tiene por magazine el número de parte {PartNum} es {cantidad}");

                        }
                        else
                        {
                            MessageBox.Show("No esta registrada la cantidad de unidades para este numero de parte");

                        }
                    }

                }
                catch (MySqlException ex)
                {

                    Console.WriteLine("MySQL error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

            }

            return cantidad;
        }


        // Datos de tabla
        public BindingList<RegistroSerial> obtenerDatosDeMagazine(string nombreMagazine,out string status)
        {

            BindingList<RegistroSerial> serialSerial = new BindingList<RegistroSerial>();

            string statusDB = string.Empty;

            string qry = "select m.nombreMagazine,rm.serial,rm.numeroParte,rm.mod_date, m.status from registro_magazines as rm inner join magazines as m on rm.idmagazine=m.idmagazines where m.nombreMagazine = @nombreMagazine;";

            using (MySqlConnection conn = new MySqlConnection(cadenaConexion))
            using (MySqlCommand cmd = new MySqlCommand(qry, conn))
            {

                cmd.Parameters.AddWithValue("@nombreMagazine", nombreMagazine);

                try
                {

                    conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            serialSerial.Add(new RegistroSerial
                            {
                                NombreMagazine = reader.GetString(0),
                                Serial = reader.GetString(1),
                                NumParte = reader.GetString(2),
                                Mod_date = reader.GetDateTime(3)

                            });
                            statusDB = reader.GetString(4);

                        }

                    }

                    foreach (RegistroSerial item in serialSerial)
                    {
                        Console.WriteLine(item.NombreMagazine.ToString());
                        Console.WriteLine(item.Serial.ToString());
                        Console.WriteLine(item.NumParte.ToString());
                        Console.WriteLine(item.Mod_date.ToString()); 
                    }

                }
                catch (MySqlException ex)
                {

                    Console.WriteLine("MySQL error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            // Devolvemos el status
            status = statusDB;
            // Devolvemos la lista
            return serialSerial;

        }

        // Actualizar una vez este completo el magazine
        public void actualizarStatusTablaMagazine(string status, int cantidad,int idMagazine) {

            string qry = "UPDATE magazines SET status = @status, cantidad = @cantidad WHERE (idmagazines = @idMagazine);";


            using (MySqlConnection conn = new MySqlConnection(cadenaConexion))
            using (MySqlCommand cmd = new MySqlCommand(qry,conn)) {


                cmd.Parameters.AddWithValue("@status",status);
                cmd.Parameters.AddWithValue("@cantidad",cantidad);
                cmd.Parameters.AddWithValue("@idMagazine", idMagazine);

                try
                {
                    conn.Open();

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas == 0)
                    {
                        Console.WriteLine("No se actualizó ninguna fila. Verifica el ID.");
                    }

                    Console.WriteLine("Magazine actualizado");

                }
                catch (MySqlException ex)
                {

                    Console.WriteLine("MySQL error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

            }
             
        }

        public bool EliminarMagazine(string magazine)
        {

            // Obtenemos el ID

            int id = obtenerIDMagazine(magazine);

            Console.WriteLine($"Id magazine {id}");

            if (id != -1)
            {

                string qry = "DELETE FROM magazine.registro_magazines WHERE idMagazine = @id;";

                using (MySqlConnection conn = new MySqlConnection(cadenaConexion))
                using (MySqlCommand cmd = new MySqlCommand(qry, conn))
                {

                    cmd.Parameters.AddWithValue("@id", id);

                    try
                    {

                        conn.Open();
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        return filasAfectadas > 0;

                    }
                    catch (MySqlException ex)
                    {

                        MessageBox.Show("Error al eliminar el registro." + ex.Message);
                        Console.WriteLine(ex.Message);
                        return false;
                    }
                }

            }
            else
            {
                MessageBox.Show($"Magazine sin id {id}");
                return false;
            }

        }

         public bool EliminarMagazineMagazines(string magazine)
        {

            // Obtenemos el ID


                string qry = "delete from magazines where nombreMagazine = @magazine;";

                using (MySqlConnection conn = new MySqlConnection(cadenaConexion))
                using (MySqlCommand cmd = new MySqlCommand(qry, conn))
                {

                    cmd.Parameters.AddWithValue("@magazine", magazine);

                    try
                    {

                        conn.Open();
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        return filasAfectadas > 0;

                    }
                    catch (MySqlException ex)
                    {

                        MessageBox.Show("Error al eliminar el registro." + ex.Message);
                        Console.WriteLine(ex.Message);
                        return false;
                    }
                }


        }

        public bool EliminarPiezaMagazine(string serial)
        {

            // Obtenemos el ID
                string qry = "DELETE FROM magazine.registro_magazines WHERE serial = @serial;";

                using (MySqlConnection conn = new MySqlConnection(cadenaConexion))
                using (MySqlCommand cmd = new MySqlCommand(qry, conn))
                {

                    cmd.Parameters.AddWithValue("@serial", serial);

                    try
                    {

                        conn.Open();
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        return filasAfectadas > 0;

                    }
                    catch (MySqlException ex)
                    {

                        MessageBox.Show("Error al eliminar la pieza del magazine." + ex.Message);
                        Console.WriteLine(ex.Message);
                        return false;
                    }

                }

        }

    }
}
