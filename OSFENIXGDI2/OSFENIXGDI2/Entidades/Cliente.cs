using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oxfenix.Entidades
{
    class Cliente
    {
        private string id_client;
        private string apepat_client;
        private string nombres_client;
        private string doc_ind_client;
        private string email_client;
        private string movil_client;
        private string direccion_client;
        private string fechnaci_client;

        public Cliente(string id_client, string apepat_client, string nombres_client,
            string doc_ind_client, string email_client, string movil_client,
         string direccion_client, string fechnaci_client)
        {
            this.id_client = id_client;
            this.apepat_client = apepat_client;
            this.nombres_client = nombres_client;
            this.doc_ind_client = doc_ind_client;
            this.email_client = email_client;
            this.movil_client = movil_client;
            this.direccion_client = direccion_client;
            this.fechnaci_client = fechnaci_client;
        }

        public Cliente()
        {
        }

        public string Id_client { get => id_client; set => id_client = value; }
        public string Apepat_client { get => apepat_client; set => apepat_client = value; }
        public string Apemat_client { get => apepat_client; set => apepat_client = value; }
        public string Nombres_client { get => nombres_client; set => nombres_client = value; }
        public string Doc_ind_client { get => doc_ind_client; set => doc_ind_client = value; }
        public string Email_client { get => email_client; set => email_client = value; }
        public string Movil_client { get => movil_client; set => movil_client = value; }
        public string Direccion_client { get => direccion_client; set => direccion_client = value; }
        public string Fechnaci_client { get => fechnaci_client; set => fechnaci_client = value; }


    }
}
