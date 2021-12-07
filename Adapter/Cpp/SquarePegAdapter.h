#pragma once
#include "RoundPeg.h"
#include "SquarePeg.h"
class SquarePegAdapter : public RoundPeg
{
private:
  SquarePeg squarePeg;
public:
  SquarePegAdapter(SquarePeg inSquarePeg);
};

