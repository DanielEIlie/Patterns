using System.Collections.Generic;

namespace CSharp
{
  /// <summary>
  /// Class <c>CommandHistory</c> implements a command stack.
  /// </summary>
  class CommandHistory
  {

    private readonly List<Command> _stack = new();

    /// <summary>
    /// Returns the number of objects in the stack.
    /// </summary>
    /// <returns></returns>
    internal int Count()
    {
      return _stack.Count;
    }

    /// <summary>
    /// Pushes command on top of the stack.
    /// </summary>
    /// <param name="command">Any object.</param>
    internal void Push( Command command )
    {
      if ( command == null ) return;
      _stack.Add( command );
    }

    /// <summary>
    /// Pops command from the top of the stack.
    /// </summary>
    /// <returns>Popped command or null</returns>
    internal Command Pop()
    {
      int position = _stack.Count - 1;
      if ( position < 0 ) return null;

      Command command = _stack[ position ];
      _stack.RemoveAt( position );
      return command;
    }

    /// <summary>
    /// Clears the entire stack.
    /// </summary>
    internal void Clear()
    {
      _stack.Clear();
    }
  }
}
