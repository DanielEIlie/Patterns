namespace CSharp
{
  class Editor
  {
    public string Text { get; set; }

    public string GetSelection( int startIndex, int length )
    {
      if ( !string.IsNullOrEmpty( Text ) &&
        length > 0 &&
        startIndex + length - 1 < Text.Length )
      {
        return Text.Substring( startIndex, length );
      }
      return null;
    }

    public string DeleteSelection( int startIndex, int length )
    {
      return Text.Remove( startIndex, length );
    }

    public string DeleteSelection( string text )
    {
      return Text.Replace( text, "" ); // or ReplaceSelection( text, "" );
    }

    public string ReplaceSelection( string existingText, string newText )
    {
      return Text.Replace(existingText, newText);
    }

    public string InsertSelection( int startIndex, string text )
    {
      return Text.Insert( startIndex, text );
    }
  }
}
