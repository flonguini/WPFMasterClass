using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp.Model
{
    public class Note
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private int _notebookId;

        public int NotebookId
        {
            get { return _notebookId; }
            set { _notebookId = value; }
        }

        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private DateTime _createdTime;

        public DateTime CreatedTime
        {
            get { return _createdTime; }
            set { _createdTime = value; }
        }

        private DateTime _updatedTime;

        public DateTime MyProperty
        {
            get { return _updatedTime; }
            set { _updatedTime = value; }
        }


    }
}
