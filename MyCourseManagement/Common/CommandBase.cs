using System;
using System.Windows.Input;

namespace MyCourseManagement.Common
{
    public class CommandBase : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public Action<object> DoExecute { get; set; }
        public Func<object, bool> DoCanExecute { get; set; }

        public bool CanExecute(object parameter)
        {
            return DoCanExecute?.Invoke(parameter) == true;
        }

        public void Execute(object parameter)
        {
            DoExecute?.Invoke(parameter);
        }
    }
}
