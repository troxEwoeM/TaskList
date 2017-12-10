using System.Windows;

namespace TaskList.View {
    public partial class LoginView {
        public LoginView() {
            InitializeComponent();
        }

        private void LoginView_OnLoaded(object sender, RoutedEventArgs e) {
            if (TextBoxLogin.Text.Length > 0)
                PasswordBox.Focus();
            else
                TextBoxLogin.Focus();
        }
    }
}