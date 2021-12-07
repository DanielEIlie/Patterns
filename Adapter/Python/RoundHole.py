from RoundPeg import RoundPeg

class RoundHole():
  def __init__(self, radius:float) -> None:
    self.__radius__ = radius

  @property
  def Radius(self) -> float:
    return self.__radius__

  def Fits(self, roundPeg:RoundPeg) -> bool:
    return self.Radius >= roundPeg.Radius
