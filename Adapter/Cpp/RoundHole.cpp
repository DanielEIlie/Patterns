#include "RoundHole.h"
#include "RoundPeg.h"

RoundHole::RoundHole(double radius)
{
  dRadius = radius;
}

bool RoundHole::Fits(RoundPeg& roundPeg)
{
  return dRadius >= roundPeg.GetRadius();
}
