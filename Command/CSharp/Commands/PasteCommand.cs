using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Commands
{
  class PasteCommand : Command
  {
    bool _isConfigured;
    int _startIndex;
    string _existingText = null;

    public PasteCommand( Application app, Editor editor ) : base( app, editor ) { }

    /// <summary>
    /// Provide the string index to make an insertion.
    /// </summary>
    /// <param name="startIndex"></param>
    /// <returns>True if configured, false otherwise.</returns>
    public bool Configure( int startIndex )
    {
      _startIndex = startIndex;
      _isConfigured = true;
      return _isConfigured;
    }

    /// <summary>
    /// Provide the text to be replaced.
    /// </summary>
    /// <param name="existingText"></param>
    /// <returns>True if configured, false otherwise.</returns>
    public bool Configure( string existingText )
    {
      _existingText = existingText;
      _isConfigured = !string.IsNullOrEmpty( existingText );
      return _isConfigured;
    }

    public override bool Execute()
    {
      if ( !_isConfigured )
      {
        return false;
      }
      SaveBackup();
      if ( string.IsNullOrEmpty( _existingText ) )
      {
        _editor.InsertSelection( _startIndex, _app.Clipboard );
      }
      else
      {
        _editor.ReplaceSelection( _existingText, _app.Clipboard );
      }
      _isConfigured = false;
      return true;
    }

  }
}
