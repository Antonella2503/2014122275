using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014122275
{
   public class Transporte:ServicioTuristico
    {
        private TipoTransporte _tipoTransporte;
        private CategoriaTransporte _categoriaTransporte;


        public TipoTransporte TipoTransporte{ get { return _tipoTransporte; } }

        public CategoriaTransporte CategoriaTransporte { get { return _categoriaTransporte; } }



    }
}
