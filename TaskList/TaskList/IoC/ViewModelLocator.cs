using TaskList.ViewModel;

namespace TaskList.IoC {
    public class ViewModelLocator {
        public LoginViewModel LoginViewModel => IocKernel.Get<LoginViewModel>();
        public MainViewModel MainViewModel => IocKernel.Get<MainViewModel>();
        public CabinetViewModel CabinetViewModel => IocKernel.Get<CabinetViewModel>();
    }
}