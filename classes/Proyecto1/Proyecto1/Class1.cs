using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    public class Cliente

    {
        public int cliente_id;
        public String cliente_nombre;
        private String cliente_direccion;
        private String cliente_correo;
        private String cliente_domicilio;
        private String cliente_datosTarjeta;





        public string Nombre_cliente { get => cliente_nombre; set => cliente_nombre = value; }
        public string Cliente_direccion { get => cliente_direccion; set => cliente_direccion = value; }
        public string Cliente_correo { get => cliente_correo; set => cliente_correo = value; }
        public string Cliente_domicilio { get => cliente_domicilio; set => cliente_domicilio = value; }
        public string Cliente_datosTarjeta { get => cliente_datosTarjeta; set => cliente_datosTarjeta = value; }

        public Cliente()
        {
        }

        public Cliente(int cliente_id, string cliente_nombre, string cliente_direccion, string cliente_correo, string cliente_domicilio, string cliente_datosTarjeta)
        {
            this.cliente_id = cliente_id;
            this.cliente_nombre = cliente_nombre;
            this.cliente_direccion = cliente_direccion;
            this.cliente_correo = cliente_correo;
            this.cliente_domicilio = cliente_domicilio;
            this.cliente_datosTarjeta = cliente_datosTarjeta;
        }
    }
}
