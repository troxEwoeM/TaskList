using Ninject.Modules;
using TaskList.Model.Context;
using TaskList.ViewModel;

namespace TaskList.IoC {
    public class IocConfiguration : NinjectModule {
        public override void Load() {
            Bind<TaskListContext>().ToSelf().InTransientScope();
            Bind<LoginViewModel>().ToSelf().InTransientScope();
            Bind<MainViewModel>().ToSelf().InSingletonScope();
            Bind<CabinetViewModel>().ToSelf().InTransientScope();
        }
    }
}