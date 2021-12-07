module adaptee
  implicit none
  private

  type, public :: typeAdaptee
    real(8), private :: aDouble
  contains
    procedure :: Setter
    procedure :: Getter
  end type typeAdaptee

contains
  subroutine Setter( this, aDouble )
    implicit none

    class( typeAdaptee ) :: this
    real(8), intent( in ) :: aDouble

    this%aDouble = aDouble
  end subroutine Setter

  subroutine Getter( this, aDouble )
    implicit none

    class( typeAdaptee ) :: this
    real(8), intent(out) :: aDouble

    aDouble = this%aDouble
  end subroutine Getter

end module adaptee