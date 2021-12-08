using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Commands
{
  class CopyCommand : Command
  {
    bool _isConfigured;
    int _startIndex;
    int _endIndex;

    public CopyCommand( Application app, Editor editor ) : base( app, editor ) { }

    public bool Configure( int startIndex, int endIndex )
    {
      _startIndex = startIndex;
      _endIndex = endIndex;
      _isConfigured = true;
      return _isConfigured;
    }

    public override bool Execute()
    {
      if ( _isConfigured )
      {
        _app.Clipboard = _editor.GetSelection( _startIndex, _endIndex );
        _isConfigured = false;
      }
      return false;
      // Command is not saved to history,
      // because it never changes the editor's state.
    }
  }
}
