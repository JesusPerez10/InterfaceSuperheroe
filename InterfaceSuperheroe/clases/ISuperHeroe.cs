using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSuperheroe.clases
{
    internal interface ISuperHeroe
    {
       public string nombre { get; set; }
        public int fuerza { get; set; }
        //nuevas propiedades
        public int agilidad { get; set; }
        public int id { get; set; }

        void volar();
        void Salvarelmundo();
        void Presentarse();



    }
}
