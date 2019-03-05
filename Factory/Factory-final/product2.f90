! This module contains the product2 class (subclass of abstract).
module m_product2
  use m_abstract, only: t_abstract
  implicit none
  private

  ! Define the class.  
  type, public, extends(t_abstract) :: t_product2
    integer, allocatable, dimension(:) :: productdata
  contains

    final :: clean
    procedure, public :: execute => execute_sub
    procedure, public :: create => create_sub
  end type t_product2

  ! Mark procedures as private
  private :: execute_sub
  private :: create_sub

contains

subroutine clean(this)
  implicit none

  ! Declare variables passed as arguments
  type(t_product2) :: this

  if( allocated(this%productdata) )then
    deallocate(this%productdata)
  end if

  print*,"Product 2: Destroying."
end subroutine clean


subroutine execute_sub(this)
  implicit none

  ! Declare variables passed as arguments
  class(t_product2) :: this
        
  print*,"Product 2: Using."
end subroutine execute_sub


subroutine create_sub(this, ndim)
  implicit none

  ! Declare variables passed as arguments
  class(t_product2) :: this
  integer, intent(in) :: ndim

  ! Declare local arguments.
  integer :: ierr

  allocate(this%productdata(ndim), stat=ierr)
  if( ierr == 0 )then
    print*,"Product 2: Create productdata success."
  else
    print*,"Product 2: Create productdata failure."
  end if
end subroutine create_sub

end module m_product2
