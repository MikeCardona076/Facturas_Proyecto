using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Facturas_proyecto.BussinesObjects
{
    public class Detalle_factura
    {
        public Int32 IdCte {
            get;
            set;
        }
        public String Consecutivo_det
        {
            get;
            set;
        }

        public Int32 Id_prod
        {
            get;
            set;
        }

        public Int32 Cantidad_det
        {
            get;
            set;

        }

        public Int32 Subtotal_det
        {
            get;
            set;

        }



    }
}