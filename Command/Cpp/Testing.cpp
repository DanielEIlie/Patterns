#include <iostream>
#include "Testing.h"
#include "Editor.h"

void Testing::Clear()
{
#if defined _WIN32
  system("cls");
  //clrscr(); // including header file : conio.h
#elif defined (__LINUX__) || defined(__gnu_linux__) || defined(__linux__)
  system("clear");
  //std::cout<< u8"\033[2J\033[1;1H"; //Using ANSI Escape Sequences
#elif defined (__APPLE__)
  system("clear");
#endif
}

void Testing::Pause()
{
  std::cout << "Press [Enter] to continue:";
  std::cin;
  Clear();
}

void Testing::TestingEditor()
{
  Editor editor;
  editor.strText =
    "Around 59,000 homes and businesses are without power\n";
  editor.strText.append(
    "as Storm Barra continues to track across\n");
  editor.strText.append(
    "the northwest and northern half of the country.\n");
  std::cout << "\nOriginal String:\n";
  std::cout << editor.strText;

  std::string selectedText = editor.GetSelection(14, 20);
  std::cout << "\nTesting GetSelection:\n";
  std::cout << selectedText + "\n";

  editor.strText = editor.InsertSelection(14, "schools, universities, ");
  std::cout << "\nTesting InsertSelection:\n";
  std::cout << editor.strText;

  editor.strText = editor.DeleteSelection("schools, universities, ");
  std::cout << "\nTesting DeleteSelection with text:\n";
  std::cout << editor.strText;

  editor.strText = editor.ReplaceSelection(selectedText, "businesses and homes");
  std::cout << "\nTesting ReplaceSelection:\n";
  std::cout << editor.strText;

  editor.strText = editor.DeleteSelection(14, 21);
  std::cout << "\nTesting DeleteSelection with indices:\n";
  std::cout << editor.strText;
}

void Testing::TestingApplication()
{
}
