using Android.Widget;
using IteratorApp.Models;
using IteratorApp.Patterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IteratorApp
{
  public partial class MainPage : ContentPage
  {

    //PROPIEDADES
    IIterator iterator;
    IRegistroVehiculos reg;
    Vehiculo vehiculoActual;

    public MainPage()
    {
      InitializeComponent();

      reg = new RegistroVehiculos();
      reg.InsertarVehiculo("Mazda", "3", 1, "Car1.png");
      reg.InsertarVehiculo("Mazda", "3", 2, "Car7.png");
      reg.InsertarVehiculo("Mazda", "3", 3, "Car6.png");
      reg.InsertarVehiculo("Mazda", "3", 4, "Car4.png");
      reg.InsertarVehiculo("Ferrary", "Mux", 55000, "Car2.png");
      reg.InsertarVehiculo("BMW", "SkyNight", 24000, "Car3.png");


      iterator = reg.ObtenerIteratorMarca("Mazda");

      this.ActualizarDatosVehiculo();
    }

    public void ActualizarDatosVehiculo()
    {
      vehiculoActual = (Vehiculo)iterator.Actual();
      txtDescripcion.Text = vehiculoActual.CaracteristicasVehiculo();
      imgPhoto.Source = vehiculoActual.Img;
    }    private void BtnPrimero_Clicked(object sender, EventArgs e)
    {
      iterator.Primero();
      ActualizarDatosVehiculo();
    }    private void BtnHasNext_Clicked(object sender, EventArgs e)
    {
      if (iterator.QuedanElementos())
      {
        Toast.MakeText(Android.App.Application.Context, "AÚN QUEDAN AUTOS",
       ToastLength.Short).Show();
      }
      else //Es porque ya no hay más datos después
      {
        RegresarAlPrimeroPregunta();
      }
    }    private async void RegresarAlPrimeroPregunta() {
      //En caso que llegué al final de la collección, que vuelva a empezar
      var respuesta = await DisplayAlert("No quedan más elementos", 
        "¿Regresar al primero ? ", "Sí", "No");
        if (respuesta)
        {
          iterator.Primero();
          ActualizarDatosVehiculo();
        }    }    private void BtnNext_Clicked(object sender, EventArgs e)
    {
      if (iterator.QuedanElementos())
      {
        iterator.Siguiente();
        ActualizarDatosVehiculo();
      }
      else //Es porque ya no hay más datos después
      {
        RegresarAlPrimeroPregunta();
      }
    }


  }
}
