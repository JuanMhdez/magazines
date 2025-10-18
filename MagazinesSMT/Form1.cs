using MagazinesSMT.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagazinesSMT
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();   
        }

        private void AbrirFormRegistrarMagazine(Form formRegistrar)
        {
            // Se limpia panel
            pTrabajo.Controls.Clear();

            // Ajustar propiedasde
            formRegistrar.TopLevel = false;
            formRegistrar.FormBorderStyle = FormBorderStyle.None;
            formRegistrar.Dock = DockStyle.Fill;

            // Agregar el formulario al panel
            pTrabajo.Controls.Add(formRegistrar);
            pTrabajo.Tag = formRegistrar;

            formRegistrar.Show();
        }

        private void AbrirFormRegistroAutomatico(Form formAutomatico)
        {
            // Se limpia panel
            pTrabajo.Controls.Clear();

            // Ajustar Propiedades
            formAutomatico.TopLevel = false;
            formAutomatico.FormBorderStyle = FormBorderStyle.None;
            formAutomatico.Dock = DockStyle.Fill;

            // Agregar el formulario al panel
            pTrabajo.Controls.Add(formAutomatico);
            pTrabajo.Tag = formAutomatico;

            formAutomatico.Show();

        }


        private void AbrirConsultarMagazine(Form formConsultar) {
        
            // Se limpia panel
            pTrabajo.Controls.Clear();

            // Ajustar propiedades
            formConsultar.TopLevel = false;
            formConsultar.FormBorderStyle = FormBorderStyle.None;
            formConsultar.Dock = DockStyle.Fill;

            // Agregar el formulario al panel
            pTrabajo.Controls.Add(formConsultar);
            pTrabajo.Tag = formConsultar;

            formConsultar.Show();


        }

        private void AbrirEliminarMagazine(Form formEliminar)
        {
            // Se limpia panel
            pTrabajo.Controls.Clear();

            // Ajustar propiedades
            formEliminar.TopLevel = false;
            formEliminar.FormBorderStyle = FormBorderStyle.None;
            formEliminar.Dock = DockStyle.Fill;

            // Agregar el formularioal panel
            pTrabajo.Controls.Add(formEliminar);
            pTrabajo.Tag = formEliminar;

            formEliminar.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormRegistrarMagazine(new Registrar());
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            AbrirConsultarMagazine(new ConsultarMagazine());
        }

        private void btnEliminarMagazine_Click(object sender, EventArgs e)
        {
            AbrirEliminarMagazine(new EliminarMagazine());
        }

        private void btnMagazine_Click(object sender, EventArgs e)
        {
            AbrirFormRegistroAutomatico(new RegistroAutomatico());
        }
    }
}
