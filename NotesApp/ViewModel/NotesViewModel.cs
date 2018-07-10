using NotesApp.Model;
using NotesApp.ViewModel.Commands;
using SQLite;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace NotesApp.ViewModel
{
    public class NotesViewModel
    {
        public ObservableCollection<Notebook> Notebooks { get; set; }

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
        public NewNotebookCommand NewNotebookCommand { get; set; }
        public NewNoteCommand NewNoteCommand { get; set; }

        public NotesViewModel()
        {
            NewNoteCommand = new NewNoteCommand(this);
            NewNotebookCommand = new NewNotebookCommand(this);

            Notebooks = new ObservableCollection<Notebook>();
            Notes = new ObservableCollection<Note>();

            ReadNotebooks();
        }
        public void CreateNotebook()
        {
            Notebook newNotebook = new Notebook()
            {
                Name = "New notebook"
            };
            DatabaseHelper.Insert(newNotebook);
        }

        public void CreateNote(int notebookId)
        {
            Note newNote = new Note()
            {
                NotebookId = notebookId,
                CreatedTime = DateTime.Now,
                UpdatedTime = DateTime.Now,
                Title = "New note"
            };

            DatabaseHelper.Insert(newNote);
        }

        public void ReadNotebooks()
        {
            using (SQLiteConnection conn = new SQLiteConnection(DatabaseHelper.dbFile))
            {
                var notebooks = conn.Table<Notebook>().ToList();

                Notebooks.Clear();

                foreach (var notebook in notebooks)
                {
                    Notebooks.Add(notebook);
                }
            }
        }

        public void ReadNotes()
        {
            using (SQLiteConnection conn = new SQLiteConnection(DatabaseHelper.dbFile))
            {
                if (SelectedNotebook != null)
                {
                    var notes = conn.Table<Note>().Where(n => n.NotebookId == SelectedNotebook.Id).ToList();

                    Notes.Clear();

                    foreach (var note in notes)
                    {
                        Notes.Add(note);
                    }
                }
            }
        }

    }
}
