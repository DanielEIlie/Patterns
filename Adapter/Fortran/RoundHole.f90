module mRoundHole
  implicit none
  private

  type, public :: RoundHole
    private
    real(8) :: radius

  contains
    procedure :: SetRadius
    procedure :: GetRadius
    procedure :: Fits
  end type

contains

  subroutine SetRadius( this, radius )
    implicit none

    class( RoundHole ) :: this
    real(8), intent( in ) :: radius

    this%radius = radius
  end subroutine SetRadius

  real(8) function GetRadius( this )
    implicit none

    class( RoundHole ) :: this

    GetRadius = this%radius
  end function GetRadius

  logical function Fits( this, aRoundPeg )
    use mRoundPeg, only: RoundPeg
    implicit none

    class( RoundHole ) :: this
    class( RoundPeg ), intent( in ) :: aRoundPeg

    Fits = this%GetRadius() >= aRoundPeg.GetRadius()
  end function Fits
end module mRoundHole