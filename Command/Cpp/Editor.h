#pragma once
#include <string>
using namespace std;
class Editor
{
public:
  string strText;
  string GetSelection(int startIndex, int length);
  string DeleteSelection(int startIndex, int length);
  string DeleteSelection(string text);
  string ReplaceSelection(string existingText, string newText);
  string InsertSelection(int startIndex, string text);
};

