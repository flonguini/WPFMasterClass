using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp.Model
{
    public class Note : ModelBase
    {
        private int _id;
        private int _notebookId;
        private string _title;
        private DateTime _updatedTime;
        private string _fileLocation;
        private DateTime _createdTime;

        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get { return _id; }
            set { _id = value; OnPropertyChanged(); }
        }
        [Indexed]
        public int NotebookId
        {
            get { return _notebookId; }
            set { _notebookId = value; OnPropertyChanged(); }
        }


        public string Title
        {
            get { return _title; }
            set { _title = value; OnPropertyChanged(); }
        }

        public DateTime CreatedTime
        {
            get { return _createdTime; }
            set { _createdTime = value; OnPropertyChanged(); }
        }
 
        public DateTime UpdatedTime
        {
            get { return _updatedTime; }
            set { _updatedTime = value; OnPropertyChanged(); }
        }
        
        public string FileLocation
        {
            get { return _fileLocation; }
            set { _fileLocation = value; OnPropertyChanged(); }
        }
    }
}
