using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaVET
{
    [Serializable]
    class Ave : Mascotas
    {
        private bool capacidadVuelo;

        public Ave(string nm, string di, float pe, int c, Fecha f, string t) : base(c, nm, pe, di, f, t)
        {
            string nivel;
            nivel = Microsoft.VisualBasic.Interaction.InputBox("Ingresar dato: ", "Capacidad de vuelo");
            this.capacidadVuelo = bool.Parse(nivel);
            this.Soy = "Ave";
        }
    }
}
