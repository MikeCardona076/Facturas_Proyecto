using Facturas_proyecto.BussinesObjects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Facturas_proyecto.DAL;

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
            String conStr = DBManager.GetConnectionString("Servicio");
            con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand();

            // LLAMADA AL PROCEDIMIENTO
            cmd.CommandText = "crear_cliente"; //Nombre del SP
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            #region Parametros SP

            //PARAMETROS DEL SP

            ///......................................................................///
            // ID CLIENTE
            SqlParameter parIdCliente = new SqlParameter(); // Declarar
            parIdCliente.ParameterName = "@id_cte"; //Nombre de nuestro parametro en SP
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


        catch (SqlException ex)
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
            String conStr = DBManager.GetConnectionString("Servicio"); ;
            con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            #region SP

            // LLAMADA AL PROCEDIMIENTO
            cmd.CommandText = "eliminar_cliente"; //Nombre del SP
            cmd.CommandType = CommandType.StoredProcedure;

            ///......................................................................///
            // ID CLIENTE
            SqlParameter parIdCliente_eliminar = new SqlParameter(); // Declarar
            parIdCliente_eliminar.ParameterName = "@eliminar_registro"; //Nombre de nuestro parametro en SP
            parIdCliente_eliminar.DbType = DbType.Int32; // Tipo
            parIdCliente_eliminar.Direction = ParameterDirection.Output; // Asignar si es de salida o no
            cmd.Parameters.Add(parIdCliente_eliminar); // Agregamos 

            con.Open();
            affectedRows = cmd.ExecuteNonQuery();

            if (affectedRows > 0)
            {
                IdCliente = Convert.ToInt32(cmd.Parameters["@eliminar_registro"].Value);
            }

            #endregion


        }


        catch (SqlException ex)
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
    ///Actualizar
    static public Int32 ActualizarCliente(Cliente cte)
    {
        Int32 affectedRows = 0;
        try
        {
            DBManager.GetConnectionString("Servicio");
            con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            // LLAMADA AL PROCEDIMIENTO
            cmd.CommandText = "actualizar_cliente"; //Nombre del SP
            cmd.CommandType = CommandType.StoredProcedure;

            #region Parametros SP

            //PARAMETROS DEL SP

            ///......................................................................///
            // ID CLIENTE
            SqlParameter parIdCliente = new SqlParameter(); // Declarar
            parIdCliente.ParameterName = "@id_registro"; //Nombre de nuestro parametro en SP
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

            if (affectedRows > 0)
            {
                cte.IdCte = Convert.ToInt32(cmd.Parameters["@Id_cte"].Value);
            }

            #endregion


        }


        catch (SqlException ex)
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
    //Seleccionar 
    static public List<Cliente> SeleccionarCliente(Int32? IdCliente, String Nombre, String Rfc)
    {
        List<Cliente> ClienteList = new List<Cliente>();

        try
        {
            String conStr = DBManager.GetConnectionString("Servicio");
            con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand();

            // LLAMADA AL PROCEDIMIENTO
            cmd.CommandText = "seleccionar_cliente"; //Nombre del SP
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;


            //PARAMETROS DEL SP

            ///......................................................................///
            // ID CLIENTE
            SqlParameter parIdCliente = new SqlParameter(); // Declarar
            parIdCliente.ParameterName = "@Id_cte"; //Nombre de nuestro parametro en SP
            parIdCliente.DbType = DbType.Int32; // Tipo
            parIdCliente.Direction = ParameterDirection.Input; // Asignar si es de salida o no
            parIdCliente.Value = IdCliente;
            cmd.Parameters.Add(parIdCliente); // Agregamos 

            ///......................................................................///
            // NOMBRE
            SqlParameter parName = new SqlParameter(); // Declarar
            parName.ParameterName = "@Nombre_cte"; //Nombre de nuestro parametro en SP
            parName.DbType = DbType.String; // Tipo
            parName.Direction = ParameterDirection.Input; // Asignar si es de salida o no
            parName.Value = String.IsNullOrEmpty(Nombre) ? null : Nombre;
            cmd.Parameters.Add(parName); // Agregamos 

            ///......................................................................///
            // RFC
            SqlParameter parRfc = new SqlParameter(); // Declarar
            parRfc.ParameterName = "@Rfc"; //Nombre de nuestro parametro en SP
            parRfc.DbType = DbType.String; // Tipo
            parRfc.Direction = ParameterDirection.Input; // Asignar si es de salida o no
            parRfc.Value = String.IsNullOrEmpty(Rfc) ? null : Rfc;
            cmd.Parameters.Add(parRfc); // Agregamos 

            con.Open();

            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    Cliente cte = new Cliente();

                    cte.IdCte = Convert.ToInt32(dr["id_Cte"].ToString());
                    cte.Nombre = dr["Nombre_cte"].ToString();
                    cte.Telefono = dr["Telefono"].ToString();
                    cte.EmailCte = dr["email_cliente"].ToString();
                    cte.Direccion = dr["Direccion"].ToString();
                    cte.FechaNacimiento = Convert.ToDateTime(dr["Fecha_Nacimiento_cte"].ToString());
                    cte.RFC = dr["RFC_cte"].ToString();

                    ClienteList.Add(cte);
                }

            }


        }
        catch (SqlException ex)
        {
            throw ex;
        }
        finally
        {
            con.Close();
        }

        return ClienteList;
    }


}

