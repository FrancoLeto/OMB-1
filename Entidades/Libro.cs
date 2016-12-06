using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro
    { 
        public Guid ID_Libro { get; set; }
        public string ISBN { get; set; }
        public string ISBN_10 { get; set; }
        public string Titulo { get; set; }
        public string Subtitulo { get; set; }
        public DateTime FechaPulicacion { get; set; }
        public int Paginas { get; set; }
        public string DatosEnvios { get; set; }

        public virtual Editorial Editorial { get; set; }

        public byte[] Portada { get; set; }

        
        public Libro()
        {
            ID_Libro = Guid.NewGuid();
        }
    }
}
