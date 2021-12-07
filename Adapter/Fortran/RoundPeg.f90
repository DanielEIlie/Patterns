module mRoundPeg
  implicit none
  private

  type, public :: RoundPeg
    private
    real(8) :: radius

  contains
    procedure :: SetRadius
    procedure :: GetRadius
  end type

contains

  subroutine SetRadius( this, radius )
    implicit none

    class( RoundPeg ) :: this
    real(8), intent( in ) :: radius

    this%radius = radius
  end subroutine SetRadius

  real(8) function GetRadius( this )
    implicit none

    class( RoundPeg ) :: this

    GetRadius = this%radius
  end function GetRadius

end module mRoundPeg