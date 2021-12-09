#pragma once
#include <string>
class Editor
{
public:
  std::string strText;
  std::string GetSelection(int startIndex, int length);
  std::string DeleteSelection(int startIndex, int length);
  std::string DeleteSelection(std::string text);
  std::string ReplaceSelection(std::string existingText, std::string newText);
  std::string InsertSelection(int startIndex, std::string text);
};

