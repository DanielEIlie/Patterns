! This module contains the abstract class
module m_abstract
  implicit none
  private

  ! Define the class.  
  type, abstract, public :: t_abstract
  contains

    procedure(abstract_x), public, deferred :: execute
    procedure(create_x), public, deferred :: create
  end type t_abstract

  ! Declare abstract interface (template for the deferred procedure)
  abstract interface
    subroutine abstract_x(this)
      import t_abstract
      implicit none
    
      ! Declare variables passed as arguments
      class(t_abstract) :: this
    end subroutine abstract_x
  end interface

  abstract interface
    subroutine create_x(this, ndim)
      import t_abstract
      implicit none
    
      ! Declare variables passed as arguments
      class(t_abstract) :: this
      integer, intent(in) :: ndim
    end subroutine create_x
  end interface

end module m_abstract
