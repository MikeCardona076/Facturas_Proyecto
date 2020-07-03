using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Facturas_proyecto.BussinesObjects
{
    public class Detalle_factura
    {
        public Int32 Idfact {
            get;
            set;
        }
        public Int32 Consecutivo_det
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

        public Double Subtotal_det
        {
            get;
            set;

        }



    }
}