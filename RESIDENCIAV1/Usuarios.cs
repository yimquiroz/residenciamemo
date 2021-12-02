using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESIDENCIAV1
{
    public class Usuarios
    {
        public int Id;
        public string Usuario;
        public string correo;
        public string pass;
        public string pass1;

        public string _Usuario
        {
            get { return Usuario; }
            set { Usuario = value; }
        }
        public int _Id
        {
            get { return Id; }
            set { Id= value; }
        }
        public string _correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public string _pass
        {
            get { return pass; }
            set { pass = value; }
        }

        public string _pass1
        {
            get { return pass1; }
            set { pass1 = value; }
        }

        
    }
}
