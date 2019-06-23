using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppProductos.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppProductos.Models;

namespace AppProductos.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductoPage : ContentPage
    {
        public ProductoPage()
        {
            InitializeComponent();
        }
        private void BInsert_Clicked(object sender, EventArgs e)
        {
            StatusMessage.Text = string.Empty;
            ProductosViewModel.Instance.AddNewProducto(dProducto.Text);
            StatusMessage.Text = ProductosViewModel.Instance.EstadoMensaje;
        }

        private void BListar_Clicked(object sender, EventArgs e)
        {
            var allProductos = ProductosViewModel.Instance.GetAllProductos();
            listaventas.ItemsSource = allProductos;
            StatusMessage.Text = ProductosViewModel.Instance.EstadoMensaje;
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {

        }
    }
}
