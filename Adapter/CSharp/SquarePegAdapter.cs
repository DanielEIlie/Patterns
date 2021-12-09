using System;

namespace CSharp
{
  class SquarePegAdapter : RoundPeg
  {
    //SquarePeg _squarePeg;

    public SquarePegAdapter( SquarePeg squarePeg ) : base( squarePeg.Width / Math.Sqrt( 2.0 ) )
    {
      //_squarePeg = squarePeg;
    }

  }
}
