using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMarzo22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           MessageBox.Show( Class1.cadena);
            //comentario tercero

            //comentario añadido

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1.Funcion1();
            MessageBox.Show( "zsdfg");
            //a ver como todo lo demás va
        }
    }
}
