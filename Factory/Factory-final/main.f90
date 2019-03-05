program factory
  use m_submain, only: submain
  implicit none

  integer :: i

  print*,"This is a factory example."
  print*,"Two products are mades over a long period."
  print*,"Making sure there are no memory leaks on object finamization."
  print*,"You can track the process in Process Explorer or Task Manager."
  print*,"Hit a key to start... CTRL-C to exit or be patient about this."
  read(*,*)
  do i = 1, 100000000
    call submain(i)
  end do

end program factory

