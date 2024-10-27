using System;
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
    public partial class Modificar_Mascota : Form
    {
        private readonly string nombreMascota;

        public Modificar_Mascota(string m)
        {
            Gerente.Leer();
            this.nombreMascota = m;
            InitializeComponent();

            foreach (Mascotas auxM in Gerente.ListaMascota)
            {
                if (nombreMascota == auxM.Nombre)
                {
                    NombreM.Text = auxM.Nombre;
                    PesoM.Text = auxM.Peso.ToString();
                    TipoM.Text = auxM.Soy;
                    DiagM.Text = auxM.Diag;

                }
            }
        }

        private void GUARDAR_Click(object sender, EventArgs e)
        {
            string nombre = NombreN.Text;
            float peso2; //float.Parse(PesoN.Text);

            if (float.TryParse(PesoN.Text, out float peso))
            {
                peso2 = peso;
            }
            else
            {
                MessageBox.Show("Por favor ingrese un valor numérico válido para el peso.");
                return;
            }

            string Tipo = TipoN.Text;
            int aa = int.Parse(AnioN.Text);
            int mm = int.Parse(MesN.Text);
            int dd = int.Parse(DiaN.Text);
            int codigo = 0;
            string diag = DiagN.Text;
            bool con = false;

            for (int i = Gerente.ListaMascota.Count - 1; i >= 0; i--)
            {
                if (nombreMascota == Gerente.ListaMascota[i].Nombre)
                {
                    codigo = Gerente.ListaMascota[i].Codigo;
                    Gerente.ListaMascota.RemoveAt(i);
                    Gerente.Crear_Mascota(nombre, diag, peso2, codigo, dd, mm, aa, Tipo);
                }
            }



            /*List<Mascotas> mascotasAEliminar = new List<Mascotas>();

            foreach (Mascotas mas in Gerente.ListaMascota)
            {
                if (nombreMascota == mas.Nombre)
                {
                    codigo = mas.Codigo;
                    mascotasAEliminar.Add(mas);
                    con = true;
                }
            }
            if (con)
            {
                MessageBox.Show("paso el if1");
                foreach (Mascotas mas in mascotasAEliminar)
                {
                    MessageBox.Show("entro al foreach");
                    if (mas.Codigo == codigo)
                    {
                        MessageBox.Show("paso el if");
                        Gerente.ListaMascota.Remove(mas);
                        Gerente.Crear_Mascota(nombre, diag, peso2, codigo, dd, mm, aa, Tipo);
                    }
                }
            }*/



            /*  foreach (Mascotas auxM in Gerente.ListaMascota)
              {
                  if (nombreMascota == auxM.Nombre)
                  {
                      auxM.Nombre = NombreN.Text;


                      if (float.TryParse(PesoN.Text, out float peso))
                      {
                          auxM.Peso = peso;
                      }
                      else
                      {
                          MessageBox.Show("Por favor ingrese un valor numérico válido para el peso.");
                          return;
                      }

                      auxM.Soy = TipoN.Text;

                      if (TipoN.Text == "Perro")
                      {
                          auxM.getRaza();
                      }
                      else
                      {
                          if (TipoN.Text == "Gato")
                          {

                          }
                          else
                          {

                          }
                      }
                  }
              }*/
            Gerente.guardar();
            MessageBox.Show("Mascota actualizada.");
            this.Close();
        }
    }
}
