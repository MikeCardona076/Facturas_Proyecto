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
        
        //.................................................................................................//
        public Int32 InsertarProducto(Producto prd)
        {
            Int32 affectedRows = 0;

            try
            {
                affectedRows = ProductoDAL.InsertarProducto(prd);
            }
            catch(Exception ex)
            {

            }

            return affectedRows;

        }

        //.................................................................................................//

        public List<Producto> SeleccionarProducto(Int32? Idprod, String CodigoBarras, String Nombre)
        {
            List<Producto> ProductoList = new List<Producto>();

            try
            {
                ProductoList = ProductoDAL.SeleccionarProducto(Idprod, CodigoBarras, Nombre);
            }
                        catch (Exception ex)
            {

            }
            return ProductoList;

        }

        //.................................................................................................//

        public Int32 ActualizarProducto(Producto prod)
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

        public Int32 BorrarProducto(Int32? Idprod)
        {
            Int32 affectedRows = 0;

            try
            {
                affectedRows = ProductoDAL.EliminarProducto(Idprod);
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

        #endregion
        //Events
        #region Events
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Int32? Idprod = null;
                String Descripcion = "";
                String CodigoBarras = "";

                ProductoList = new List<Producto>();
                ProductoList = SeleccionarProducto(Idprod, CodigoBarras, Descripcion);
                RellenarGridProducto(ProductoList);

            }
            catch(Exception ex){

            }

        }

        //.................................................................................................//
        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            try{
                Producto prod = new Producto();

                prod.Descripcion = txbDescripcion.Text;
                prod.Precio = Convert.ToDouble(txbPrecio.Text);
                prod.FechaCaducidad = Convert.ToDateTime(txbFechaCaducidad.Text);
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
            try
            {
                Int32? Idprod = null;
                String Descripcion = "";
                String CodigoBarras = "";

                ProductoList = new List<Producto>();
                ProductoList = SeleccionarProducto(Idprod, CodigoBarras, Descripcion);
                RellenarGridProducto(ProductoList);

            }
            catch (Exception ex)
            {

            }


        }

        //.................................................................................................//


        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            txbDescripcion.Text = String.Empty;
            txbPrecio.Text = String.Empty;
            txbFechaCaducidad.Text = String.Empty;
            txbCodigoBarras.Text = String.Empty;
            txbProveedorProd.Text = String.Empty;

        }

        #endregion



    }
}