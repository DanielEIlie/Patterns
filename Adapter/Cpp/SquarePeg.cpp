#include <math.h>
#include "SquarePeg.h"

double SquarePeg::Radius()
{
  return dWidth / sqrt(2.0);
}
SquarePeg::SquarePeg(double width)
{
  dWidth = width;
}