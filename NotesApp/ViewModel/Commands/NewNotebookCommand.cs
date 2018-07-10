using System;
using System.Windows.Input;

namespace NotesApp.ViewModel.Commands
{
    public class NewNotebookCommand : ICommand
    {
        public NotesViewModel VM { get; set; }

        public event EventHandler CanExecuteChanged;

        public NewNotebookCommand(NotesViewModel vm)
        {
            VM = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            VM.CreateNotebook();
        }
    }
}
