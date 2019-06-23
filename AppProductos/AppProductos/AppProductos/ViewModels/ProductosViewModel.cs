using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using AppProductos.Models;


namespace AppProductos.ViewModels
{


    public class ProductosViewModel
    {
        private SQLiteConnection conec;
        private static ProductosViewModel instance;
        public static ProductosViewModel Instance
        {
            get
            {
                if (instance == null) { throw new Exception("Falta inicializar"); }
                return instance;
            }
        }

        public static void Inicializador(String filename)
        {
            if (filename == null) { throw new ArgumentException(); }
            if (instance != null) { instance.conec.Close(); }
            instance = new ProductosViewModel(filename);
        }

        private ProductosViewModel(String DbPath)
        {
            conec = new SQLiteConnection(DbPath);
            conec.CreateTable<Productos>();
        }
        public String EstadoMensaje;

        public int AddNewProducto(string producto)
        {
            int result = 0;

            try
            {
                result = conec.Insert(new Productos()
                {
                    Producto = producto,

                });
                EstadoMensaje = string.Format("Ingresado correctamente");
            }
            catch (Exception e)
            {
                EstadoMensaje = e.Message;
            }

            return result;
        }

        public IEnumerable<Productos> GetAllProductos()
        {
            try
            {
                return conec.Table<Productos>();
            }
            catch (Exception e)
            {
                EstadoMensaje = e.Message;
            }
            return Enumerable.Empty<Productos>();
        }
    }

}