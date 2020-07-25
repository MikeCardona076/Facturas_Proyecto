using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Facturas_proyecto.BussinesObjects
{
    public class Cliente
    {
        public Int32 IdCte
        {
            get;
            set;
        }
        public String Nombre
        {
            get;
            set;
        }
        public String Direccion
        {
            get;
            set;
        }
        public String  Telefono
        {
            get;
            set;
        }
        public String EmailCte
        {
            get;
            set;
        }
        public DateTime FechaNacimiento
        {
            get;
            set;
        }
        public String RFC
        {
            get;
            set;
        }
    }
}