using MyCourseManagement.Common;

namespace MyCourseManagement.Models
{
    public class LoginModel : NotifyBase
    {
        private string _userName;

        public string UserName
        {
            get => _userName;
            set
            {
                _userName = value;
                DoNotify();
            }
        }

        private string _password;

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                DoNotify();
            }
        }

        private string _validationCode;

        public string ValidationCode
        {
            get => _validationCode;
            set
            {
                _validationCode = value;
                DoNotify();
            }
        }

    }
}
