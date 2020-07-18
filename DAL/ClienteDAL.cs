using Facturas_proyecto.BussinesObjects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlTypes;

static public class ClienteDAL
{
    //CONEXION 
   static public  SqlConnection con;


    ///......................................................................///
    ///Insertar
    static public Int32 InsertarCliente(Cliente cte)
    {
        Int32 affectedRows=0;
        try
        {
            String conStr = "";
            con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            // LLAMADA AL PROCEDIMIENTO
            cmd.CommandText = "dbo.crear_cliente"; //Nombre del SP
            cmd.CommandType = CommandType.StoredProcedure;

            #region Parametros SP

            //PARAMETROS DEL SP

            ///......................................................................///
            // ID CLIENTE
            SqlParameter parIdCliente = new SqlParameter(); // Declarar
            parIdCliente.ParameterName = "@Id_cliente"; //Nombre de nuestro parametro en SP
            parIdCliente.DbType = DbType.Int32; // Tipo
            parIdCliente.Direction = ParameterDirection.Output; // Asignar si es de salida o no
            cmd.Parameters.Add(parIdCliente); // Agregamos 


            ///......................................................................///
            // NOMBRE
            SqlParameter parName = new SqlParameter(); // Declarar
            parName.ParameterName = "@nombre"; //Nombre de nuestro parametro en SP
            parName.DbType = DbType.String; // Tipo
            parName.Direction = ParameterDirection.Input; // Asignar si es de salida o no
            parName.Value = cte.Nombre;
            cmd.Parameters.Add(parName); // Agregamos 


            ///......................................................................///
            // DIRECCION
            SqlParameter parDireccion = new SqlParameter(); // Declarar
            parDireccion.ParameterName = "@direccion"; //Nombre de nuestro parametro en SP
            parDireccion.DbType = DbType.String; // Tipo
            parDireccion.Direction = ParameterDirection.Input; // Asignar si es de salida o no
            parDireccion.Value = cte.Direccion;
            cmd.Parameters.Add(parDireccion); // Agregamos 


            ///......................................................................///
            // TELEFONO
            SqlParameter parTelefono = new SqlParameter(); // Declarar
            parTelefono.ParameterName = "@telefono"; //Nombre de nuestro parametro en SP
            parTelefono.DbType = DbType.String; // Tipo
            parTelefono.Direction = ParameterDirection.Input; // Asignar si es de salida o no
            parTelefono.Value = cte.Telefono;
            cmd.Parameters.Add(parTelefono); // Agregamos 


            ///......................................................................///
            // EMAIL 
            SqlParameter parEmail_cliente = new SqlParameter(); // Declarar
            parEmail_cliente.ParameterName = "@email_cliente"; //Nombre de nuestro parametro en SP
            parEmail_cliente.DbType = DbType.String; // Tipo
            parEmail_cliente.Direction = ParameterDirection.Input; // Asignar si es de salida o no
            parEmail_cliente.Value = cte.EmailCte;
            cmd.Parameters.Add(parEmail_cliente); // Agregamos 


            ///......................................................................///
            // FECHA
            SqlParameter parFecha_nacimiento = new SqlParameter(); // Declarar
            parFecha_nacimiento.ParameterName = "@fecha_nacimiento"; //Nombre de nuestro parametro en SP
            parFecha_nacimiento.DbType = DbType.Date; // Tipo
            parFecha_nacimiento.Direction = ParameterDirection.Input; // Asignar si es de salida o no
            parFecha_nacimiento.Value = cte.FechaNacimiento;
            cmd.Parameters.Add(parFecha_nacimiento); // Agregamos 


            ///......................................................................///
            // RFC
            SqlParameter parRfc = new SqlParameter(); // Declarar
            parRfc.ParameterName = "@rfc"; //Nombre de nuestro parametro en SP
            parRfc.DbType = DbType.String; // Tipo
            parRfc.Direction = ParameterDirection.Input; // Asignar si es de salida o no
            parRfc.Value = cte.RFC;
            cmd.Parameters.Add(parRfc); // Agregamos 


            con.Open();
            affectedRows = cmd.ExecuteNonQuery();

            if(affectedRows > 0)
            {
                cte.IdCte = Convert.ToInt32(cmd.Parameters["@Id_cte"].Value);
            }

            #endregion


        }


        catch (SqlException ex )
        {
            throw ex;
        }


        finally
        {
            con.Close();
        }

        return affectedRows;

    }


    ///......................................................................///
    ///Eliminar
    static public Int32 EliminarCliente(Int32 IdCliente)
    {
        Int32 affectedRows=0;
        try
        {

        }
        catch (Exception EX)
        {
            throw EX;
        }
        return affectedRows;
    }


    ///......................................................................///
    ///Actualizar
    static public Int32 ActualizarCliente(Cliente cte)
    {
        Int32 affectedRows=0;
        try
        {

        }
        catch (Exception EX)
        {
            throw EX;
        }
        return affectedRows;
    }


    ///......................................................................///
    //Seleccionar 
    static public List<Cliente> SeleccionarCliente(Int32? IdCliente, String Nombre, String Rfc)
    {
        List<Cliente> ClienteList = new List<Cliente>();

        try
        {

        }
        catch (Exception EX)
        {
            throw EX;
        }

        return ClienteList;
    }


}
