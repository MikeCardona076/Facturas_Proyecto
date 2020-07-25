using Facturas_proyecto.BussinesObjects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

static public class ProductoDAL
{
    static public SqlConnection con;

    ///......................................................................///
    ///Insertar
    static public Int32 InsertarProducto(Producto prod)
    {
        

        Int32 affectedRows = 0;
        try
        {
            #region SP CONEXION 

            String conStr = "DBManager.GetConnectionStrings('FacturacionDB')";
            con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            // LLAMADA AL PROCEDIMIENTO
            cmd.CommandText = "dbo.crear_productos"; //Nombre del SP
            cmd.CommandType = CommandType.StoredProcedure;

            //PARAMETROS DEL SP
            // ID PRODUCTO
            SqlParameter parIdProd = new SqlParameter(); // Declarar
            parIdProd.ParameterName = "@id_prod"; //Nombre de nuestro parametro en SP
            parIdProd.DbType = DbType.Int32; // Tipo
            parIdProd.Direction = ParameterDirection.Output; // Asignar si es de salida o no
            cmd.Parameters.Add(parIdProd); // Agregamos


            ///......................................................................///
            //descripcion_prod
            SqlParameter parDescription = new SqlParameter(); // Declarar
            parDescription.ParameterName = "@descripcion_prod"; //Nombre de nuestro parametro en SP
            parDescription.DbType = DbType.String; // Tipo
            parDescription.Direction = ParameterDirection.Input; // Asignar si es de salida o no
            parDescription.Value = prod.Descripcion;
            cmd.Parameters.Add(parDescription); // Agregamos 

            //precio_prod
            SqlParameter parPrice = new SqlParameter(); // Declarar
            parPrice.ParameterName = "@precio_prod"; //Nombre de nuestro parametro en SP
            parPrice.DbType = DbType.Double; // Tipo
            parPrice.Direction = ParameterDirection.Input; // Asignar si es de salida o no
            parPrice.Value = prod.Precio;
            cmd.Parameters.Add(parPrice); // Agregamos

            //fecha_caducidad
            SqlParameter parDateCad = new SqlParameter(); // Declarar
            parDateCad.ParameterName = "@fecha_caducidad"; //Nombre de nuestro parametro en SP
            parDateCad.DbType = DbType.DateTime; // Tipo
            parDateCad.Direction = ParameterDirection.Input; // Asignar si es de salida o no
            parDateCad.Value = prod.FechaCaducidad;
            cmd.Parameters.Add(parDateCad); // Agregamos

            //codigo_barras
            SqlParameter parCoBa = new SqlParameter(); // Declarar
            parCoBa.ParameterName = "@codigo_barras"; //Nombre de nuestro parametro en SP
            parCoBa.DbType = DbType.String; // Tipo
            parCoBa.Direction = ParameterDirection.Input; // Asignar si es de salida o no
            parCoBa.Value = prod.CodigoBarras;
            cmd.Parameters.Add(parCoBa); // Agregamos

            //proveedor_prod
            SqlParameter parProveedor = new SqlParameter(); // Declarar
            parProveedor.ParameterName = "@proveedor_prod"; //Nombre de nuestro parametro en SP
            parProveedor.DbType = DbType.String; // Tipo
            parProveedor.Direction = ParameterDirection.Input; // Asignar si es de salida o no
            parProveedor.Value = prod.ProveedorProd;
            cmd.Parameters.Add(parProveedor); // Agregamos
            con.Open();
            affectedRows = cmd.ExecuteNonQuery();

            if (affectedRows > 0)
            {
                prod.Id_prod = Convert.ToInt32(cmd.Parameters["@Id_cte"].Value);
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
    static public Int32 EliminarProducto(Int32?  Idprod)
    {
        Int32 affectedRows = 0;
        try
        {
            #region SP CONEXION
            String conStr = "DBManager.GetConnectionStrings('FacturacionDB')";
            con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            // LLAMADA AL PROCEDIMIENTO
            cmd.CommandText = "dbo.eliminar_productos"; //Nombre del SP
            cmd.CommandType = CommandType.StoredProcedure;

            // PARAMETROS
            ///......................................................................///
            // ID Productos
            SqlParameter parIdProductos_eliminar = new SqlParameter(); // Declarar
            parIdProductos_eliminar.ParameterName = "@eliminar_registro"; //Nombre de nuestro parametro en SP
            parIdProductos_eliminar.DbType = DbType.Int32; // Tipo
            parIdProductos_eliminar.Direction = ParameterDirection.Output; // Asignar si es de salida o no
            cmd.Parameters.Add(parIdProductos_eliminar); // Agregamos 

            con.Open();
            affectedRows = cmd.ExecuteNonQuery();

            if (affectedRows > 0)
            {
                Idprod = Convert.ToInt32(cmd.Parameters["@eliminar_registro"].Value);
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
    static public Int32 ActualizarProducto(Producto prod)
    {
        Int32 affectedRows = 0;
        try
        {
            #region SP CONEXION 

            String conStr = "DBManager.GetConnectionStrings('FacturacionDB')";
            con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            // LLAMADA AL PROCEDIMIENTO
            cmd.CommandText = "dbo.actualizar_productos"; //Nombre del SP
            cmd.CommandType = CommandType.StoredProcedure;

            //PARAMETROS DEL SP
            // ID PRODUCTO
            SqlParameter parIdProd = new SqlParameter(); // Declarar
            parIdProd.ParameterName = "@id_prod"; //Nombre de nuestro parametro en SP
            parIdProd.DbType = DbType.Int32; // Tipo
            parIdProd.Direction = ParameterDirection.Output; // Asignar si es de salida o no
            cmd.Parameters.Add(parIdProd); // Agregamos


            ///......................................................................///
            //descripcion_prod
            SqlParameter parDescription = new SqlParameter(); // Declarar
            parDescription.ParameterName = "@descripcion_prod"; //Nombre de nuestro parametro en SP
            parDescription.DbType = DbType.String; // Tipo
            parDescription.Direction = ParameterDirection.Input; // Asignar si es de salida o no
            parDescription.Value = prod.Descripcion;
            cmd.Parameters.Add(parDescription); // Agregamos 

            //precio_prod
            SqlParameter parPrice = new SqlParameter(); // Declarar
            parPrice.ParameterName = "@precio_prod"; //Nombre de nuestro parametro en SP
            parPrice.DbType = DbType.Double; // Tipo
            parPrice.Direction = ParameterDirection.Input; // Asignar si es de salida o no
            parPrice.Value = prod.Precio;
            cmd.Parameters.Add(parPrice); // Agregamos

            //fecha_caducidad
            SqlParameter parDateCad = new SqlParameter(); // Declarar
            parDateCad.ParameterName = "@fecha_caducidad"; //Nombre de nuestro parametro en SP
            parDateCad.DbType = DbType.DateTime; // Tipo
            parDateCad.Direction = ParameterDirection.Input; // Asignar si es de salida o no
            parDateCad.Value = prod.FechaCaducidad;
            cmd.Parameters.Add(parDateCad); // Agregamos

            //codigo_barras
            SqlParameter parCoBa = new SqlParameter(); // Declarar
            parCoBa.ParameterName = "@codigo_barras"; //Nombre de nuestro parametro en SP
            parCoBa.DbType = DbType.String; // Tipo
            parCoBa.Direction = ParameterDirection.Input; // Asignar si es de salida o no
            parCoBa.Value = prod.CodigoBarras;
            cmd.Parameters.Add(parCoBa); // Agregamos

            //proveedor_prod
            SqlParameter parProveedor = new SqlParameter(); // Declarar
            parProveedor.ParameterName = "@proveedor_prod"; //Nombre de nuestro parametro en SP
            parProveedor.DbType = DbType.String; // Tipo
            parProveedor.Direction = ParameterDirection.Input; // Asignar si es de salida o no
            parProveedor.Value = prod.ProveedorProd;
            cmd.Parameters.Add(parProveedor); // Agregamos
            con.Open();
            affectedRows = cmd.ExecuteNonQuery();

            if (affectedRows > 0)
            {
                prod.Id_prod = Convert.ToInt32(cmd.Parameters["@Id_cte"].Value);
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
    //Seleccionar Productos
    static public List<Producto> SeleccionarProducto(Int32? Idprod, String CodigoBarras, String Nombre)
    {
        List<Producto> ProductoList = new List<Producto>();

        try
        {

        }
        catch (Exception EX)
        {
            throw EX;
        }

        return ProductoList;
    }

}
