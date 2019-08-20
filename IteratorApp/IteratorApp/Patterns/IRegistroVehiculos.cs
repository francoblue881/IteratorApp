using IteratorApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorApp.Patterns
{
  public interface IRegistroVehiculos
  {
    void InsertarVehiculo(string marca, string modelo, double precio, string img);
    Vehiculo MostrarInformacionVehiculo(int indice);
    IIterator ObtenerIterator();    IIterator ObtenerIteratorMarca(string marca);
  }
}
