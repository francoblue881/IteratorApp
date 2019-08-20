using IteratorApp.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorApp.Patterns
{
  class RegistroVehiculos : IRegistroVehiculos
  {
    private ArrayList listaVehiculos;
    public RegistroVehiculos()
    {
      this.listaVehiculos = new ArrayList();
    }

    public void InsertarVehiculo(string marca, string modelo, double
   precio, string img)
    {
      Vehiculo v = new Vehiculo(marca, modelo, DateTime.Now, precio, img);
      listaVehiculos.Add(v);
    }
    public Vehiculo MostrarInformacionVehiculo(int indice)
    {
      return (Vehiculo)listaVehiculos[indice];
    }
    public IIterator ObtenerIterator()
    {
      return new Iterator(listaVehiculos);
    }

    public IIterator ObtenerIteratorMarca(string marca)
    {
      ArrayList listaMarcas= new ArrayList();
      foreach (var item in listaVehiculos)
      {
        Vehiculo v = (Vehiculo)item;
        if (v.Marca== marca)
        {
          listaMarcas.Add(item);
        }
      }
      return new Iterator(listaMarcas);
    }
  }
}
