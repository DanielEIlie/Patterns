using System.Collections.Generic;

namespace CSharp
{
  class Application
  {
    readonly List<Editor> _editors = new();
    readonly CommandHistory _history = new();
    internal Editor ActiveEditor { get; set; }
    internal string Clipboard { get; set; }

    /// <summary>
    /// Creates the user interface.
    /// </summary>
    public void CreateUI()
    {
      _editors.Add( new Editor() );
      ActiveEditor = _editors[_editors.Count - 1];
    }

    /// <summary>
    /// Executes a specified command.
    /// </summary>
    /// <param name="command"></param>
    public void ExecuteCommand( Command command )
    {
      if ( command.Execute() )
      {
        _history.Push( command );
      }
    }

    /// <summary>
    /// Undoes the last command, reverting the editor's state.
    /// </summary>
    public void Undo()
    {
      Command command = _history.Pop();
      if ( command != null )
      {
        command.Undo();
      }
    }
  }
}
