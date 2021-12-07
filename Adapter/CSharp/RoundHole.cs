namespace CSharp
{
  class RoundHole
  {
    public double Radius { get; private set; }

    public RoundHole( double radius )
    {
      Radius = radius;
    }

    public bool Fits( RoundPeg roundPeg )
    {
      return Radius >= roundPeg.Radius;
    }
  }
}
