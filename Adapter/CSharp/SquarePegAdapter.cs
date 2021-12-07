using System;

namespace CSharp
{
  class SquarePegAdapter : RoundPeg
  {
    SquarePeg _squarePeg;

    public SquarePegAdapter( SquarePeg squarePeg ) : base( squarePeg.Radius )
    {
      _squarePeg = squarePeg;
    }

  }
}
