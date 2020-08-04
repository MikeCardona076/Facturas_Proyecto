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
        //.................................................................................................//

        public List<Cliente> ClienteList
        {
            get;
            set;
        }

        //.................................................................................................//

        #endregion

        #region Methods
        

        //.................................................................................................//
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

        //.................................................................................................//


        public List<Cliente> SeleccionarCliente(Int32? IdCte, String  Nombre, String  Rfc)
        {
            List<Cliente> ClienteList = new List<Cliente>();

            try
            {
                ClienteList = ClienteDAL.SeleccionarCliente(IdCte, Nombre, Rfc);
            }
                        catch (Exception ex)
            {

            }
            return ClienteList;

        }

        //.................................................................................................//

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

        //.................................................................................................//

        public Int32 BorrarCliente(Int32 IdCliente)
        {
            Int32 affectedRows = 0;

            try
            {
                affectedRows = ClienteDAL.EliminarCliente(IdCliente);
            }
            catch (Exception ex)
            {

            }
            return affectedRows;

        }

        //.................................................................................................//


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

        //.................................................................................................//

        #endregion

        //Events
        #region Events
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    Int32? IdCte = null;
                    String Nombre = "";
                    String Rfc = "";

                    ClienteList = new List<Cliente>();
                    ClienteList = SeleccionarCliente(IdCte, Nombre, Rfc);
                    RellenarGridClientes(ClienteList);

                }


            }
            catch(Exception ex){

            }

        }

        //.................................................................................................//


        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            try{
                Cliente cte = new Cliente();

                cte.Nombre = txbNombre.Text;
                cte.Direccion = txbDireccion.Text;
                cte.Telefono = Convert.ToString(txbTelefono.Text);
                cte.RFC = txbRfc.Text;
                cte.EmailCte = txbEmail.Text;
                cte.FechaNacimiento = Convert.ToDateTime(txbFechaNacimiento.Text);

                Int32 affectedRows = 0;

                affectedRows = InsertarCliente(cte);
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
                Int32? IdCte = null;
                String Nombre = "";
                String Rfc = "";

                ClienteList = new List<Cliente>();
                ClienteList = SeleccionarCliente(IdCte, Nombre, Rfc);
                RellenarGridClientes(ClienteList);

            }
            catch (Exception ex)
            {

            }

        }

        //.................................................................................................//


        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            txbNombre.Text = String.Empty;
            txbDireccion.Text = String.Empty;
            txbTelefono.Text = String.Empty;
            txbRfc.Text = String.Empty;
            txbEmail.Text = String.Empty;
            txbFechaNacimiento.Text = String.Empty;
        }

        #endregion


    }
}