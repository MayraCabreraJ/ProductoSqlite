using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppProductos.ViewModels;
using AppProductos.View;

namespace AppProductos
{
    public partial class App : Application
    {
        public App(String filename)
        {
            InitializeComponent();

            ProductosViewModel.Inicializador(filename);
            MainPage = new ProductoPage();
        }


        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
