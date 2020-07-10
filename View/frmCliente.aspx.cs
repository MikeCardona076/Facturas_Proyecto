using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Facturas_proyecto.BussinesObjects;


namespace Facturas_proyecto.View
{

    public partial class WebForm1 : System.Web.UI.Page
    {
        #region properties
        public List<Cliente> ClienteList
        {
            get;
            set;
        }
        #endregion

        #region Methods
        #endregion

        public Int32 InsertarCliente(Cliente cte)
        {
            Int32 affectedRows = 0;

            try
            {
                affectedRows = ClienteDAL.InsertarCliente(cte);
            }
            catch(Exception ex)
            {

            }

            return affectedRows;

        }

        public Int32 SeleccionarCliente(Cliente cte)
        {
            Int32 affectedRows = 0;

            try
            {
                affectedRows = ClienteDAL.SeleccionarCliente(cte);
            }
            return;

        }
        public Int32 ActualizarCliente(Cliente cte)
        {
            Int32 affectedRows = 0;

            try
            {
                affectedRows = ClienteDAL.ActualizarCliente(cte);
            }
            catch (Exception ex)
            {

            }
            return affectedRows;

        }
        public Int32 BorrarCliente(Cliente cte)
        {
            Int32 affectedRows = 0;

            try
            {
                affectedRows =
            }
            return;

        }

        public void RellenarGridClientes(List<Cliente> ClienteList)
        {
            try
            {
                GridClientes.DataSource = ClienteList;
                GridClientes.DataBind();

            }
            catch(Exception ex)
            {

            }
        }
        
        //Events
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Int32? IdCte = null;
                String Nombre = "";
                String Rfc = "";

                ClienteList = new List<Cliente>();
                ClienteList = SeleccionarCliente(IdCte);
            }

        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

    }
}