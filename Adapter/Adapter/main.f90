program main
  use base, only: typeBase
  use extended1, only: typeExtended1
  use extended2, only: typeExtended2
  implicit none

  class(typeBase), pointer :: objBase
  type(typeExtended1), target :: objExtended1
  type(typeExtended2), target :: objExtended2

  nullify(objBase)
  objBase => objExtended1
  call objBase%baseProcedure( 1 )
  ! There are many objects of type typeExtended1
  ! Open-Closed Principle does not allow this class modification.

  ! But there may be one different object of type objExtended2
  ! How is the class extended?
  ! Adapter Pattern!
  nullify(objBase)
  objBase => objExtended2
  call objExtended2%SetAdaptee( 64.32d0 )
  call objBase%baseProcedure( 2 )
end program main