module mSquarePeg
  implicit none
  private

  type, public :: SquarePeg
    private
    real(8) :: width

  contains
    procedure :: SetWidth
    procedure :: GetWidth
  end type

contains

  subroutine SetWidth( this, width )
    implicit none

    class( SquarePeg ) :: this
    real(8), intent( in ) :: width

    this%width = width
  end subroutine SetWidth

  real(8) function GetWidth( this )
    implicit none

    class( SquarePeg ) :: this

    GetWidth = this%width
  end function GetWidth

end module mSquarePeg