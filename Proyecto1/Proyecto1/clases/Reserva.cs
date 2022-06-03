using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    public class Reserva
    {
        private int reserva_id;
        private DateTime reserva_date;
        private String reserva_nombre;

        public int Reserva_id { get => reserva_id; set => reserva_id = value; }
        public DateTime Reserva_date { get => reserva_date; set => reserva_date = value; }
        public string Reserva_name { get => reserva_nombre; set => reserva_nombre = value; }

        public Reserva()
        {
        }

        public Reserva(int reserva_id, DateTime reserva_date, string reserva_name)
        {
            this.reserva_id = reserva_id;
            this.reserva_date = reserva_date;
            this.reserva_nombre = reserva_name;
        }
    }
}
