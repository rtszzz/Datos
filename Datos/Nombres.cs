using System;
using .IO;
using System.Windows.Forms;

namespace Datos
{
    class Nombres
    {
        private string nombre;
        private string apellido;

        public string apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public Nombres()
        {
            nombre = "";
            apellido = "";
        }
        public override string ToString()
        {
            return nombre + "-" + apellido;
        }
    }
}
