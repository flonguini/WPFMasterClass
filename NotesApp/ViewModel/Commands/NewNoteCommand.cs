using NotesApp.Model;
using System;
using System.Windows.Input;

namespace NotesApp.ViewModel.Commands
{
    public class NewNoteCommand : ICommand
    {
        public NotesViewModel VM { get; set; }

        public NewNoteCommand(NotesViewModel vm)
        {
            VM = vm;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            //Notebook selectedNotebook = parameter as Notebook;
            if (parameter is Notebook selectedNotebook)
            {
                return true;
            }
            return false;
        }

        public void Execute(object parameter)
        {
            Notebook selectedNotebook = parameter as Notebook;
            VM.CreateNote(selectedNotebook.Id);
            //TODO
        }
    }
}
