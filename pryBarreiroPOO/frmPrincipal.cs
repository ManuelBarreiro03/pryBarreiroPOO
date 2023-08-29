using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBarreiroPOO
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblInfo.Text += Environment.NewLine;
        }

        private void cmdCrear_Click(object sender, EventArgs e)
        {
            ClassPersonaje objeto = new ClassPersonaje();
            objeto.Fuerza = Convert.ToInt32(txtFuerza.Text);
            objeto.Destreza = Convert.ToInt32(txtDestreza.Text);
            objeto.nombre = txtNombre.Text;
            lblInfo.Text += objeto.nombre + "-" + objeto.Destreza + "-" + objeto.Fuerza + Environment.NewLine;
        }
    }
}
