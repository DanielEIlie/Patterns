﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Commands
{
  class UndoCommand : Command
  {
    public UndoCommand( Application app, Editor editor ) : base( app, editor ) { }

    public override bool Execute()
    {
      _app.Undo();
      return false;
      // Although the state of the editor has changed,
      // this is not to be logged to history.
    }
  }
}