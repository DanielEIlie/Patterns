#include "Editor.h"

std::string Editor::GetSelection(int startIndex, int length)
{
  if (strText.empty() ||
    length <= 0 ||
    startIndex + length - 1 >= (int)strText.length())
  {
    return nullptr;
  }
  return strText.substr(startIndex, length);
}

std::string Editor::DeleteSelection(int startIndex, int length)
{
  return strText.erase(startIndex, length);
}

std::string Editor::DeleteSelection(std::string text)
{
  std::string str = strText;
  std::size_t findPos = str.find(text);

  while (findPos != std::string::npos)
  {
    str = DeleteSelection(findPos, text.length());
    findPos = str.find(text);
  }

  return str;
}

std::string Editor::ReplaceSelection(std::string existingText, std::string newText)
{
  std::string str = strText;
  std::size_t findPos = str.find(existingText);

  while (findPos != std::string::npos)
  {
    str = DeleteSelection(findPos, existingText.length());
    findPos = str.find(existingText);
  }

  return str;
}

std::string Editor::InsertSelection(int startIndex, std::string text)
{
  return strText.insert(startIndex, text);
}
