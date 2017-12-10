using TaskList.Model.Context;
using TaskList.Model.Model;
using TaskList.ViewModel;

namespace TaskList.IoC {
    public static class Constants {
        public static TaskListContext Db => IocKernel.Get<TaskListContext>();
        public static MainViewModel Main => IocKernel.Get<MainViewModel>();
        public static Employee CurrentEmployee => IocKernel.Get<Employee>("CurrentEmployee");
    }
}