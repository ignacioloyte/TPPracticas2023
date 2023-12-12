﻿using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Negocio
    {

        //Instancia a nuestra clase instancia datos
        private CD_Negocio objcd_negocio = new CD_Negocio();

        //Retorna la lista de la clase usuario en la capa datos
        public Negocio ObtenerDatos()
        {
            return objcd_negocio.ObtenerDatos();
        }

        public bool GuardarDatos(Negocio obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Nombre == "")
            {

                Mensaje += "Es necesario el nombre\n";
            }

            if (obj.CUIT == "")
            {

                Mensaje += "Es necesario el número de CUIT\n";
            }

            if (obj.Direccion == "")
            {

                Mensaje += "Es necesario la dirección\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_negocio.GuardarDatos(obj, out Mensaje);
            }
        }

        public byte[] ObtenerLogo(out bool obtenido)
        {
            return objcd_negocio.ObtenerLogo(out obtenido);
        }

        public bool ActualizarLogo(byte[] imagen,out string mensaje)
        {
            return objcd_negocio.ActualizarLogo(imagen, out mensaje);
        }

    }
}


