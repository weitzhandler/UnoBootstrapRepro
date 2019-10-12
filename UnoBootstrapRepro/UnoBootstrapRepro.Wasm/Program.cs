using ClassLib;
using System;
using static System.Console;

namespace UnoBootstrapRepro.Wasm
{
  public class Program
  {
    static int Main(string[] args)
    {
      var hr = new string('*', 50);
      WriteLine(hr);
      WriteLine("Starting test...");
      try
      {
        Activator.CreateInstance<Container>();
      }
      catch (MissingMethodException e)
      {
        WriteLine(e);
        WriteLine(e.StackTrace);
      }

      WriteLine(hr);

      return 0;
    }
  }
}
