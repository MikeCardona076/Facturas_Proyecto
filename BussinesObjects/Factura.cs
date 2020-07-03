using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

namespace Facturas_proyecto.BussinesObjects
{
    public class Factura
    {
        public Int32 FolioFact
        {
            get;
            set;
        }
        public Int32 idCte
        {
            get;
            set;
        }
        public DateTime FechaCte
        {
            get;
            set;
        }
        public Double TotalFact
        {
            get;
            set;
        }
    
    }
}