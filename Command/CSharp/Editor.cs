namespace CSharp
{
  class Editor
  {
    public string Text { get; set; }

    /// <summary>
    /// Returns the selected text from the start index and for the specified length.
    /// </summary>
    /// <param name="startIndex"></param>
    /// <param name="length"></param>
    /// <returns>String if successful or null otherwise.</returns>
    public string GetSelection( int startIndex, int length )
    {
      if ( string.IsNullOrEmpty( Text ) ||
        length <= 0 ||
        startIndex + length - 1 >= Text.Length )
      {
        return null;
      }
      return Text.Substring( startIndex, length );
    }

    /// <summary>
    /// Deletes the selected text from the start index and for the specified length.
    /// </summary>
    /// <param name="startIndex"></param>
    /// <param name="length"></param>
    /// <returns>The modified string.</returns>
    public string DeleteSelection( int startIndex, int length )
    {
      return Text.Remove( startIndex, length );
    }

    /// <summary>
    /// Deletes the specified text.
    /// </summary>
    /// <param name="text"></param>
    /// <returns>The modified string.</returns>
    public string DeleteSelection( string text )
    {
      return Text.Replace( text, "" ); // or ReplaceSelection( text, "" );
    }

    /// <summary>
    /// Replaces the <c>existingText</c> with <c>newText</c>
    /// </summary>
    /// <param name="existingText"></param>
    /// <param name="newText"></param>
    /// <returns>The modified string.</returns>
    public string ReplaceSelection( string existingText, string newText )
    {
      return Text.Replace(existingText, newText);
    }

    /// <summary>
    /// Inserts the text at the specified index.
    /// </summary>
    /// <param name="startIndex"></param>
    /// <param name="text"></param>
    /// <returns>The modified string.</returns>
    public string InsertSelection( int startIndex, string text )
    {
      return Text.Insert( startIndex, text );
    }
  }
}
