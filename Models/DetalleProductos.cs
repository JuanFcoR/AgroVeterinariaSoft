﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroVeterinariaSoft.Models
{
    public class DetalleProductos
    {
        [Key]
        public int ID { get; set; }
        public int CompraId { get; set; }
        public int ProductoId { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Importe { get; set; }

        public DetalleProductos()
        {
            ID = 0;
            CompraId = 0;
            ProductoId = 0;
            Descripcion = string.Empty;
            Cantidad = 0;
            Precio = 0;
            Importe = 0;
        }

        public DetalleProductos(int iD, int compraId, int productoId, string descripcion, int cantidad, decimal precio, decimal importe)
        {
            ID = iD;
            CompraId = compraId;
            ProductoId = productoId;
            Descripcion = descripcion;
            Cantidad = cantidad;
            Precio = precio;
            Importe = importe;
        }
    }
}
