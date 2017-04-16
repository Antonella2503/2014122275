using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014122275
{
    public class VentaPaquete
    {
        private Paquete _paquete;
        private MedioPAgo _medioPago;
        private ComprobantePago _comprobPago;

        public Paquete Paquete { get { return _paquete; } }

        public MedioPAgo MEdioPago { get { return _medioPago; } }

        public ComprobantePago ComprobPago { get { return _comprobPago; } }


        public int VentaPaqueteID { get; private set; }
        public Cliente Cliente{ get; set; }

        public VentaPaquete()
        {

        }

        public VentaPaquete(Cliente cliente)
        {
            Cliente = cliente;
        }

        public VentaPaquete(int ventaPaqueteID)
        {
            VentaPaqueteID = ventaPaqueteID;
        }



    }
}
