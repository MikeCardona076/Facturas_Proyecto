using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

namespace Facturas_proyecto.BussinesObjects
{
    public class Producto
    {

        public Int32 Id_prod
        {
            get;
            set;
        }
        public String Descripcion
        {
            get;
            set;
        }
        public SqlMoney Precio
        {
            get;
            set;
        }
        public DateTime FechaCaducidad
        {
            get;
            set;
        }
        public String CodigoBarras
        {
            get;
            set;
        }
        public String ProveedorProd
        {
            get;
            set;
        }

    }
}