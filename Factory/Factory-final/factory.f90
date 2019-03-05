! This module contains the factory class to
! produce products of the abstract class.
module m_factory
  use m_abstract, only: t_abstract
  implicit none
  private

  ! Define the class.
  type, public :: t_factory
    class(t_abstract), pointer :: a_product => null()
  contains

    procedure, public :: create => create_fn
    procedure, public :: clean
  end type t_factory

  ! Mark procedures as private
  private :: create_fn

contains

function create_fn(this, iswitch) result(ptr)
  use m_abstract, only: t_abstract
  use m_product1, only: t_product1
  use m_product2, only: t_product2
  implicit none

  ! Declare variables passed as arguments
  class(t_factory) :: this
  integer :: iswitch
  class(t_abstract), pointer :: ptr

  ! Declare local variables.
  integer :: ierr
  integer, parameter :: ndim = 1000000

  ierr = -1

  ! Destroy the product before creating a new one.
  if( associated(this%a_product) )then
    deallocate(this%a_product)
  end if

  ! Choose what to create.
  if( iswitch > 0 )then
    print*,"Factory: Creating Product 1."
    allocate(t_product1 :: this%a_product, stat=ierr)
  else
    print*,"Factory: Creating Product 2."
    allocate(t_product2 :: this%a_product, stat=ierr)
  end if

  call this%a_product%create(ndim)

  if( ierr /= 0 )then
    print*,"Factory: Creation failed."

    ptr => null()
  else
    print*,"Factory: Creation success."

    ! Associate the pointer with the the product.
    ptr => this%a_product
  end if


end function create_fn

subroutine clean(this)
  implicit none

  ! Declare variables in the argument list.
  class(t_factory) :: this

  ! Declare local variables.
  integer :: ierr

  ierr = -1
  if( associated(this%a_product) )then
    deallocate(this%a_product, stat=ierr)
  end if
  if( ierr /= 0 )then
    print*,"Factory: Destroying product failed."
  else
    print*,"Factory: Destroying product success."
  end if

  if( associated(this%a_product) )then
    print*,"Factory: It's still associated!!!"
    nullify(this%a_product)
  end if

end subroutine clean

end module m_factory