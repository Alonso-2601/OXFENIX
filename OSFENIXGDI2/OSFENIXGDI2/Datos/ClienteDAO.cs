using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using OSFENIXGDI2.Entidades;
using OSFENIXGDI2.Datos;
using Oxfenix.Entidades;

namespace Oxfenix.Datos
{
    class ClienteDAO
    {
        private ConexionBaseDatos conexionBaseDatos;

        public ClienteDAO(ConexionBaseDatos conexionBaseDatos)
        {
            this.conexionBaseDatos = conexionBaseDatos;
        }

        public List<Cliente> ConsultarCliente()
        {
            try
            {
                // 1. crear el objeto comando y asignar propiedades
                SqlCommand objetoComando = conexionBaseDatos.obtenerComandoDeProcedimiento("spClienteDatos");

                // 2. obtener lista de videos
                SqlDataReader registrosDeCliente = objetoComando.ExecuteReader();
                List<Cliente> listaDeClientes = new List<Cliente>();
                Cliente cliente;
                while (registrosDeCliente.Read())
                {
                    cliente = new Cliente
                    {
                        Id_client = registrosDeCliente.GetString(0),
                        Apepat_client = registrosDeCliente.GetString(1),
                        Nombres_client = registrosDeCliente.GetString(2),
                        Doc_ind_client = registrosDeCliente.GetString(3),
                        Email_client = registrosDeCliente.GetString(4),
                        Movil_client = registrosDeCliente.GetString(5),
                        Direccion_client = registrosDeCliente.GetString(6),
                        Fechnaci_client = registrosDeCliente.GetString(7)

                    };
                    listaDeClientes.Add(cliente);
                }

                // 3. retornar lista de videos consultados
                return listaDeClientes;
            }
            catch
            {
                throw new Exception("Error: No se pudieron consultar los Clientes");
            }
        }

        public Cliente BuscarCliente(string id_client)
        {
            try
            {
                // 1. crear el objeto comando
                SqlCommand objetoComando = conexionBaseDatos.obtenerComandoDeProcedimiento("spBuscarCliente");

                // 2. asignar el parámetro
                objetoComando.Parameters.AddWithValue("@id_client", id_client);

                // 3. obtener video
                SqlDataReader registroDeCliente = objetoComando.ExecuteReader();
                Cliente cliente = null;
                if (registroDeCliente.Read())
                {
                    cliente = new Cliente
                    {
                        Id_client = id_client,
                        Apepat_client = registroDeCliente.GetString(0),
                        Nombres_client = registroDeCliente.GetString(2),
                        Doc_ind_client = registroDeCliente.GetString(3),
                        Email_client = registroDeCliente.GetString(4),
                        Movil_client = registroDeCliente.GetString(5),
                        Direccion_client = registroDeCliente.GetString(6),
                        Fechnaci_client = registroDeCliente.GetString(7)
                    };
                }

                // 4. retornar registro consultado
                return cliente;
            }
            catch
            {
                throw new Exception("Error: No se pudo consultar el Clientes");
            }
        }

        public int InsertarCliente(Cliente cliente)
        {
            try
            {
                int registro = ejecutar("spInsertarCliente", cliente);
                return registro;
            }
            catch (Exception)
            {
                throw new Exception("Error: No se pudo crear el Cliente");
            }
        }

        public int ActualizarCliente(Cliente cliente)
        {
            try
            {
                int registro = ejecutar("spActualizarCliente", cliente);
                return registro;
            }
            catch (Exception)
            {

                throw new Exception("Error: No se pudo modificar el Cliente");
            }
        }

        private int ejecutar(string procedimiento, Cliente cliente)
        {
            // 1. crear el objeto comando
            SqlCommand objetoComando = conexionBaseDatos.obtenerComandoDeProcedimiento(procedimiento);

            // 2. asignar los parámetros
            objetoComando.Parameters.AddWithValue("@id_client", cliente.Id_client);
            objetoComando.Parameters.AddWithValue("@apepat_client", cliente.Apepat_client);          
            objetoComando.Parameters.AddWithValue("@nombres_client", cliente.Nombres_client);
            objetoComando.Parameters.AddWithValue("@doc_ind_client", cliente.Doc_ind_client);
            objetoComando.Parameters.AddWithValue("@email_client", cliente.Email_client);
            objetoComando.Parameters.AddWithValue("@movil_client", cliente.Movil_client);
            objetoComando.Parameters.AddWithValue("@direccion_client", cliente.Direccion_client);
            objetoComando.Parameters.AddWithValue("@fechnace_client", cliente.Fechnaci_client);


            // 3. ejecutar procedimiento
            int registro = objetoComando.ExecuteNonQuery();

            // 4. retornar registros afectados
            return registro;
        }

        public int EliminarCliente(string id_client)
        {
            try
            {
                // 1. crear el objeto comando
                SqlCommand objetoComando = conexionBaseDatos.obtenerComandoDeProcedimiento("spEliminarCliente");

                // 2. asignar el parámetro
                objetoComando.Parameters.AddWithValue("@id_client", id_client);

                // 3. ejecutar procedimiento
                int registro = objetoComando.ExecuteNonQuery();

                // 4. retornar registros afectados
                return registro;
            }
            catch (Exception)
            {

                throw new Exception("Error: No se pudo eliminar el Cliente");
            }
        }

    }
}
