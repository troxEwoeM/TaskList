using System;
using System.IO;
using System.Windows;
using TaskList.IoC;

namespace TaskList {
    public partial class App {
        private void App_OnStartup(object sender, StartupEventArgs e) {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Databases");
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            IocKernel.Initialize(new IocConfiguration());
        }
    }
}