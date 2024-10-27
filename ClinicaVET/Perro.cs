using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaVET
{
    [Serializable]
    class Perro : Mascotas
     {
        private String raza;
        private String razad;
        public Perro(string nm, string di, float pe, int c, Fecha f,string t): base(c,nm,pe,di,f, t)
        {
            this.raza = Microsoft.VisualBasic.Interaction.InputBox("Ingresar dato: ", "RAZA");
            this.Soy = "Perro";
        }

       /* public override string getrazad()
        {
            this.raza = Microsoft.VisualBasic.Interaction.InputBox("Ingresar dato: ", "RAZA");

            return raza;
        }*/

        public override String getRaza()
        {
            this.raza = Microsoft.VisualBasic.Interaction.InputBox("Ingresar dato: ", "RAZA");

            return raza;
        }
     }
}
