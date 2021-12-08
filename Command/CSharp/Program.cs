using System;

namespace CSharp
{
  class Program
  {
    static void Main( string[] args )
    {
      //Testing.TestingEditor();

      Editor editor1 = new();
      Application application = new();
      application.editors.Add( editor1 );

    }
  }
}
