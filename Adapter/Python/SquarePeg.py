import math

class SquarePeg():
  def __init__(self, width:float) -> None:
    self.__width__ = width

  @property
  def Width(self) -> float:
    return self.__width__

  @property
  def Radius(self) -> float:
    return self.Width / math.sqrt(2.0)

