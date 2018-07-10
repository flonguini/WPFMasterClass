using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp.Model
{
    public class Notebook : ModelBase
    {
        private int _id;
        private int _userId;
        private string _name;

        public int Id
        {
            get { return _id; }
            set { _id = value; OnPropertyChanged(); }
        }

        public int Userid
        {
            get { return _userId; }
            set { _userId = value; OnPropertyChanged(); }
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(); }
        }

    }
}
