using Ninject;
using Ninject.Modules;

namespace TaskList.IoC {
    public static class IocKernel {
        private static StandardKernel _kernel;

        public static T Get<T>() {
            return _kernel.Get<T>();
        }

        public static T Get<T>(string name) {
            return _kernel.Get<T>(name);
        }

        public static void Bind<T>(T value, string name) {
            _kernel.Bind<T>().ToConstant(value).InSingletonScope().Named(name);
        }

        public static void Initialize(params INinjectModule[] modules) {
            _kernel = new StandardKernel(modules);
        }
    }
}