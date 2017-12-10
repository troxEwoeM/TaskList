using System;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using TaskList.IoC;
using TaskList.Utils;

namespace TaskList.ViewModel {
    public class LoginViewModel : BaseViewModel {
        private string _password;
        private string _login;

        public string Login {
            get => _login;
            set {
                _login = value;
                if (value.Length < 4)
                    throw new Exception("Длина логина не может быть меньше 4 символов");
                if (value.Length > 12)
                    throw new Exception("Длина логина не может быть больше 12 символов");
                if (value == _password)
                    throw new Exception("Логин не может быть равным паролю");
                OnPropertyChanged();
            }
        }

        public string Password {
            get => _password;
            set {
                _password = value;
                if (value.Length < 4)
                    throw new Exception("Длина пароля не может быть меньше 4 символов");
                if (value.Length > 12)
                    throw new Exception("Длина пароля не может быть больше 12 символов");
                if (value == _login)
                    throw new Exception("Пароль не может быть равным логину");
                OnPropertyChanged();
            }
        }

        public ICommand LoginCommand => new RelayCommand(LoginAction, LoginCanExecute);

        public LoginViewModel() {
            Login = "admin";
            Password = "qweqwe";
        }

        private async void LoginAction(object obj) {
            using (var db = Constants.Db)
            {
                var employee = await db.Employees.Include(x => x.Permissions)
                    .FirstOrDefaultAsync(x => x.Login == Login && x.Password == Password);
                if (employee == null) {
                    MessageBox.Show("Пользователь не найден", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error,
                        MessageBoxResult.OK);
                    return;
                }
                IocKernel.Bind(employee, "CurrentEmployee");
                Constants.Main.CurrentView = IocKernel.Get<CabinetViewModel>();
            }
        }

        private bool LoginCanExecute(object arg) {
            return (Login.Length >= 4 && Login.Length <= 12) && (Password.Length >= 4 && Password.Length <= 12) && Password != Login;
        }
    }
}