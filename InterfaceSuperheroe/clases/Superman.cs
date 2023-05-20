using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSuperheroe.clases
{
    internal class Superman : ISuperHeroe
    {
        public string nombre { get; set; } 
        public int fuerza { get; set; }
        public int agilidad { get; set; }
        public int id { get; set; }

        public void Presentarse()
        {
            Console.WriteLine("Hola soy Superman");
        }

        public void Salvarelmundo()
        {
            Console.WriteLine("Salvando el mundo");
        }

        public void volar()
        {
           Console.WriteLine("Volando");
        }
    }
}
