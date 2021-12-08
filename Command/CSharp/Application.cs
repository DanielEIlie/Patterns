using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
  class Application
  {
    public readonly List<Editor> editors = new();
    public Editor activeEditor { get; set; }
    public string clipboard { get; set; }
    //command history

    public bool ExecuteCommand()
    {
      return true;
    }
    //undo
  }
}
