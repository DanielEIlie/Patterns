module m_submain
  implicit none
  private
  
  public :: submain

  contains

subroutine submain(iter)
  use m_factory, only: t_factory
  use m_abstract, only: t_abstract
  implicit none

  integer, intent(in) :: iter

  type(t_factory) :: a_factory
  class(t_abstract), pointer :: a_product => null()

  integer :: iswitch

  ! Print iteration.
  print*,"Iteration: ",iter
  
  ! Set the switch.
  if( modulo(iter,2) == 0 )then
    iswitch = 1
  else
    iswitch = -1
  end if

  ! Create a product using the factory and get the handle.
  a_product => a_factory%create(iswitch)
    
  ! Use the product.
  call a_product%execute()
    
  ! Clean up.
  nullify(a_product)
  call a_factory%clean()

  print*," "
end subroutine submain

end module m_submain
