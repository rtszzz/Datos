using System;
using System.IO;
using System.Windows.Forms;

namespace Datos
{
    public partial class Form1 : Form
    {
        Nombres[] a;
        int p = 0;
        public Form1()
        {
            InitializeComponent();
            a = new Nombres[2];

        }

        private void btnAbrir_Click(object sender, EventArgs e);
        {
        OpenFileDialog dialogo = new OpenFileDialog();
        if (dialogo.showDialog() == DialogResult.Ok)
            {
            //MessageBox.Show(dialogo.FileName);
            using (StreamWriter archivo = new StreamWriter(Path.combine(dialogo.FileName)))
            for (int i = 0; i< a.length; i++)
			{
               archivo.WriteLineAsync(a [i].ToString()));
			}
private void btninsertar_Click(object sender, EventArgs e)
        {
            Nombres a = new Nombres();
            n.nombre = txtNombre.Text;
            n.Apellido = txtApellido.Text;

            a[p] = n;

            1stArreglo.Items.Add(a[p]);
            p++;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
        }
    }
    

