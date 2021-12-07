module mSquarePegAdapter
  use mRoundPeg, only: RoundPeg
  use mSquarePeg, only: SquarePeg
  implicit none
  private

  type, public, extends(RoundPeg) :: SquarePegAdapter
    private
    type(SquarePeg) :: aSquarePeg

  contains
    procedure :: SetSquarePeg
    procedure :: GetRadius
  end type

contains

  subroutine SetSquarePeg( this, aSquarePeg )
    implicit none

    class( SquarePegAdapter ) :: this
    type( SquarePeg ), intent( in ) :: aSquarePeg

    this%aSquarePeg = aSquarePeg
  end subroutine SetSquarePeg

  real(8) function GetRadius( this )
    implicit none

    class( SquarePegAdapter ) :: this

    GetRadius = this%aSquarePeg%GetWidth() / dsqrt( 2.d0 )
  end function GetRadius

end module mSquarePegAdapter