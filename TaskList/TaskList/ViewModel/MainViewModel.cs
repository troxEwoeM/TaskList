namespace TaskList.ViewModel {
    public class MainViewModel : BaseViewModel {
        private BaseViewModel _currentView;
        private string _title;

        public BaseViewModel CurrentView {
            get => _currentView;
            set {
                OnPropertyChanging();
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public string Title {
            get => _title;
            set {
                OnPropertyChanging();
                _title = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel(LoginViewModel loginView) {
            CurrentView = loginView;
            Title = "Авторизация";
        }
    }
}