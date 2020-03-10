using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Dado
    {
        public int numFaces { get; set; }
        private String valueFace { get; set; }
        private String nameDado { get; set; }

        public Dado(int faces, String value, String nome)
        {
            this.numFaces = faces;
            this.valueFace = value;
            this.nameDado = nome;
        }

        public String Lancar()
        {
            String resultado;

            Random random = new Random();
            resultado = random.Next(this.numFaces + 1).ToString();

            return resultado;
        }


    }
}
