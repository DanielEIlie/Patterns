#pragma once
#include <string>
#include "Editor.h"

class Command
{
private:
  Editor editor;
  std::string strBackup;

public:
  Command() = delete;
  Command(Editor inEditor);
  void SaveBackup();
  void Undo();
  virtual void Execute() = 0;
  ~Command() {};
};

