using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
  internal class Testing
  {
    internal static void TestingEditor()
    {
      Editor editor = new();
      editor.Text =
        "Around 59,000 homes and businesses are without power\n" +
        "as Storm Barra continues to track across\n" +
        "the northwest and northern half of the country.\n";
      Console.WriteLine( "Original String:" );
      Console.WriteLine( editor.Text );

      string selectedText = editor.GetSelection( 14, 20 );
      Console.WriteLine( "Testing GetSelection:" );
      Console.WriteLine( selectedText + "\n" );

      editor.Text = editor.InsertSelection( 14, "schools, universities, " );
      Console.WriteLine( "Testing InsertSelection:" );
      Console.WriteLine( editor.Text );

      editor.Text = editor.DeleteSelection( "schools, universities, " );
      Console.WriteLine( "Testing DeleteSelection with text:" );
      Console.WriteLine( editor.Text );

      editor.Text = editor.ReplaceSelection( selectedText, "businesses and homes" );
      Console.WriteLine( "Testing ReplaceSelection:" );
      Console.WriteLine( editor.Text );

      editor.Text = editor.DeleteSelection( 14, 21 );
      Console.WriteLine( "Testing DeleteSelection with indices:" );
      Console.WriteLine( editor.Text );
    }
  }
}
