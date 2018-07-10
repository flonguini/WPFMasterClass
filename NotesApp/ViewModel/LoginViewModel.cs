using NotesApp.Model;
using NotesApp.ViewModel.Commands;

namespace NotesApp.ViewModel
{
    public class LoginViewModel
    {
        private User _user;

        public User User
        {
            get { return _user; }
            set { _user = value; }
        }

        public RegisterCommand RegisterCommand { get; set; }
        public LoginCommand LoginCommand { get; set; }

        public LoginViewModel()
        {
            RegisterCommand = new RegisterCommand(this);
            LoginCommand = new LoginCommand(this);
        }
    }
}
