namespace CSharp.Commands
{
  class CopyCommand : Command
  {
    bool _isConfigured;
    int _startIndex;
    int _length;

    public CopyCommand( Application app, Editor editor ) : base( app, editor ) { }

    /// <summary>
    /// Provide the start index and the length of the selection to perform the operation.
    /// </summary>
    /// <param name="startIndex"></param>
    /// <param name="length"></param>
    /// <returns>True if configured, false otherwise.</returns>
    public bool Configure( int startIndex, int length )
    {
      _startIndex = startIndex;
      _length = length;
      _isConfigured = true;
      return _isConfigured;
    }

    public override bool Execute()
    {
      if ( _isConfigured )
      {
        _app.Clipboard = _editor.GetSelection( _startIndex, _length );
        _isConfigured = false;
      }
      return false;
      // Command is not saved to history,
      // because it never changes the editor's state.
    }
  }
}
