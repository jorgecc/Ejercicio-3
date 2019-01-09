﻿using ProyectoWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ProyectoWeb.servicio
{
    public class ProductoServicio
    {
        public static int Calcular(Producto prod)
        {
            return prod.Precio*1.19;
        }
        public static Producto Crear(TextBox txt1,TextBox txt2)
        {
            Producto prod=new Producto();
            prod.Nombre=txt1.Text;
            prod.Precio=Convert.ToInt32(txt2.Text);

            return prod;
        }
    }
}