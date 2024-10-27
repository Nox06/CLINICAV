using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClinicaVET
{
    public partial class Datos_Mascota : Form
    {
        int ind;
        public Datos_Mascota()
        {
            int id;
            InitializeComponent();
            if (true)
            {
                id = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Identificacion"));
                ind = id;
                List<String> nomMas = new List<String>();
                bool centinela = false;

                foreach (Cliente cli in Gerente.ListaCliente)
                {
                    if (cli.getID() == id)
                    {
                        centinela = true;
                        foreach (Servicio ser in cli.historial)
                        {
                            foreach (Mascotas mas in Gerente.ListaMascota)
                            {
                                if (ser.codigo == mas.Codigo)
                                {
                                    bool cent = false;
                                    foreach (String n in nomMas)
                                    {
                                        if (n == mas.Nombre)
                                        {
                                            cent = true;
                                        }
                                    }
                                    if (cent == false)
                                    {
                                        nomMas.Add(mas.Nombre);

                                    }
                                }
                            }
                        }
                    }
                }

                if (centinela)
                {
                    this.Text = "Cambiar Datos de Mascota";
                    TITULO.Text = "Lista de Mascotas";
                    foreach (String n in nomMas)
                    {
                        Lista.Items.Add(n);
                    }
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado");
                }
            }
        }

        public void Lista_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem seleccionado = Lista.SelectedItems[0];
            string nombreMascota = seleccionado.Text;

            Modificar_Mascota nuevoFormulario = new Modificar_Mascota(nombreMascota);
            nuevoFormulario.Show();
           

        }
        public void ActualizarListView()
        {
            Lista.Items.Clear();
            List<String> nomMas2 = new List<String>();

            bool centinela = false;

            foreach (Cliente cli in Gerente.ListaCliente)
            {
                if (cli.getID() == ind)
                {
                    centinela = true;
                    foreach (Servicio ser in cli.historial)
                    {
                        foreach (Mascotas mas in Gerente.ListaMascota)
                        {
                            if (ser.codigo == mas.Codigo)
                            {
                                bool cent = false;
                                foreach (String n in nomMas2)
                                {
                                    if (n == mas.Nombre)
                                    {
                                        cent = true;
                                    }
                                }
                                if (cent == false)
                                {
                                    nomMas2.Add(mas.Nombre);

                                }
                            }
                        }
                    }
                }
            }

            if (centinela)
            {
                this.Text = "Cambiar Datos de Mascota";
                TITULO.Text = "Lista de Mascotas";
                foreach (String n in nomMas2)
                {
                    Lista.Items.Add(n);
                }
            }
            else
            {
                MessageBox.Show("Cliente no encontrado");
            }
           /* foreach (Mascotas mascota in Gerente.ListaMascota)
            {
                ListViewItem item = new ListViewItem(mascota.Nombre);
                item.SubItems.Add(mascota.Nombre);
                item.SubItems.Add(mascota.Tipo);
                Lista.Items.Add(item);
            }*/
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Gerente.Leer();
            ActualizarListView();
        }
    }
}
