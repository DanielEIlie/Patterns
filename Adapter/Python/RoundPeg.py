class RoundPeg:
  def __init__(self, radius:float) -> None:
    self.__radius__ = radius

  @property
  def Radius(self) -> float:
    return self.__radius__
