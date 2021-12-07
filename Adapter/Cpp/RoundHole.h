#pragma once
class RoundHole
{
private:
  double dRadius;
public:
  RoundHole(double radius);
  bool Fits(class RoundPeg& roundPeg);
};


