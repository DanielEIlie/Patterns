// Cpp.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include "RoundHole.h"
#include "RoundPeg.h"
#include "SquarePeg.h"
#include "SquarePegAdapter.h"

int main()
{
  RoundHole roundHole10(10.0);
  RoundPeg roundPeg10(10.0);
  RoundPeg roundPeg20(20.0);

  std::cout << "roundHole10 fits roundPeg10: " << roundHole10.Fits(roundPeg10) << "\n";
  std::cout << "roundHole10 fits roundPeg20: " << roundHole10.Fits(roundPeg20) << "\n";

  SquarePeg squarePeg10(10.0);
  //std::cout << "roundHole10 fits squarePeg10: " << roundHole10.Fits(squarePeg10) <<"\n";
  //error C2664 : 'bool RoundHole::Fits(RoundPeg &)' : cannot convert argument 1 from 'SquarePeg' to 'RoundPeg &'

  SquarePeg squarePeg20(20.0);

  SquarePegAdapter squarePegAdapter10(squarePeg10);
  SquarePegAdapter squarePegAdapter20(squarePeg20);
  std::cout << "roundHole10 fits squarePegAdapter10: " << roundHole10.Fits(squarePegAdapter10) << "\n";
  std::cout << "roundHole10 fits squarePegAdapter20: " << roundHole10.Fits(squarePegAdapter20) << "\n";
}
