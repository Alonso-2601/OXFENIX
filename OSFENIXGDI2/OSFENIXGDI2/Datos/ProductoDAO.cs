using OSFENIXGDI2.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSFENIXGDI2.Datos
{
    class ProductoDAO
    {
        private ConexionBaseDatos conexionBaseDatos;

        public ProductoDAO(ConexionBaseDatos conexionBaseDatos)
        {
            this.conexionBaseDatos = conexionBaseDatos;
        }

        public List<Producto> ConsultarProducto()
        {
            try
            {
                // 1. crear el objeto comando y asignar propiedades
                SqlCommand objetoComando = conexionBaseDatos.obtenerComandoDeProcedimiento("producto_datos");

                // 2. obtener lista de videos
                SqlDataReader registrosDeProductos = objetoComando.ExecuteReader();
                List<Producto> listaDeProductos = new List<Producto>();
                Producto Producto;
                while (registrosDeProductos.Read())
                {
                    Producto = new Producto
                    {
                        Id_prod = registrosDeProductos.GetInt32(0),
                        Nombre = registrosDeProductos.GetString(1),
                        Descrip_prod = registrosDeProductos.GetString(2),
                        Composicion = registrosDeProductos.GetString(3),
                        Fechafabricacion = registrosDeProductos.GetString(4)
                    };
                    listaDeProductos.Add(Producto);
                }

                // 3. retornar lista de videos consultados
                return listaDeProductos;
            }
            catch
            {
                throw new Exception("Error: No se pudieron consultar el producto");
            }
        }

        public Producto BuscarProducto(string id_prod)
        {
            try
            {
                // 1. crear el objeto comando
                SqlCommand objetoComando = conexionBaseDatos.obtenerComandoDeProcedimiento("producto_buscar");

                // 2. asignar el parámetro
                objetoComando.Parameters.AddWithValue("@Id_prod", id_prod);

                // 3. obtener video
                SqlDataReader BuscarProducto = objetoComando.ExecuteReader();
                Producto producto = null;
                if (BuscarProducto.Read())
                {
                    producto = new Producto
                    {
                        Id_prod = BuscarProducto.GetInt32(0),
                        Nombre = BuscarProducto.GetString(1),
                        Descrip_prod = BuscarProducto.GetString(2),
                        Composicion = BuscarProducto.GetString(3),
                        Fechafabricacion = BuscarProducto.GetString(4)
                    };
                }

                // 4. retornar registro consultado
                return producto;
            }
            catch
            {
                throw new Exception("Error: No se pudieron consultar el producto");
            }
        }

        public int InsertarProducto(Producto producto)
        {
            try
            {
                int registro = ejecutar("producto_INSERTARXD", producto);
                return registro;
            }
            catch (Exception)
            {
                throw new Exception("Error: No se pudo crear el Producto");
            }
        }
        public int ActualizarProducto(Producto producto)
        {
            try
            {
                int registro = ejecutar("actualizacion_producto", producto);
                return registro;
            }
            catch (Exception)
            {

                throw new Exception("Error: No se pudo modificar el Producto");
            }
        }


        private int ejecutar(string procedimiento, Producto producto)
        {
            // 1. crear el objeto comando
            SqlCommand objetoComando = conexionBaseDatos.obtenerComandoDeProcedimiento(procedimiento);

            // 2. asignar los parámetros

            objetoComando.Parameters.AddWithValue("@Id_prod", producto.Id_prod);
            objetoComando.Parameters.AddWithValue("@NOMBRE_PROD", producto.Nombre);
            objetoComando.Parameters.AddWithValue("@DESCRIP_PROD", producto.Descrip_prod);
            objetoComando.Parameters.AddWithValue("@COMPOSICION", producto.Composicion);
            objetoComando.Parameters.AddWithValue("@FECHFABRICACION_PROD", producto.Fechafabricacion);


            // 3. ejecutar procedimiento
            int registro = objetoComando.ExecuteNonQuery();

            // 4. retornar registros afectados
            return registro;
        }

        

        public int EliminarProducto(int codigo)
        {
            try
            {
                // 1. crear el objeto comando
                SqlCommand objetoComando = conexionBaseDatos.obtenerComandoDeProcedimiento("eliminacion_productoxdXD");

                // 2. asignar el parámetro
                objetoComando.Parameters.AddWithValue("@ID_PROD", codigo);

                // 3. ejecutar procedimiento
                int registro = objetoComando.ExecuteNonQuery();

                // 4. retornar registros afectados
                return registro;
            }
            catch (Exception)
            {

                throw new Exception("Error: No se pudo eliminar el producto");
            }
        }

    }
}
