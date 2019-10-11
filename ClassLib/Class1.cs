using System;

namespace ClassLib
{
  public class Container
  {
    public Container()
    { 
    }

    public static void ActivateContainer() =>
      Activator.CreateInstance<Container>();

  }
}
