#include "SquarePegAdapter.h"
#include "RoundPeg.h"

SquarePegAdapter::SquarePegAdapter(SquarePeg inSquarePeg) :RoundPeg(inSquarePeg.Radius()), squarePeg(inSquarePeg)
{
}
