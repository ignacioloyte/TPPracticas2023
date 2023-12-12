﻿using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Categoria
    {
      
        
            //Instancia a nuestra clase instancia datos
            private CD_Categoria objcd_Categoria = new CD_Categoria();

            //Retorna la lista de la clase Categoria en la capa datos
            public List<Categoria> Listar()
            {
                return objcd_Categoria.Listar();
            }

            public int Registrar(Categoria obj, out string Mensaje)
            {
                Mensaje = string.Empty;

                if (obj.Descripcion == "")
                {

                    Mensaje += "Es necesario la descripción del Categoria\n";
                }

                
                if (Mensaje != string.Empty)
                {
                    return 0;
                }
                else
                {
                    return objcd_Categoria.Registrar(obj, out Mensaje);
                }
            }

            public bool Editar(Categoria obj, out string Mensaje)
            {
                Mensaje = string.Empty;

                if (obj.Descripcion == "")
                {

                    Mensaje += "Es necesario la descripción del Categoria\n";
                }


                if (Mensaje != string.Empty)
                {
                    return false;
                }
                else
                {
                    return objcd_Categoria.Editar(obj, out Mensaje);
                }
            }

            public bool Eliminar(Categoria obj, out string Mensaje)
            {
                         
                return objcd_Categoria.Eliminar(obj, out Mensaje);
                
            }
        }
    }

