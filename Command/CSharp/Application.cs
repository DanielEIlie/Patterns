using System.Collections.Generic;

namespace CSharp
{
  class Application
  {
    readonly List<Editor> _editors = new();
    readonly CommandHistory _history = new();
    Editor activeEditor { get; set; }
    string clipboard { get; set; }

    /// <summary>
    /// Creates the user interface.
    /// </summary>
    /// <returns>True if successful, false otherwise.</returns>
    public bool CreateUI()
    {
      return true;
    }

    /// <summary>
    /// Executes a specified command.
    /// </summary>
    /// <param name="command"></param>
    /// <returns>True if successful, false otherwise.</returns>
    public bool ExecuteCommand(Command command)
    {
      return true;
    }

    /// <summary>
    /// Undoes the last command, reverting the editor's state.
    /// </summary>
    /// <returns>True if successful, false otherwise.</returns>
    public bool Undo()
    {
      Command command = _history.Pop();
      if( command == null )
      {
        return false;
      }
      command.Undo();
      return true;
    }
  }
}
