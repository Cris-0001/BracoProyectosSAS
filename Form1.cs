using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BracoProyectos
{
    public partial class BracoProyectos : Form
    {
        public BracoProyectos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BracoProyectos_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPagePersonal_Click(object sender, EventArgs e)
        {

        }

        List<string> ListaProyectos = new List<string>();

        private void buttonCrearProyec_Click(object sender, EventArgs e)
        {
            string OT;
            string OC;
            string Cliente;
            string Valor;
            string Producto;
            string Descripcion;
            string Cantidad;

            OT = textBoxOT.Text;
            OC = textBoxOrdenCompra.Text;
            Cliente = comboBoxCliente.Text;
            Valor = textBoxValorProyec.Text;
            Producto = comboBoxProduc.Text;
            Descripcion = textBoxDescripProyec.Text;
            Cantidad = textBoxCantFabricar.Text;

            ListaProyectos.Add(OT);
            ListaProyectos.Add(OC);
            ListaProyectos.Add(Cliente);
            ListaProyectos.Add(Valor);
            ListaProyectos.Add(Producto);
            ListaProyectos.Add(Descripcion);
            ListaProyectos.Add(Cantidad);

            listBoxlistProyec.DataSource = null;
            listBoxlistProyec.DataSource = ListaProyectos;
        }

        private void tabPageProyecto_Click(object sender, EventArgs e)
        {

        }

        private void buttonActualizarProyec_Click(object sender, EventArgs e)
        {
            var OrdenTrabajo = ListaProyectos.IndexOf(textBoxOT.Text);
            ListaProyectos.RemoveAt(OrdenTrabajo);
            ListaProyectos.Insert(OrdenTrabajo, textBoxOrdenCompra.Text);

            listBoxlistProyec.DataSource = null;
            listBoxlistProyec.DataSource = ListaProyectos;


        }
    }
}
