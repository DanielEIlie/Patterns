module extended2
  use base, only: typeBase
  use adaptee, only: typeAdaptee
  implicit none
  private

  type, public, extends( typeBase ) :: typeExtended2
    private
    type( typeAdaptee ), private :: objAdaptee
  contains
    procedure :: BaseProcedure => Extended2Procedure
    procedure :: SetAdaptee
  end type typeExtended2

  private :: Extended2Procedure
contains

  subroutine Extended2Procedure( this, anInteger )
    implicit none

    class( typeExtended2 ) :: this
    integer, intent( in ) :: anInteger

    real(8) :: aDouble

    call this%objadaptee%Getter( aDouble )

    print*,"This is extended2Procedure", anInteger
    print*,"Received Adaptee data", aDouble
  end subroutine Extended2Procedure

  subroutine SetAdaptee( this, aDouble )
    implicit none

    class( typeExtended2 ) :: this
    real(8), intent(in) :: aDouble

    call this%objAdaptee%setter( aDouble )
  end Subroutine SetAdaptee

end module extended2