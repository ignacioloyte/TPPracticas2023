﻿using CapaEntidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CapaEntidad;


namespace CapaDatos
{
    public class CD_Compra
    {

        public int ObtenerCorrelativo()
        {

            int idCorrelativo = 0;


            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena)){

                try
                {

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select count(*) +1  from Compra");

                    //Conectamos a la base de datos
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    //Devuelve de la primera columna, la primera fila
                    idCorrelativo = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    idCorrelativo = 0;

                }

            }

            return idCorrelativo;

        }

            public bool Registrar(Compra obj, DataTable DetalleCompra, out string Mensaje){
                bool Respuesta = false;
                Mensaje = string.Empty;

                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    try
                    { //Conectamos a la base de datos
                        SqlCommand cmd = new SqlCommand("SP_REGISTRARCOMPRA", oconexion);
                        cmd.Parameters.AddWithValue("IdUsuario", obj.oUsuario.IdUsuario);
                        cmd.Parameters.AddWithValue("IdProveedor", obj.oProveedor.IdProveedor);
                        cmd.Parameters.AddWithValue("TipoDocumento", obj.TipoDocumento);
                        cmd.Parameters.AddWithValue("NumeroDocumento", obj.NumeroDocumento);
                        cmd.Parameters.AddWithValue("MontoTotal", obj.MontoTotal);
                        cmd.Parameters.AddWithValue("DetalleCompra", DetalleCompra);
                        cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                        cmd.CommandType = CommandType.StoredProcedure;

                        oconexion.Open();
                        cmd.ExecuteNonQuery();

                        

                        Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                        Mensaje = cmd.Parameters["Mensaje"].Value.ToString();



                    }
                    catch (Exception ex)
                    {
                        Respuesta = false;
                        Mensaje = ex.Message;

                    }


                }
                return Respuesta;
            }



    }
}



