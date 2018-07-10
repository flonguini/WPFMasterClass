using NotesApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp.ViewModel
{
    public class NotesViewModel
    {
        public ObservableCollection<Notebook> Notebook { get; set; }

        private Notebook _notebook;

        public Notebook SelectedNotebook
        {
            get { return _notebook; }
            set
            {
                _notebook = value;
                //TODO: get notes
            }
        }

        public ObservableCollection<Note> Notes { get; set; }

    }
}
