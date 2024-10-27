using Microsoft.VisualBasic.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaVET
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RCliente Registro_cliente = new RCliente();
            Registro_cliente.ShowDialog();
        }

        private void cantidadDeDineroRecaudadoEnUnaFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gerente.Leer();
            planteamiento1 P1 = new planteamiento1();
            P1.ShowDialog();
        }

        private void totalRecaudadoPorUnClienteDadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gerente.Leer();
            float monto = 0;
            String aux =  Microsoft.VisualBasic.Interaction.InputBox("Identificacion", "Cliente");
            int id = int.Parse(aux);

            foreach(Cliente cliente in Gerente.ListaCliente)
            {
                if ( cliente.getID() == id)
                {
                    foreach(Servicio servicio in cliente.historial)
                    {
                        monto += servicio.monto;
                    }
                }
            }

            if ( monto == 0 )
            {
                MessageBox.Show("El cliente no existe");
            }
            else
            {
                MessageBox.Show("El monto recaudado es: "+monto.ToString());
            }
        }

        private void listarLasMascotasDeUnClienteDadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gerente.Leer();
            Gerente.op = 1;
            Listar P3 = new Listar();
            P3.ShowDialog();
        }

        private void listaLosPerrosPorRazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gerente.Leer();
            RazaL P4 = new RazaL();
            P4.ShowDialog();
        }

        private void listarTodosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gerente.Leer();
            Gerente.op = 2;
            Listar P5 = new Listar();
            P5.ShowDialog();
        }

        private void listarLasConsultasPorRangoDeFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gerente.Leer();
            PorFecha P6 = new PorFecha();
            P6.ShowDialog();
        }

        private void borrarTodosLosDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nivel;
            nivel = Microsoft.VisualBasic.Interaction.InputBox(" Ingrese 'si' Si decea borrar los datos y 'no' para no borrar ", "SEGURO DE QUERER BORRAR LOS DATOS ");

            if (nivel == "si" || nivel == "Si" || nivel == "SI")
            {
                Gerente.Leer();

                Gerente.ListaCliente.Clear();
                Gerente.ListaMascota.Clear();

                Gerente.guardar();
            }
        }
        private void mascotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gerente.Leer();
            Datos_Mascota datos_Mascota = new Datos_Mascota();
            datos_Mascota.ShowDialog();
            Gerente.guardar();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gerente.Leer();
            bool cent = true;
            String aux = Microsoft.VisualBasic.Interaction.InputBox("Identificacion", "Cliente");
            int id = int.Parse(aux);

            foreach (Cliente cliente in Gerente.ListaCliente)
            {
                if (cliente.getID() == id)
                {
                    Modificar_Datos Modificar = new Modificar_Datos();
                    Modificar.ShowDialog();
                    cent = false;

                    Gerente.guardar();
                    }
            }
            if (cent)
            {
                MessageBox.Show("El cliente no existe");
            }
        }
    }
}
