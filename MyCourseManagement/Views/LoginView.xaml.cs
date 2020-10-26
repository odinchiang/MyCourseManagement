using System.Windows;
using MyCourseManagement.ViewModels;

namespace MyCourseManagement.Views
{
    /// <summary>
    /// LoginView.xaml 的互動邏輯
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();

            DataContext = new LoginViewModel();
        }
    }
}
