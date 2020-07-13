using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Facturas_proyecto.BussinesObjects;

namespace Facturas_proyecto.View
{
    public partial class frmProducto : System.Web.UI.Page
    {
        #region properties
        public List<Producto> ProductoList
        {
            get;
            set;
        }
        #endregion

        #region Methods
        #endregion
        //.................................................................................................//
        public Int32 InsertarProducto(Producto prd)
        {
            Int32 affectedRows = 0;

            try
            {
                affectedRows = ProductoDAL.InsertarProducto();
            }
            catch(Exception ex)
            {

            }

            return affectedRows;

        }

        //.................................................................................................//

        public Int32 SeleccionarProducto(Cliente cte)
        {
            Int32 affectedRows = 0;

            try
            {
                affectedRows = ProductoDAL.SeleccionarProducto(prod);
            }
                        catch (Exception ex)
            {

            }
            return;

        }

        //.................................................................................................//

        public Int32 ActualizarProducto(Cliente prod)
        {
            Int32 affectedRows = 0;

            try
            {
                affectedRows = ProductoDAL.ActualizarProducto(prod);
            }
            catch (Exception ex)
            {

            }
            return affectedRows;

        }

        //.................................................................................................//

        public Int32 BorrarProducto(Cliente cte)
        {
            Int32 affectedRows = 0;

            try
            {
                affectedRows = ProductoDAL.BorrarProducto(prod);
            }
            catch (Exception ex)
            {

            }
            return affectedRows;

        }

        //.................................................................................................//


        public void RellenarGridProducto(List<Producto> ProductoList)
        {
            try
            {
                GridProducto.DataSource = ProductoList;
                GridProducto.DataBind();
            }
            catch(Exception ex)
            {

            }
        }

        //.................................................................................................//

        
        //Events
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Int32? Idprod = null;
                String Descripcion = "";
                Int32? CodigoBarras = "";

                ProductoList = new List<Producto>();
                ProductoList = SeleccionarProducto(Idprod, Descripcion, CodigoBarras);
                RellenarGridProducto(ProductoList);

            }
            catch(Exception ex){

            }

        }

        //.................................................................................................//
        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            try{
                ProductoList prod = new Producto();

                prod.Descripcion = txbDescripcion.Text;
                prod.Precio = txbPrecio.Text;
                prod.FechaCaducidad = Convert.ToDateTime(txbFechaCaducidad);
                prod.CodigoBarras = txbCodigoBarras.Text;
                prod.ProveedorProd = txbProveedorProd.Text;

                Int32 affectedRows = 0;

                affectedRows = InsertarProducto(prod);
                if(affectedRows > 0){
                    //Mandar mensaje
                }
            }
            catch(Exception ex){

            }

        }

        //.................................................................................................//


        protected void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        //.................................................................................................//


        protected void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        //.................................................................................................//

    }
}