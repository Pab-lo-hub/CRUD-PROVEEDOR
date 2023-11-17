using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_PROVEEDOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Clases.CProveedores objetoProveedores = new Clases.CProveedores();
            objetoProveedores.mostrarProveedores(dgvproveedores);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Clases.CProveedores objetoProvedores = new Clases.CProveedores();
            objetoProvedores.guardarProveedores(txtrazonsocial, txtcuit);
            objetoProvedores.mostrarProveedores(dgvproveedores);
        }

        private void dgvproveedores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Clases.CProveedores objetoProvedores = new Clases.CProveedores();
            objetoProvedores.seleccionarProveedores(dgvproveedores, txtid, txtrazonsocial, txtcuit);
        }

        private void btmodificar_Click(object sender, EventArgs e)
        {
            Clases.CProveedores objetoProvedores = new Clases.CProveedores();
            objetoProvedores.modificarProveedores(txtid,txtrazonsocial, txtcuit);
            objetoProvedores.mostrarProveedores(dgvproveedores);
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Clases.CProveedores objetoProvedores = new Clases.CProveedores();
            objetoProvedores.eliminarProveedores(txtid);
            objetoProvedores.mostrarProveedores(dgvproveedores);
        }
    }
}
