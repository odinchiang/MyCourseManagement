using System.Windows;
using MyCourseManagement.Common;
using MyCourseManagement.Models;

namespace MyCourseManagement.ViewModels
{
    public class LoginViewModel
    {
        public LoginModel Login { get; set; }

        public CommandBase CloseWindowCommand { get; set; }

        public LoginViewModel()
        {
            Login = new LoginModel()
            {
                UserName = "Odin"
            };

            CloseWindowCommand = new CommandBase()
            {
                DoExecute = x =>
                {
                    (x as Window).Close();
                },
                DoCanExecute = x => true
            };
        }
    }
}
