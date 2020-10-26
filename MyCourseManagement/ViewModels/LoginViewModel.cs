using System.Windows;
using MyCourseManagement.Common;

namespace MyCourseManagement.ViewModels
{
    public class LoginViewModel
    {
        public CommandBase CloseWindowCommand { get; set; }

        public LoginViewModel()
        {
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
