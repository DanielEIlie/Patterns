namespace CSharp.Commands
{
  class CutCommand : Command
  {
    bool _isConfigured;
    int _startIndex;
    int _length;

    public CutCommand( Application app, Editor editor ) : base( app, editor ) { }

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
      if ( !_isConfigured )
      {
        return false;
      }
      SaveBackup();
      _app.Clipboard = _editor.GetSelection( _startIndex, _length );
      _editor.Text = _editor.DeleteSelection( _startIndex, _length );
      _isConfigured = false;
      return true;
    }
  }
}
