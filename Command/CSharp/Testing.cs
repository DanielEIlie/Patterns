using System;
using CSharp.Commands;

namespace CSharp
{
  internal class Testing
  {
    internal static void Pause()
    {
      Console.WriteLine( "Press [Enter] to continue:" );
      Console.ReadLine();
      Console.Clear();
    }

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

      Pause();
    }

    internal static void TestingApplication()
    {
      Application application = new();
      application.CreateUI();
      application.ActiveEditor.Text =
        "Around 59,000 homes and businesses are without power\n" +
        "as Storm Barra continues to track across\n" +
        "the northwest and northern half of the country.\n";

      Console.WriteLine( "Text:" );
      Console.WriteLine( application.ActiveEditor.Text );
      Pause();

      CopyCommand copyCmd = new( application, application.ActiveEditor );
      CutCommand cutCmd = new( application, application.ActiveEditor );
      PasteCommand pasteCmd = new( application, application.ActiveEditor );
      PasteCommand pasteCmd2 = new( application, application.ActiveEditor );
      UndoCommand undoCmd = new( application, application.ActiveEditor );

      Console.WriteLine( "\nOld Text:" );
      Console.WriteLine( application.ActiveEditor.Text );
      cutCmd.Configure( 14, 21 );
      application.ExecuteCommand( cutCmd );
      Console.WriteLine( "\nCut Text:" );
      Console.WriteLine( application.Clipboard );
      Console.WriteLine( "\nNew Text:" );
      Console.WriteLine( application.ActiveEditor.Text );
      Pause();

      Console.WriteLine( "\nOld Text:" );
      Console.WriteLine( application.ActiveEditor.Text );
      copyCmd.Configure( 0, 7 );
      application.ExecuteCommand( copyCmd );
      Console.WriteLine( "\n\nCopied Text:" );
      Console.WriteLine( application.Clipboard );
      Console.WriteLine( "\nNew Text:" );
      Console.WriteLine( application.ActiveEditor.Text );
      Pause();

      Console.WriteLine( "\nOld Text:" );
      Console.WriteLine( application.ActiveEditor.Text );
      pasteCmd.Configure( 73 );
      application.ExecuteCommand( pasteCmd );
      Console.WriteLine( "\n\nPaste-Insert Text:" );
      Console.WriteLine( application.Clipboard );
      Console.WriteLine( "\nNew Text:" );
      Console.WriteLine( application.ActiveEditor.Text );
      Pause();

      Console.WriteLine( "\nOld Text:" );
      Console.WriteLine( application.ActiveEditor.Text );
      pasteCmd2.Configure( "Barra " );
      application.ExecuteCommand( pasteCmd2 );
      Console.WriteLine( "\n\nPaste-OverSelection Text:" );
      Console.WriteLine( application.Clipboard );
      Console.WriteLine( "\nNew Text:" );
      Console.WriteLine( application.ActiveEditor.Text );
      Pause();

      const int noUndos = 10;
      for ( int i = 1; i < noUndos+1; i++ )
      {
        Console.WriteLine( $"\nUndo {i} out of {noUndos}:");
        Console.WriteLine( "\nOld Text:" );
        Console.WriteLine( application.ActiveEditor.Text );
        application.ExecuteCommand( undoCmd );
        Console.WriteLine( "\nNew Text:" );
        Console.WriteLine( application.ActiveEditor.Text );
        Pause();
      }
    }
  }
}
