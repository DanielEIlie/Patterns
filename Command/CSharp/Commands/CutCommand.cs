namespace CSharp.Commands
{
  class CutCommand : Command
  {
    bool _isConfigured;
    int _startIndex;
    int _endIndex;

    public CutCommand( Application app, Editor editor ) : base( app, editor ) { }

    /// <summary>
    /// Provide the start and end indices to perform the operation.
    /// </summary>
    /// <param name="startIndex"></param>
    /// <param name="endIndex"></param>
    /// <returns>True if configured, false otherwise.</returns>
    public bool Configure( int startIndex, int endIndex )
    {
      _startIndex = startIndex;
      _endIndex = endIndex;
      _isConfigured = true;
      return _isConfigured;
    }

    public override bool Execute()
    {
      if ( !_isConfigured )
      {
        return false;
      }
      SaveBackup();
      _app.Clipboard = _editor.GetSelection( _startIndex, _endIndex );
      _editor.DeleteSelection( _startIndex, _endIndex - _startIndex + 1 );
      _isConfigured = false;
      return true;
    }
  }
}
