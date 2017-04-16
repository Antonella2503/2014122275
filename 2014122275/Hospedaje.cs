using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014122275
{
    public class Hospedaje:ServicioTuristico
    {
        private TipoHospedaje _tipoHospedaje;
        private CalificacionHospedaje _caliHospedaje;
        private CategoriaHospedaje _categoriaHospedaje;
        private ServicioHospedaje _servicioHopsedaje;

        public TipoHospedaje TipoHospedaje { get { return _tipoHospedaje; } }
        public CalificacionHospedaje CalificacionHospedaje { get { return _caliHospedaje; } }
        public CategoriaHospedaje CategoriaHospedaje { get { return _categoriaHospedaje; } }
        public ServicioHospedaje ServicioHospedaje { get { return _servicioHopsedaje; } }
    }
}
