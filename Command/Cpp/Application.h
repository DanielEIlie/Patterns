#pragma once
#include <vector>
#include <string>

class Application
{
private:
  std::vector<class Editor*> m_editors;
public:
  class Editor* m_activeEditor = nullptr;
  std::string m_strClipboard;
  ~Application();
  void CreateUI();
  void ExecuteCommand(class Command& command);
  void Undo();
};

