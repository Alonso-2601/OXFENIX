using OSFENIXGDI2.Datos;
using OSFENIXGDI2.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace OSFENIXGDI2.Forms
{
    public partial class FormRegistrarProducto : Form
    {
        private bool existeProducto;
        public FormRegistrarProducto()
        {
            InitializeComponent();
            ConsultarProducto();
            existeProducto = false;
        }

        private void ConsultarProducto()
        {
            try
            {
                // 1. abrir conexión con la base de datos
                ConexionBaseDatos conexionBaseDatos = new ConexionBaseDatos();
                conexionBaseDatos.AbrirConexion();

                // 2. ejecutar consulta
                ProductoDAO ProductoDAO = new ProductoDAO(conexionBaseDatos);
                List<Producto> listaDeProductos = ProductoDAO.ConsultarProducto();

                // 3. mostrar los datos de la consulta              

                tablaPRODUCTO.Rows.Clear();
                foreach (Producto producto in listaDeProductos)
                {
                    Object[] registroProducto = { producto.Id_prod, producto.Nombre, producto.Descrip_prod, producto.Composicion, producto.Fechafabricacion };
                    tablaPRODUCTO.Rows.Add(registroProducto);
                }



                // 4. cerrar conexión
                conexionBaseDatos.CerrarConexion();
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

}
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BUSCAR_Click(object sender, EventArgs e)
        {
            string id_prod = txtcod.Text;

            try
            {
                // 1. abrir conexión con la base de datos
                ConexionBaseDatos conexionBaseDatos = new ConexionBaseDatos();
                conexionBaseDatos.AbrirConexion();

                // 2. ejecutar consulta
                ProductoDAO productoDAO = new ProductoDAO(conexionBaseDatos);
                Producto producto = productoDAO.BuscarProducto(id_prod);

                // 3. mostrar los datos de la consulta
                if (producto != null)
                {
                    
                   
                    txtNombre.Text = producto.Nombre;
                    txtCompo.Text = producto.Composicion;
                    txtDescp.Text = producto.Descrip_prod;
                    txtfechacreacion.Text= producto.Fechafabricacion;
                    existeProducto = true;
                }
                else
                {
                    MessageBox.Show(this, "No se encuentra el Producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    existeProducto = false;
                }

                // 4. cerrar conexión
                conexionBaseDatos.CerrarConexion();
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            int id_prod;
            string nombre;
            string composicion;
            string descrip_prod;
            string fechafabricacion;


            nombre = txtNombre.Text.Trim();
            
            composicion = txtCompo.Text.Trim();

            descrip_prod = txtDescp.Text.Trim();

            fechafabricacion = txtfechacreacion.Text.Trim();

            // 1. validar datos de entrada

            if ( nombre.Length == 0)
            {
                MessageBox.Show(this, "El nombre es un dato obligatorio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                id_prod = int.Parse(txtcod.Text);
            }
            catch
            {
                MessageBox.Show(this, "El codigo es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           

   
            try
            {
                // 2. abrir conexión con la base de datos
                ConexionBaseDatos conexionBaseDatos = new ConexionBaseDatos();
                conexionBaseDatos.AbrirConexion();

                // 3. ejecutar operación
                int registro;
                Producto producto= new Producto(id_prod,nombre, descrip_prod, composicion,fechafabricacion);
                ProductoDAO productoDAO = new ProductoDAO(conexionBaseDatos);
                if (existeProducto)
                    registro = productoDAO.ActualizarProducto(producto);
                else
                    registro = productoDAO.InsertarProducto(producto);

                if (registro == 1)
                    MessageBox.Show(this, "Se ha guardado el Producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(this, "No se ha guardado ningún video.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // 4. cerrar conexión
                conexionBaseDatos.CerrarConexion();

                // 5. limpiar ventana
                txtcod.Text = "";
                txtCompo.Text = "";
                txtDescp.Text = "";
                txtfechacreacion.Text = "";
                txtNombre.Text = "";
                existeProducto = false;

                // 6. consultar todos los videos
                ConsultarProducto();
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tablaPRODUCTO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormRegistrarProducto_Load(object sender, EventArgs e)
        {
           

        }

        private void timepickercreacion_ValueChanged(object sender, EventArgs e)
        {

        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            int id_prod;
            id_prod = int.Parse(txtcod.Text);


            try
            {
                // 1. abrir conexión con la base de datos
                ConexionBaseDatos conexionBaseDatos = new ConexionBaseDatos();
                conexionBaseDatos.AbrirConexion();

                // 2. ejecutar operación


                ProductoDAO productoDAO = new ProductoDAO(conexionBaseDatos);
                int registro = productoDAO.EliminarProducto(id_prod);

                if (registro == 1)
                    MessageBox.Show(this, "Se ha eliminado el producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(this, "No se ha eliminado ningún producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // 7. cerrar conexión
                conexionBaseDatos.CerrarConexion();

                // 8. limpiar ventana
                txtcod.Text = "";
                txtCompo.Text = "";
                txtDescp.Text = "";
                txtfechacreacion.Text = "";
                txtNombre.Text = "";
                txtcod.Focus();
                existeProducto = false;

                // 9. consultar todos los videos
                ConsultarProducto();
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtcod_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
