using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace AppProductos.Models
{
    [Table("ventas")]
    public class Productos
    {
        [PrimaryKey, AutoIncrement]
        public int VentaId { get; set; }

        [MaxLength(70)]
        public string Producto { get; set; }

    }
}
