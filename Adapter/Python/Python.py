from RoundHole import RoundHole
from RoundPeg import RoundPeg
from SquarePeg import SquarePeg

if __name__ == "__main__":
  roundHole10 = RoundHole(10.0)
  roundPeg10 = RoundPeg(10.0)
  roundPeg20 = RoundPeg(20.0)
  print(f"roundHole10 fits roundPeg10: {roundHole10.Fits( roundPeg10 )}")
  print(f"roundHole10 fits roundPeg10: {roundHole10.Fits( roundPeg20 )}")

  squarePeg10 = SquarePeg(10.0)
  print(f"roundHole10 fits squarePeg10: {roundHole10.Fits( squarePeg10 )}")
  # The above should not work

  squarePeg20 = SquarePeg(20.0)
  print(f"roundHole10 fits squarePeg10: {roundHole10.Fits( squarePeg20 )}")
  # Neither should this one, but it does.
