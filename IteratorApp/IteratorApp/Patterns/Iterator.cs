using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorApp.Patterns
{
  public class Iterator : IIterator
  {
    private ArrayList Items;

    private int posicionActual = 0;

    public Iterator(ArrayList LISTA)
    {
      Items = LISTA;
    }

    public object Actual()
    {
      if ((this.Items == null) || (this.Items.Count == 0)
        || (posicionActual >= this.Items.Count))
      {
        return null;

      }
      else { return this.Items[posicionActual]; }
    }
    public void Primero()
    {
      this.posicionActual = 0;
    }
    public bool QuedanElementos()
    {
      return (posicionActual < this.Items.Count - 1);
    }
    public object Siguiente()
    {
      if ((this.Items == null) || (this.Items.Count == 0) || (posicionActual
     + 1 >= this.Items.Count))
      {
        return null;
      }
      else { return this.Items[++posicionActual]; }
    }
  }
}
