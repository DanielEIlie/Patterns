! This module contains the product1 class (subclass of abstract).
module m_product1
  use m_abstract, only: t_abstract
  implicit none
  private

  ! Define the class.  
  type, public, extends(t_abstract) :: t_product1
    integer, allocatable, dimension(:) :: productdata
  contains

    final :: clean
    procedure, public :: execute => execute_sub
    procedure, public :: create => create_sub
  end type t_product1

  ! Mark procedures as private
  private :: execute_sub
  private :: create_sub

contains

subroutine clean(this)
  implicit none

  ! Declare variables passed as arguments
  type(t_product1) :: this

  if( allocated(this%productdata) )then
    deallocate(this%productdata)
  end if

  print*,"Product 1: Destroying."
end subroutine clean


subroutine execute_sub(this)
  implicit none

  ! Declare variables passed as arguments
  class(t_product1) :: this
        
  print*,"Product 1: Using."
end subroutine execute_sub


subroutine create_sub(this, ndim)
  implicit none

  ! Declare variables passed as arguments
  class(t_product1) :: this
  integer, intent(in) :: ndim

  ! Declare local arguments.
  integer :: ierr

  allocate(this%productdata(ndim), stat=ierr)
  if( ierr == 0 )then
    print*,"Product 1: Create productdata success."
  else
    print*,"Product 1: Create productdata failure."
  end if
end subroutine create_sub

end module m_product1
