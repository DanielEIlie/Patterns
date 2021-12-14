#include "Application.h"
#include "Editor.h"

Application::~Application()
{
  for (Editor* editor : m_editors)
  {
    delete editor;
  }
  m_editors.clear();
}

void Application::CreateUI()
{
  m_activeEditor = new Editor();
  m_editors.push_back(m_activeEditor);
}

void Application::ExecuteCommand(Command& command)
{
}

void Application::Undo()
{
}
