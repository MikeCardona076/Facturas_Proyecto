using Facturas_proyecto.BussinesObjects;
using System;
using System.Collections.Generic;

static public class ClienteDAL
{
    ///......................................................................///
    ///Insertar
    static public Int32 InsertarCliente(Cliente cte)
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
