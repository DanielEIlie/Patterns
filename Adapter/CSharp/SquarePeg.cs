using System;

namespace CSharp
{
  class SquarePeg
  {
    public double Width { get; private set; }
    //public double Radius { get => Width / Math.Sqrt( 2.0 ); }

    public SquarePeg( double width )
    {
      Width = width;
    }
  }
}
