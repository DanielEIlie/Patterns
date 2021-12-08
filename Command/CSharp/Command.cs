namespace CSharp
{
  abstract class Command
  {
    private Application _app;
    private Editor _editor;
    private string _backup;

    public Command(Application app, Editor editor)
    {
      _app = app;
      _editor = editor;
    }

    /// <summary>
    /// Makes a backup of the editor's state.
    /// </summary>
    public void SaveBackup()
    {
      _backup = _editor.Text;
    }

    /// <summary>
    /// Restores the stored editor's state.
    /// </summary>
    public void Undo()
    {
      _editor.Text = _backup;
    }

    /// <summary>
    /// Executes the command.
    /// </summary>
    /// <returns>True if the editor's state was changed, false otherwise.</returns>
    public abstract bool Execute();
  }
}
