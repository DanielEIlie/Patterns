using System;

namespace CSharp
{
  class Program
  {
    static void Main(string[] args)
    {
      RoundHole roundHole10 = new( 10.0 );
      RoundPeg roundPeg10 = new( 10.0 );
      RoundPeg roundPeg20 = new( 20.0 );
      Console.WriteLine( $"roundHole10 fits roundPeg10: {roundHole10.Fits( roundPeg10 )}" );
      Console.WriteLine( $"roundHole10 fits roundPeg20: {roundHole10.Fits( roundPeg20 )}" );

      SquarePeg squarePeg10 = new( 10.0 );
      // Console.WriteLine( $"roundHole10 fits squarePeg10: {roundHole10.Fits( squarePeg10 )}" );
      // error CS1503: Argument 1: cannot convert from 'CSharp.SquarePeg' to 'CSharp.RoundPeg'

      SquarePeg squarePeg20 = new( 20.0 );

      SquarePegAdapter squarePegAdapter10 = new( squarePeg10 );
      SquarePegAdapter squarePegAdapter20 = new( squarePeg20 );
      Console.WriteLine( $"roundHole10 fits squarePeg10: {roundHole10.Fits( squarePegAdapter10 )}" );
      Console.WriteLine( $"roundHole10 fits squarePeg20: {roundHole10.Fits( squarePegAdapter20 )}" );
    }
  }
}
