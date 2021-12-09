#include "Editor.h"

std::string Editor::GetSelection(int startIndex, int length)
{
  if (strText.empty() ||
    length <= 0 ||
    startIndex + length - 1 >= strText.length())
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
  return nullptr // strText.replace();
}

std::string Editor::ReplaceSelection(std::string existingText, std::string newText)
{
  return nullptr // strText.replace();
}

std::string Editor::InsertSelection(int startIndex, std::string text)
{
  return nullptr // string();
}
