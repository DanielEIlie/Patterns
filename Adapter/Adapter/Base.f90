module base
  implicit none
  private

  type, public, abstract :: typeBase
    private
  contains
    procedure( BaseProcedureX ), deferred :: BaseProcedure
  end type typeBase

  abstract interface
    subroutine BaseProcedureX( this, anInteger )
      import typeBase
      implicit none

      class( typeBase ) :: this
      integer, intent( in ) :: anInteger
    end subroutine BaseProcedureX
  end interface

end module base