module extended1
  use base, only: typeBase
  implicit none
  private

  type, public, extends( typeBase ) :: typeExtended1
    private
  contains
    procedure :: BaseProcedure => Extended1Procedure
  end type typeExtended1

  private :: Extended1Procedure
contains

  subroutine Extended1Procedure( this, anInteger )
    implicit none

    class( typeExtended1 ) :: this
    integer, intent( in ) :: anInteger

    print*,"This is extended1Procedure", anInteger
  end subroutine Extended1Procedure
end module extended1