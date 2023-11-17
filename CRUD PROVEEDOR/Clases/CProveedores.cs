using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_PROVEEDOR.Clases
{
    internal class CProveedores
    {
        public void mostrarProveedores(DataGridView tablaProveedores)
        {
            try
            {
                CConexion objetocConexion = new CConexion();
                string query = "select * from proveedores";
                tablaProveedores.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetocConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaProveedores.DataSource = dt;
                objetocConexion.cerrarConexion();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se mostraron los datos de la base de datos, error: " + ex.ToString());
            }
        }


        public void guardarProveedores(TextBox razonsocial, TextBox cuit)
        {
            try
            {
                CConexion objetocConexion = new CConexion();
                string query = "insert into proveedores(RazonSocial, Cuit)"+
                    "values('"+ razonsocial.Text+ "','"+cuit.Text+"');";
                
                MySqlCommand myComand = new MySqlCommand(query, objetocConexion.establecerConexion());
                MySqlDataReader reader = myComand.ExecuteReader();
                MessageBox.Show("Se guardo los registros");
                while(reader.Read())
                {

                }
                objetocConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se mostraron los datos de la base de datos, error: " + ex.ToString());
            }
        }



        public void seleccionarProveedores(DataGridView tablaProveedores,TextBox id ,TextBox razonsocial, TextBox cuit)
        {
            try
            {
                id.Text = tablaProveedores.CurrentRow.Cells[0].Value.ToString();
                razonsocial.Text = tablaProveedores.CurrentRow.Cells[1].Value.ToString();
                cuit.Text = tablaProveedores.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro seleccionar, error: " + ex.ToString());
            }
        }

        public void modificarProveedores(TextBox id,TextBox razonsocial, TextBox cuit)
        {
            try
            {
                CConexion objetocConexion = new CConexion();
                string query = "update proveedores set RazonSocial='" +
                    razonsocial.Text + "', Cuit='" + cuit.Text + "' where id ='" + id.Text + "';";

                MySqlCommand myComand = new MySqlCommand(query, objetocConexion.establecerConexion());
                MySqlDataReader reader = myComand.ExecuteReader();
                MessageBox.Show("Se modifico correctamente los registros");
                while (reader.Read())
                {

                }
                objetocConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se actualizaron los datos de la base de datos, error: " + ex.ToString());
            }
        }


        public void eliminarProveedores(TextBox id)
        {
            try
            {
                CConexion objetocConexion = new CConexion();
                string query = "delete from proveedores where id='"+id.Text+"';";
                   

                MySqlCommand myComand = new MySqlCommand(query, objetocConexion.establecerConexion());
                MySqlDataReader reader = myComand.ExecuteReader();
                MessageBox.Show("Se elimino correctamente los registros");
                while (reader.Read())
                {

                }
                objetocConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se eliminaron los datos de la base de datos, error: " + ex.ToString());
            }
        }



    }
}
