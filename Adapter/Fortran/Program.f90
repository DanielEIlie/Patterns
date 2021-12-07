program main
  use mRoundHole, only: RoundHole
  use mRoundPeg, only: RoundPeg
  use mSquarePeg, only: SquarePeg
  use mSquarePegAdapter, only: SquarePegAdapter
  implicit none

  type(RoundHole) :: roundHole10
  type(RoundPeg) :: roundPeg10
  type(RoundPeg) :: roundPeg20

  type(SquarePeg) :: squarePeg10
  type(SquarePeg) :: squarePeg20

  type(SquarePegAdapter) :: squarePegAdapter10
  type(SquarePegAdapter) :: squarePegAdapter20

  call roundHole10%SetRadius( 10.d0 )
  call roundPeg10%SetRadius( 10.d0 )
  call roundPeg20%SetRadius( 20.d0 )
  print *, "roundHole10 fits roundPeg10: ", roundHole10.Fits( roundPeg10 )
  print *, "roundHole10 fits roundPeg20: ", roundHole10.Fits( roundPeg20 )

  call squarePeg10%SetWidth( 10.d0 )
  ! print *, "roundHole10 fits squarePeg10: ", roundHole10.Fits( squarePeg10 )
  ! error #6633: The type of the actual argument differs from the type of the dummy argument.   [SQUAREPEG10]

  call squarePeg20%SetWidth( 20.d0 )

  call squarePegAdapter10%SetSquarePeg( squarePeg10 )
  call squarePegAdapter20%SetSquarePeg( squarePeg20 )
  print *, "roundHole10 fits squarePeg10: ", roundHole10.Fits( squarePegAdapter10 )
  print *, "roundHole10 fits squarePeg20: ", roundHole10.Fits( squarePegAdapter20 )

end program main