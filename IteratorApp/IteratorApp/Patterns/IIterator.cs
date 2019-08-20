using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorApp.Patterns
{
  public interface IIterator
  {
    void Primero();
    object Actual();
    object Siguiente();
    bool QuedanElementos();

  }
}
