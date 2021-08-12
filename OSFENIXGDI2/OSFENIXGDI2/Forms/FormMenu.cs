using OSFENIXGDI2.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSFENIXGDI2
{
    public partial class Menú : Form
    {
        public Menú()
        {
            InitializeComponent();
        }

        private void Menú_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void RegistrarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistrarProducto FormRegistrarProducto = new FormRegistrarProducto();
            FormRegistrarProducto.ShowDialog();
            
        }

        private void ClienteConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarCLienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistrarCliente FormRegistrarCliente = new FormRegistrarCliente();
            FormRegistrarCliente.ShowDialog();
        }
    }
}
