using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014122275
{
    public class Alimentacion:ServicioTuristico
    {
        private CategoriaAlimentacion _cateAlimentacion;

        public CategoriaAlimentacion CategoriaAlimentacion { get { return _cateAlimentacion; } }
    }
}
